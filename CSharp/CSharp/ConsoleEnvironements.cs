using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@Params \t = Tabulation
//@Params \n = Saut de ligne

namespace CSharp
{
    class ConsoleEnvironements
    {
        static void EnvironementsWindows()
        {
            Console.Write(System.DateTime.Now);
            Console.Write(Environment.NewLine);
            Console.Write(System.Environment.UserName);
            Console.ReadLine();
            //Console date actuel
            //Console saut de ligne
            //Console nom d'utilisateur Windows actuel
            //Console faire une pause
        }
    }
}
