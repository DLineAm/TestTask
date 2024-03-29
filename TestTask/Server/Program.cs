﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;

using TestTask.Server.DAL.Context;
using TestTask.Server.Storage;

namespace TestTask.Server
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            ConfigureDatabase(host);
            InitializeCache(host);
            host.Run();
        }

        private static void InitializeCache(IHost host)
        {
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            var serviceCollection = services.GetRequiredService<DataServiceCollection>();

            serviceCollection.FillCache();
        }

        private static void ConfigureDatabase(IHost host)
        {
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<DatabaseContext>();
                var isDatabaseExists = ((RelationalDatabaseCreator) context.Database.GetService<IDatabaseCreator>()).Exists();
                context.Database.Migrate();

                if (isDatabaseExists) 
                    return;

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
