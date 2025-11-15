using Archive.Core.Abstractions.Common.Utilities;
using Archive.Core.Abstractions.MovieSpace.Services.admin;
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
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace Archive.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load("../");

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

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

            builder.Services.AddValidatorsFromAssemblyContaining<ActorCreateDtoValidator>();

            builder.Services.AddScoped<IMovieFilePathFactory, MovieFilePathFactory>();
            builder.Services.AddScoped<IFilePathFactory, FilePathFactory>();
            builder.Services.AddScoped<IFileManager, FileManager>();
            //builder.Services.AddScoped<IActorService, ActorService>();
            builder.Services.AddScoped<IMovieService, MovieService>();

            builder.Services.AddAutoMapper(config => config.AddProfile<ActorMapper>());

            //потом изменить хранение сессии в редисе или SQL Server: AddSqlServerCache()
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

                    context.Response.Redirect($"Home");
                });
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
