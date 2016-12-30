using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Server.WebListener;

namespace FxCoreMvcAppWebListener
{
    public class Program
    {
        public static void Main(string[] args) {
            var config = new ConfigurationBuilder().AddCommandLine(args).AddEnvironmentVariables("ASPNETCORE_").Build();
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                //.UseKestrel()
                .UseWebListener()
                .UseUrls("http://+:5001")
                .UseContentRoot(Directory.GetCurrentDirectory())
                //.UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
