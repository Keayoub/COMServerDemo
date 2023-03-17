// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using COMServerExporter;

var assembly = Assembly.GetExecutingAssembly();
var typeLibExporter = new TypeLibExporter();

typeLibExporter.ExportTypeLibToFile(assembly.Location, "MyComClass.tlb",
    new ExporterCallback(), IntPtr.Zero);

Console.WriteLine("Type library exported successfully!");
