using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMClientFramework48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = Type.GetTypeFromProgID("COMServer.Server");
            dynamic wordObj = Activator.CreateInstance(server);
            if (wordObj != null)
            {
                var pi = wordObj.ComputePi();
                Console.WriteLine($"\u03C0 = {pi}");
            }
        }
    }
}
