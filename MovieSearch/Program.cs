using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;

namespace MovieSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Startmenu start = new Startmenu();//Kallar på metoden för start meny.
            start.Start();//Kallar på metoden för att starta menyn.
        }
    }
}
// TO DO LIST
//söka på titel, issues få med home page.
// får ibland ej med alla parametrar

