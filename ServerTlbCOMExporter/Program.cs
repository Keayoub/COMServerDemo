// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using COMServer;

Console.WriteLine("Hello, World!");
var myComObject = new Server();

// Create a type library exporter
var exporter = new TypeLibExporter();

// Export the type library to a file
exporter.ExportResolvedComTypeToFile(
    typeof(Server).Assembly.Location,
    myComObject.GetType().GUID,
    "COMServer.Server.tlb");

// Release the COM object
Marshal.ReleaseComObject(myComObject);