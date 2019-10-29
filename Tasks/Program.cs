using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Menu.mainMenu();
                if (command.Equals("0"))
                {
                    break;
                }
                else if (command.Equals("1")){
                    Console.WriteLine("dodawanie tasku");
                }
            }
        }
    }
}
