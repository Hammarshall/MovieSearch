using System;
using static System.Console; // behöver ej skriva Console. framför

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
                WriteLine(@"Main menu
1. Search movie by using id: 
2. Search movie by using title:
3. Exit program. ");
                try
                {
                    option = int.Parse(ReadLine());
                    isInvalidInput = false;
                    break;
                }
                catch
                {
                    WriteLine("Invalid input, try again...");
                    isInvalidInput = true; // true pga skrev bokstav, det ska vara siffror.
                }
            } while (isInvalidInput); // kör sålänge den är false

            switch (option)
            {
                case 1:
                    SearchByMovieId.SearchById().Wait();// metoden + wait
                    break;
                case 2:
                    SearchByTitle.SearchTitle().Wait(); //metoden + wait
                    break;
                case 3:
                    ExitMovie.ExitProgram(); //metoden för exit
                    break;
                default:
                    WriteLine("Invalid input, try again!");
                    WriteLine("\nPress any key to return to menu");
                    ReadKey();
                    Clear();
                    Menu();
                    break;
            }
        }

        public void Start() //metod för att starta metoden Menu
        {
            Menu();
        }
    }
}
