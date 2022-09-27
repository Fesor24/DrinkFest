using DrinkFest.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DrinkFest.Data;
using DrinkFest.Models;
using DrinkFest.Data.Repositories;


namespace DrinkFest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddMemoryCache();

            builder.Services.AddSession();
            
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();

            builder.Services.AddTransient<IDrinkRepository, DrinkRepository>();

            builder.Services.AddTransient<IOrderRepository, OrderRepository>();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddScoped(sp => ShoppingCart.GetCart(sp));
#if DEBUG
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

#endif
            builder.Services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 8;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequiredUniqueChars = 1;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(30);
                opt.Lockout.MaxFailedAccessAttempts = 3;
            });

            builder.Services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = "2075196096023504";
                options.AppSecret = "8859865f00db4cd73282c3566778d021";
            });
            
            var app = builder.Build();

            //if (args.Length == 1 && args[0].ToLower() == "seeddata")
            //    SeedData(app);

            

            //CreateDbIfNotExists(app);

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
           
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "categoryFilter",
                pattern: "Drink/{action}/{category?}",
                defaults: new { Controller = "Drink", action = "List" });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();



        }

    }
}