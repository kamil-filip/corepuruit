using DasMulli.Win32.ServiceUtils;
using System;
using System.Diagnostics;
using System.Linq;

namespace CodePersuit.Windows.Service
{
    class Program
    {

        //Installed DasMulli
        //Installed Kestrel
        static void Main(string[] args)
        {
            var host = new ServiceHost();

            if(Debugger.IsAttached)
            {
                host.Start(null, null);
                Console.ReadLine();
                host.Stop();
            }
            else
            {
                var win32Host = new Win32ServiceHost(host);
                win32Host.Run();
            }

        }
    }
}
