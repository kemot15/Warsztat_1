using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    static class Menu
    {
        public static string mainMenu()
        {
            Console.WriteLine("Podaj numer opcji:");
            Console.WriteLine("1 - dodaj");
            Console.WriteLine("0 - wyjście");
            return Console.ReadLine();
        }
    }
}
