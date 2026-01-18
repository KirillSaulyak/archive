using Archive.Core.Abstractions.Common.Utilities;
using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.Mappers.MovieSpace.Admin;
using Archive.Core.Validators.MovieSpace.Actor;
using Archive.Infrastructure.Persistence;
using Archive.Infrastructure.Utilities;
using Archive.Services.Abstractions.Factories.Common;
using Archive.Services.Abstractions.Factories.MovieSpace;
using Archive.Services.Factories.Common;
using Archive.Services.Factories.MovieSpace;
using Archive.Services.Services.MovieSpace.Admin;
using DotNetEnv;
using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Archive.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load("../");

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            //Database
            const string envDbName = "MSSQL_DB_NAME";
            const string envDbUser = "MSSQL_USER";
            const string envDbPassword = "MSSQL_PASSWORD";
            string mssqlDbName = Environment.GetEnvironmentVariable(envDbName) ?? throw new EnvVariableNotFoundException("Wrong env DB name: ", envDbName);
            string mssqlUser = Environment.GetEnvironmentVariable(envDbUser) ?? throw new EnvVariableNotFoundException("Wrong env DB User: ", envDbUser);
            string mssqlPassword = Environment.GetEnvironmentVariable(envDbPassword) ?? throw new EnvVariableNotFoundException("Wrong env DB Password: ", envDbPassword);
            string mssqlConnectionString = $"Server=localhost;Database={mssqlDbName};User ID={mssqlUser};Password={mssqlPassword};TrustServerCertificate=true;";

            const string defaultConnectionDb = "ConnectionStrings:DefaultConnection";
            builder.Configuration[defaultConnectionDb] = mssqlConnectionString;
            builder.Services.AddDbContext<ArchiveDbContext>(options => options.UseSqlServer(builder.Configuration[defaultConnectionDb]));

            //Validators
            builder.Services.AddValidatorsFromAssemblyContaining<ActorCreateDtoValidator>();

            //Factories
            builder.Services.AddScoped<IMovieFilePathFactory, MovieFilePathFactory>();
            builder.Services.AddScoped<IFilePathFactory, FilePathFactory>();

            //Utilities
            builder.Services.AddScoped<IFileManager, FileManager>();
            
            //Services
            builder.Services.AddScoped<IActorService, ActorService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICountryService, CountryService>();
            builder.Services.AddScoped<IDirectorService, DirectorService>();
            builder.Services.AddScoped<IGenreService, GenreService>();
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IThemeService, ThemeService>();
            builder.Services.AddScoped<ITranslatorService, TranslatorService>();
            
            //Mappers
            builder.Services.AddAutoMapper(config =>
            {
                config.AddProfile<ActorMapper>();
                config.AddProfile<CategoryMapper>();
                config.AddProfile<CountryMapper>();
                config.AddProfile<DirectorMapper>();
                config.AddProfile<GenreMapper>();
                config.AddProfile<MovieMapper>();
                config.AddProfile<ThemeMapper>();
                config.AddProfile<TranslatorMapper>();
            });

            //Для распределенного кэша в памяти, для SQL Server: AddSqlServerCache()
            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = ".Archive.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.Cookie.SameSite = SameSiteMode.Strict;
            });

            //Для того, чтобы пути в области MVC правильно работали для области MovieSpace
            //builder.Services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.AreaViewLocationFormats.Add("/Areas/Views/{2}/Movie/{1}/{0}.cshtml");
            //    //options.ViewLocationFormats.Add("Views/Movie/{1}/{0}.cshtml");
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();

            app.UseExceptionHandler(errorApp =>
            {

                errorApp.Run(async context =>
                {
                    var tempDataFactory = context.RequestServices.GetRequiredService<ITempDataDictionaryFactory>();
                    var tempData = tempDataFactory.GetTempData(context);


                    var errorFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var exception = errorFeature?.Error;
                    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
                    logger.LogError(exception, $"path:{errorFeature.Path}" +
                                               $" Request: {context.Request.Method}" +
                                               $" Request path: {context.Request.Path}");

                    tempData["ErrorMessage"] = exception.Message;
                    tempData.Save();

                    context.Response.Redirect($"Error");
                });
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllers();
            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Movie}/{action=Create}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
