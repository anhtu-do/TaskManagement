using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ZWA.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    .UseStartup<Startup>()
                    .ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                              .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                              .AddJsonFile("ocelot.json")
                              .AddEnvironmentVariables();
                    })
                    .ConfigureServices(ex =>
                    {
                        ex.AddOcelot();
                    })
                    .Configure(async ex =>
                    {
                        await ex.UseOcelot();
                    });
                });
    }
}
