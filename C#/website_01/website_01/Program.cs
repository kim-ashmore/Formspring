using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace website_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string appName = "Open Form";
            string appVersion = "1.0";
            string appAuthor = "Kimberlee Ashmore";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Kimberlee Ashmore is the raddest.");
            // Run app
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
