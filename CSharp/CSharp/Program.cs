using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\test test\\Bonjour.txt";
            string filePath2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Bonjour.txt");

            if (File.Exists(filePath))
            {
                File.Copy(filePath, filePath3);
            }
        }
    }
}
