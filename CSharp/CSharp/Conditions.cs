using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Conditions
    {
        public static void LesConditionsIf()
        {
            int compteEnBanque = 15000;

            if (compteEnBanque >= 0)
            {
                Console.WriteLine("Votre compte est positif");
            }
            else if (compteEnBanque <= 0)
            {
                Console.WriteLine("Votre compte est Negatif");
            }
            Console.ReadLine();
        }

        public static void LesConditionsSwitch()
        {
            int compteEnBanque = 1;

            switch(compteEnBanque)
            {
                case 0:
                    Console.WriteLine("Votre compte est de 0");
                    break;

                case 1:
                    Console.WriteLine("Votre compte est de 1");
                    break;
            }
            Console.ReadLine();
        }
    }
}
