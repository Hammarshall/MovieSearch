using System;
using static System.Console;//Behöver ej skriva Console. framför

namespace MovieSearch
{
    public class Startmenu//Klassen
    {
        public static void Menu()//Metod
        {

            string text = @"
   _____                 .__            _________                               .__                    
  /     \    ____ ___  __|__|  ____    /   _____/  ____  _____  _______   ____  |  |__    ____ _______ 
 /  \ /  \  /  _ \\  \/ /|  |_/ __ \   \_____  \ _/ __ \ \__  \ \_  __ \_/ ___\ |  |  \ _/ __ \\_  __ \
/    Y    \(  <_> )\   / |  |\  ___/   /        \\  ___/  / __ \_|  | \/\  \___ |   Y  \\  ___/ |  | \/
\____|__  / \____/  \_/  |__| \___  > /_______  / \___  >(____  /|__|    \___  >|___|  / \___  >|__|   
        \/                        \/          \/      \/      \/             \/      \/      \/     
";
            WriteLine(text);
            int option = 0;//Börja med värde 0

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
                    isInvalidInput = true;//True = skrev bokstav, ska vara siffror.
                }
            } while (isInvalidInput);//Kör sålänge = false

            switch (option)
            {
                case 1:
                    SearchByMovieId.SearchById().Wait();//Metod + wait
                    break;
                case 2:
                    SearchByTitle.SearchTitle().Wait();//Metod + wait
                    break;
                case 3:
                    ExitMovie.ExitProgram();//Metod för exit
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

        public void Start()//Metod för att starta metod Menu
        {
            Menu();
        }
    }
}
