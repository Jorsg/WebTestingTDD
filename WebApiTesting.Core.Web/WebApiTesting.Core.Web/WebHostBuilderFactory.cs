using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace WebApiTesting.Core.Web
{
    public class WebHostBuilderFactory
    {
        public static IWebHostBuilder Builder<TStartup>(string[] args)
            where TStartup : class
        {
            var dir = Directory.GetCurrentDirectory();

            return WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(dir)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                })
                .ConfigureAppConfiguration((context, builder) =>
                {
                    var en = context.HostingEnvironment;
                    builder.SetBasePath(en.EnvironmentName)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange : true)
                    .AddJsonFile($"appsettings.{en.EnvironmentName}.json", optional: true, reloadOnChange : true)
                    .AddEnvironmentVariables();
                })
                .UseStartup<TStartup>();
        }
    }
}
