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

            Console.WriteLine("Désintallation des Apps Windows pour tous les utilisateurs...\n");
            process.StandardInput.WriteLine("PowerShell.exe -ExecutionPolicy Bypass \\\\gpso-srv-sipc\\Sources\\Win10\\DEP\\01-ApplicationW10\\UninstalOnlineApp.ps1");
            Thread.Sleep(60000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Désinstallation des Apps Windows Terminé.\n");

            process.StandardInput.WriteLine("PowerShell.exe -ExecutionPolicy Bypass \\\\gpso-srv-sipc\\Sources\\Win10\\DEP\\01-ApplicationW10\\InstalAppBase.ps1");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Installation de la Calculatrice, Visioneuse de photos, StickyNotes... \n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Installation de la Calculatrice Terminé.");

            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Installation de la Visioneuse de photos Terminé.");

            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Installation de StickyNotes Terminé.\n");

            Console.WriteLine("Installation Terminé.");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
        }
    }
}
