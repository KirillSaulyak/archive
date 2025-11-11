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
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Archive.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load("../");
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ArchiveDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddValidatorsFromAssemblyContaining<ActorCreateDtoValidator>();

            //builder.Services.AddScoped<IActorService, ActorService>();
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IFileManager, FileManager>();
            builder.Services.AddScoped<IMovieFilePathFactory, MovieFilePathFactory>();
            builder.Services.AddScoped<IFilePathFactory, FilePathFactory>();

            builder.Services.AddAutoMapper(config => config.AddProfile<ActorMapper>());

            string? mssqlDbName = Environment.GetEnvironmentVariable("MSSQL_DB_NAME");
            string? mssqlUser = Environment.GetEnvironmentVariable("MSSQL_USER");
            string? mssqlPassword = Environment.GetEnvironmentVariable("MSSQL_PASSWORD");
            string mssqlConnectionString = $"Server=localhost;Database={mssqlDbName};User ID={mssqlUser};Password={mssqlPassword};TrustServerCertificate=true;";
            builder.Configuration["ConnectionStrings:DefaultConnection"] = mssqlConnectionString;

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

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
