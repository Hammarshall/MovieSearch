using System;
using static System.Console;

namespace MovieSearch
{
    public class ExitMovie
    {
        public static void ExitProgram() //metod 
        {
            Console.Write("Press any key to exit the program");
            Console.ReadKey(true);

            Console.Clear();

            Environment.Exit(0);
        }

    }
}

