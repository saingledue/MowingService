using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlazorClientWebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient {
                //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
                //BaseAddress = new Uri("https://mywebsite.com")
                BaseAddress = new Uri("https://localhost:44367/")
            }); ;

            await builder.Build().RunAsync();
        }
    }
}
