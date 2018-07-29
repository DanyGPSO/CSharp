using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Variables
    {
        public void LesVariables()
        {
            int monAge = 25; //Variable Entier de -32768 à 32767
            string monPrenom = "Dany"; //Variable Type Chaine de charactere
            double pi = 3.14; //Variable avec des decimales
            bool estEtein = true; //Variable Vrai ou Faux
            byte unNombre = 255; //Variable Entier de 0 à 255
            char uneLettre = 'D'; //Variable une lettre

            Console.Write(monAge + monPrenom + pi + estEtein + unNombre + uneLettre);
        }
    }
}
