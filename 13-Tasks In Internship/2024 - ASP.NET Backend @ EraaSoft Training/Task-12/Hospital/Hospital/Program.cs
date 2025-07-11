using Hospital.Data;

namespace Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Connection With DataBase
            var ConnectionString = builder.Configuration.GetConnectionString(name: "DefultConnection")
                ?? throw new InvalidOperationException(message: "No Connection String Was Not Found");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(ConnectionString));


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}


// todo : Add Theam and font and file bootstrap done
// todo : Add ef abd DbContext done 
// todo : 



