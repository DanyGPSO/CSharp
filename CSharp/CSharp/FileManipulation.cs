using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp
{
    class FileManipulation
    {
        public void CreateAndWriteInFile()
        {
            string filePath = "C:\\test test\\Bonjour.txt";
            string filePath2 = "C:\\test test\\Bonjour.txt";

            if (!File.Exists(filePath)) 
            //Si le fichier existe pas
            {
                File.WriteAllText(filePath, "Bonjour" + Environment.NewLine + "Bonjour2"); //Creer un fichier et ecrit du text dans le fichier
                File.Copy(filePath, filePath2); //Copy in fichier dans un autre repertoire
                File.Delete(filePath); //Supprime un fichier
            }
            else if (File.Exists(filePath)) { }
                //Si le fichier existe deja                      
        }
    }
}