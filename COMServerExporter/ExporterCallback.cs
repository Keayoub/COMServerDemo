using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace COMServerExporter
{
    internal class ExporterCallback : ITypeLibExporterNotifySink
    {
        public void ReportEvent(ExporterEventKind eventKind, int eventCode, string eventMsg)
        {
            Console.WriteLine("Event: {0}", eventMsg);
        }

        public Object ResolveRef(Assembly assembly)
        {
            Console.WriteLine("Resolving reference to {0}", assembly.FullName);
            return null;
        }
    }
}
