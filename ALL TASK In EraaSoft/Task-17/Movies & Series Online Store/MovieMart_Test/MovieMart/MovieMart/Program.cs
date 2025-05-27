using Microsoft.AspNetCore.Identity;
using MovieMart.Data;
using MovieMart.Repositories;
using MovieMart.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using MovieMart.Utility;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MovieMart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add MVC services to the application, allowing the use of the Model-View-Controller architecture
            builder.Services.AddControllersWithViews();

            // Add support for Razor Pages, allowing the creation of dynamic web pages using Razor Syntax
            builder.Services.AddRazorPages();

            // Register MovieMartDbContext with Dependency Injection 
            // Configured to use SQL Server with the connection string from app settings.
            builder.Services.AddDbContext<MovieMartDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



            // Add identity services to the application
            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                // Password requirements:
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 8;

                // User requirements:
                options.User.RequireUniqueEmail = true;

                // Login settings:
                options.SignIn.RequireConfirmedEmail = false;
            })
            .AddRoles<IdentityRole>()
            // Bind the identity to the database using Entity Framework
            .AddEntityFrameworkStores<MovieMartDbContext>()
            // Add default token providers to support operations like password reset and email confirmation
            .AddDefaultTokenProviders();

            // Register repository services with Dependency Injection (Scoped Lifetime) 
            // This ensures that a new instance is created per request, improving efficiency 
            // while maintaining consistency within a request's lifecycle.
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
            builder.Services.AddScoped<IEpisodeRepository, EpisodeRepository>();
            builder.Services.AddScoped<IMovieRepository, MovieRepository>();
            builder.Services.AddScoped<ISeasonRepository, SeasonRepository>();
            builder.Services.AddScoped<ITvSeriesRepository, TvSeriesRepository>();

            builder.Services.AddSingleton<IEmailSender, EmailSender>();



            var app = builder.Build();

            // Configure the HTTP Request Pipeline
            if (!app.Environment.IsDevelopment())
            {
                // Redirect errors to a dedicated page
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // Enable HSTS to improve security in production environments
                app.UseHsts();
            }

            // Force HTTPS on all requests
            app.UseHttpsRedirection();

            // Enable loading of static files such as CSS and JavaScript
            app.UseStaticFiles();

            // Enable routing requests to the appropriate paths
            app.UseRouting();

            // Enable Authentication
            // Ensures that incoming requests pass user identity verification before accessing protected resources           
            app.UseAuthentication();

            // Enable Authorization
            // Determines whether the authenticated user has the required permissions to access certain resources           
            app.UseAuthorization();

            // Set paths for Razor pages within the application and enable routing for them
            app.MapRazorPages();

            // Configuring endpoint routing for different application areas
            app.UseEndpoints(endpoints =>
            {
                // Route for the #Admin area
                endpoints.MapControllerRoute(
                name: "Admin",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                // Route for the #Customer area
                endpoints.MapControllerRoute(
                name: "Customer",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                // Set the default path for the application
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}",
                    defaults: new { area = "Customer" } // Define the default region
                );

            });

            // Run the application
            app.Run();
        }
    }
}
