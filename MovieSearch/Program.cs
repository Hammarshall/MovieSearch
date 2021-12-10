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
            Startmenu start = new Startmenu(); //kallar på metoden för start meny
            start.Start(); // kallar på metoden för att starta menyn
        }
    }
}

// TO DO LIST:

//söka efter film med id
//visa titel, beskrivning,speltid,release date,URL för hemsida,medelbetyg,URL för poster,originalspråk
//alt output om ingen film matchar id
//Klass för sökresultat (Movie klassen?) -Klart
//huvudmeny - sök film, avsluta prog -Klart
//readme fil

//VG
//söka film, + titel
//till klass för sökresultat
//huvumeny, ett till val söka efter titel -Klart
//dölja API nyckel
//lägga t do whiles så de nt dör
