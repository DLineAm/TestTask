using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using TestTask.Server.DAL;
using TestTask.Server.DAL.Context;
using TestTask.Server.Utils;

namespace TestTask.Server
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            ConfigureDatabase(host);
            FillCache(host);
            host.Run();
        }

        private static void FillCache(IHost host)
        {
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            using var unitOfWork = services.GetRequiredService<UnitOfWork>();

            var cache = services.GetRequiredService<Cache>();

            var divisions = unitOfWork.DivisionRepository.GetWithChildren();

            cache.DivisionStorage.Fill(divisions);

            var employees = unitOfWork.EmployeeRepository.GetWithChildren();

            cache.EmployeeStorage.Fill(employees);
        }

        private static void ConfigureDatabase(IHost host)
        {
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<DatabaseContext>();
                var isDatabaseExists = (context.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists();
                context.Database.Migrate();

                if (isDatabaseExists) return;

                var initializer = services.GetRequiredService<IDataInitializer>();
                initializer.Initialize(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
