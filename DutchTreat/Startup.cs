namespace DutchTreat
{
    using DutchTreat.Data;
    using DutchTreat.Services;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using AutoMapper;
    using System.Reflection;
    using DutchTreat.Data.Entities;
    using Microsoft.AspNetCore.Identity;

    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<StoreUser, IdentityRole>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<DutchContext>();

            services.AddDbContext<DutchContext>();

            services.AddTransient<IMailService, NullMailService>();

            services.AddTransient<DutchSeeder>();

            services.AddScoped<IDutchRepository, DutchRepository>();

            services.AddControllersWithViews()
              .AddRazorRuntimeCompilation();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Add Error Page
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(cfg =>
            {
                cfg.MapControllerRoute("Fallback",
                  "{controller}/{action}/{id?}",
                  new { controller = "App", action = "Index" });

                cfg.MapRazorPages();
            });
        }
    }
}
