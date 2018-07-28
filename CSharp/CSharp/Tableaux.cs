using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Tableaux
    {
        public static void LesTableaux()
        {
            string[] Jours = new string[] { "Lundi", "Mardi", "Mercredi" };
            //On declare un Tableaux

            string[] Semaines = new string[3];
            Semaines[0] = "Semaine 1";
            Semaines[1] = "Semaine 2";
            Semaines[2] = "Semaine 3";
            //Autre maniere de declarer un tableaux

            Array.Sort(Semaines);
            //Classement du tableau par ordre alphabetique

            for (int i = 0; i < Semaines.Length; i++)
            {
                Console.Write(Semaines[i] + Environment.NewLine);      
            }
            //On fait une boucle pour affichier tout le contenue du tableau avec des sauts de lignes
        }
    }
}
