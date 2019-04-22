using System;
using System.Collections.Generic;
using System.Text;
using CodePersuit.Core;
using DasMulli.Win32.ServiceUtils;
using Microsoft.AspNetCore.Hosting;

namespace CodePersuit.Windows.Service
{
    class ServiceHost : DasMulli.Win32.ServiceUtils.IWin32Service
    {
        public string ServiceName => "CodePersuit.Service";
        private IWebHost _host;

        public void Start(string[] startupArguments, ServiceStoppedCallback serviceStoppedCallback)
        {
            _host = new WebHostBuilder()
                    .UseKestrel()
                    //   .UseUrls("http://*:5000")
                    .UseStartup<Startup>()
                    .Build();

            _host.Start();
        }

        public void Stop()
        {
            _host.Dispose();
            _host = null;
        }
    }
}
