using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FxCoreMvcApp
{
    public class Program
    {
        public static void Main(string[] args) {
            var config = new ConfigurationBuilder().AddCommandLine(args).AddEnvironmentVariables("ASPNETCORE_").Build();
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}