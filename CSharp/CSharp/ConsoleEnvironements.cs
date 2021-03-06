﻿using System;
using System.Collections.Generic;
using System.IO; //APPDATA
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//@Params \t = Tabulation
//@Params \n = Saut de ligne

namespace CSharp
{
    class ConsoleEnvironements
    {
        static void EnvironementsWindows()
        {
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Bonjour.txt"); //Atteindre le dossier %APPDATA%
            string monChoix = Console.ReadLine(); //Demandez a l'utilisateur de rentez des informations
            Console.Write(System.DateTime.Now); //Console date actuel
            Console.Write(Environment.NewLine); //Console saut de ligne
            Console.Write(System.Environment.UserName); //Console nom d'utilisateur Windows actuel
            Console.Write(DateTime.Now.Hour); //Console Affiche Heur actuel
            Console.Write(DateTime.Now.DayOfWeek == DayOfWeek.Friday); //Console Affiche un jour de la semaine au choix
            Console.Write(DateTime.Now.DayOfWeek); //Console Affiche un jour de la semaine actuel
            Console.ForegroundColor = ConsoleColor.Gray; //Changer la couleur du text
            Console.ReadLine(); //Console faire une pause
            Thread.Sleep(60000); //Faire une pause entre 2 codes
        }
    }
}
