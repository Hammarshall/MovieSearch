using System;
using static System.Console;

namespace MovieSearch
{
    public class Startmenu //klassen
    {
        public static void Menu() //metod
        {
            int option = 0; //börja med värde 0

            bool isInvalidInput = false;
            do
            {
                Console.WriteLine(@"Main menu
1. Search movie by using id: 
2. Search movie by using title:
3. Exit program. ");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    isInvalidInput = false;
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again...");
                    isInvalidInput = true; // true pga skrev bokstav, det ska vara siffror.
                }
            } while (isInvalidInput); // kör sålänge den är false

            switch (option)
            {
                case 1:
                    SearchByMovieId.SearchById().Wait();// metoden
                    break;
                case 2:
                    SearchByTitle.SearchTitle().Wait();
                    //lägg till metoden här
                    break;
                case 3:
                    ExitMovie.ExitProgram(); //metod för exit
                    break;
                default:
                    Console.WriteLine("Invalid input, try again!");
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey(true);
                    Console.Clear();
                    Startmenu.Menu();
                    break;
            }
        }

        public void Start() //metod för att starta metoden Menu
        {
            Menu();
        }
    }
}
