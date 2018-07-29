using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Boucles
    {
        public static void LaBouclesFor()
        {
            int compteur = 0;

            for (compteur = 0; compteur < 20; compteur++)
            //Compteur = 0, Si compteur est inferieur a 0 ajoute +1 jusqua 20
            {
                Console.WriteLine("C " + compteur);
            }
            Console.ReadLine();
        }

        public static void LaBoucleForReach()
        {
            int[] Nombres = new int[] { 0, 1, 2 };

            foreach (int Nombre in Nombres)
            //Que faire pour chaque elements du tableau
            {
                Console.WriteLine(Nombre + " +1 ");
            }
        }

        public static void LaBoucleDoWhile()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 20);
        }
    }
}
