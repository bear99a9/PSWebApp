namespace DutchTreat
{
    using DutchTreat.Data;
    using DutchTreat.Services;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DutchContext>();

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddRazorPages();
            services.AddTransient<IMailService, NullMailService>();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(cfg =>
           {
               cfg.MapRazorPages();

               cfg.MapControllerRoute("Default", "/{controller}/{action}/{id?}", new { controller = "App", action = "Index" });
           });
        }
    }
}
