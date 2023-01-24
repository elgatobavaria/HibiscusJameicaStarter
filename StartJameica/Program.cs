using System;
using System.Diagnostics;
using System.IO;

namespace StartJameica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentPath = Directory.GetCurrentDirectory();
            string jameicaExePath = Path.Combine(currentPath, "jameica-win64.exe");
            string arguments = "-f "+'\u0022'+ $"{Path.GetFullPath(Path.Combine(Path.GetFullPath(currentPath), @"..\.jameica"))+ '\u0022'}";

            Process p = new Process();
            p.StartInfo.FileName = jameicaExePath;
            p.StartInfo.Arguments = arguments;
            p.Start();
        }
    }
}
