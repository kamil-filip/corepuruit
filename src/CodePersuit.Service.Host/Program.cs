using CodePersuit.Core;
using Microsoft.AspNetCore.Hosting;
using System;

namespace CodePersuit.Service.Host
{
    class Program
    {
        //Install Kestrel
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
             //   .UseUrls("http://*:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
