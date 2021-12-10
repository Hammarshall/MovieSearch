﻿using System;
using static System.Console;//Behöver ej skriva Console. framför

namespace MovieSearch
{
    public class Startmenu//Klassen
    {
        public static void Menu()//Metod
        {
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
