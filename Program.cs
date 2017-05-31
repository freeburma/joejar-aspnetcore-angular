using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace aspnetcore_angular_sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Calling the hosting.json file from wwwroot: client side folder
            var config = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile ("hosting.json", optional: true)
                         .Build (); 

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseConfiguration (config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
