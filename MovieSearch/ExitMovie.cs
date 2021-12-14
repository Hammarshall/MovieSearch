using System;
using static System.Console;

namespace MovieSearch
{
    public class ExitMovie
    {
        public static void ExitProgram()//Metod namn 
        {
            Write("Press any key to exit the program");
            ReadKey(true);
            Clear();
            Environment.Exit(0);
        }
    }
}

