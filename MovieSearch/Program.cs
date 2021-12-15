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
// göra en metod för print i movie classen och bara skicka med id.
