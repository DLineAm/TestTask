using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

using Newtonsoft.Json;

using TestTask.Server.DAL;
using TestTask.Server.DAL.Context;
using TestTask.Server.Services;
using TestTask.Server.Utils;
using TestTask.Shared;

namespace TestTask.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });

            services.AddRazorPages();

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TestDB")).EnableSensitiveDataLogging());

            services.AddScoped<UnitOfWork>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IDivisionService, DivisionService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IDataInitializer, DatabaseInitializer>();
            services.AddSingleton<IStorage<Division>, CacheStorage<Division>>();
            services.AddSingleton<IStorage<Employee>, CacheStorage<Employee>>();
            services.AddSingleton<Cache>();
            services.AddScoped<IDivisionStorageService, DivisionStorageService>();
            services.AddScoped<IEmployeeStorageService, EmployeeStorageService>();
            services.AddScoped<DataServiceCollection>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
