using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace HarjoitusTyo2
{
    class Program
    {
        public static string MainMenu()
        {
            //MainMenu
            Console.WriteLine("***Köyhänmiehen IMDB***\n\n Valitse haluamasi ohjelman toiminto:\n");
            Console.WriteLine("[1] = Tulosta kaikki elokuvat listana");
            Console.WriteLine("[2] = Tulosta elokuvat genreittäin");
            Console.WriteLine("[3] = Tulosta tietyt elokuvat Julkaisuvuoden mukaan");
            Console.WriteLine("[4] = Sulje Köyhänmiehen IMDB");
            string choice = Console.ReadLine();
            return choice;
        }

        static void Main(string[] args)
        {
            Movies movie = new Movies();
            FileManager fileManager = new FileManager();
            string input = null;

            do
            {
                input = MainMenu();
                switch (input.ToString())
                {
                    case "1":
                        Console.WriteLine(fileManager.ListOfMovies());
                        break;

                    case "2":                        
                        //Genremenu
                        Console.WriteLine("Valitse Genre: ");
                        Console.WriteLine("[1] = Action");
                        Console.WriteLine("[2] = Comedy");
                        Console.WriteLine("[3] = Drama");
                        Console.WriteLine("[4] = Adventure");
                        Console.WriteLine("[5] = Science Fiction");
                        Console.WriteLine("[6] = Thriller");
                        Console.WriteLine("[7] = Western");
                        Console.WriteLine("[8] = Romance");
                        Console.WriteLine("[9] = Satire");
                        Console.WriteLine("[10] = Biography");
                        string genreMenu = Console.ReadLine();
                        Console.Write(fileManager.PrintByGenre(genreMenu));
                        break;

                    case "3":
                        Console.WriteLine("Anna elokuvan julkaisu vuosi:");
                        string year = Console.ReadLine();
                        Console.WriteLine("tulostetaan elokuvat julkaisuvuosittain");                       
                        Console.WriteLine(fileManager.PrintByYear(year));                       
                        break;

                    case "4":
                        Console.WriteLine("Suljetaan ohjelma");
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Valitse vaihtoehto 1-4");                  
                        break;
                }            
                Console.ReadKey();
                Console.Clear();
            }
            while (input.ToString() != "");
        }
    }
}

