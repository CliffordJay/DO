using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pathToContentRoot = Directory.GetCurrentDirectory();

            var webHostArgs = args.Where(arg => arg != "--console").ToArray();

            var host = WebHost.CreateDefaultBuilder(webHostArgs)
                .UseContentRoot(pathToContentRoot)
                .UseUrls("http://*:5000")
                .UseStartup<Startup>()
                .Build();

            
                host.Run();
         
        }

       
    }
}
