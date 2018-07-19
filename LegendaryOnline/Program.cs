using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace LegendaryOnline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((webHostBuilderContext, configurationBuilder) =>
            {
                var env = webHostBuilderContext.HostingEnvironment;
                configurationBuilder.AddJsonFile("appsettings-dev.json", optional: true);
            })
                .UseStartup<Startup>()
                .Build();
    }
}
