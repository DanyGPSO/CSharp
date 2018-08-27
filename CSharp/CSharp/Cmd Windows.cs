using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace WindowsAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            Console.WriteLine("Désintallation des Apps Windows pour l'utilisateur...\n");
            process.StandardInput.WriteLine("PowerShell.exe -ExecutionPolicy Bypass \\\\gpso-srv-sipc\\Sources\\Win10\\DEP\\01-ApplicationW10\\UninstalCurrentUserApp.ps1");
            Thread.Sleep(60000);

            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
        }
    }
}
