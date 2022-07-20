using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using Blazored.SessionStorage.Serialization;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json;
using TestTask.Client.Services;

namespace TestTask.Client
{
    public class Program
    {
        public static AppData AppData;
        public static string LastPageUrl = "";
        public static bool AfterEmployeeInfoPage;
        public static int CurrentDivisionId;
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredSessionStorage(config =>
            {
                //config.JsonSerializerOptions.MaxDepth = 1;
                config.JsonSerializerOptions.WriteIndented = false;
                //config.JsonSerializerOptions.
            });
            builder.Services.Replace(ServiceDescriptor.Scoped<IJsonSerializer, NewtonSoftJsonSerializer>());
            builder.Services.AddScoped<AppData>();
            builder.Services.AddScoped<StateMachine>();
            builder.Services.AddScoped<EventAggregator>();

            var host = builder.Build();
            AppData = host.Services.GetService<AppData>();
            await AppData.InitializeBaseProperties();
                await host.RunAsync();
        }
    }

    public class NewtonSoftJsonSerializer : IJsonSerializer
    {
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T Deserialize<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}
