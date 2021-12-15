using System;
using static System.Console;

namespace MovieSearch
{
    public class ExitMovie
    {
        public static void ExitProgram()//Metod namn 
        {
            string text = @"
______________ ______________    ___________ _______  ________ ._.
\__    ___/   |   \_   _____/    \_   _____/ \      \ \______ \| |
  |    | /    ~    \    __)_      |    __)_  /   |   \ |    |  \ |
  |    | \    Y    /        \     |        \/    |    \|    `   \|
  |____|  \___|_  /_______  /    /_______  /\____|__  /_______  /_
                \/        \/             \/         \/        \/\/
";
            WriteLine(text);

            Write("Press any key to exit the program");
            ReadKey(true);
            Clear();
            Environment.Exit(0);
        }
    }
}

