using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace HarjoitusTyo2
{
    class FileManager
    {
        private readonly string filePath;
        //Määritetään movies.json tiedoston sijainti
        public FileManager()  
        {
            this.filePath = @"C:\dev-saimia\object-oriented-programming\Tuoterekisteri2\TuoteRekisteri2\TuoteRekisteri2\movies.json";          
        }

        public string ListOfMovies()
        {
            string movies = string.Empty;
            try
            {
                movies = ReadFile();
                return movies;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<Movies> movieList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));

                foreach (Movies movie in movieList)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                      $"Julkaisuvuosi: {movie.year}\n" +
                                      $"Genre: {movie.genre}");
                }

                Console.WriteLine();
                Console.WriteLine("Haluatko tulostaa tietyn elokuvan? Paina [K] = 'Kyllä'  [E] = 'Ei'");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "K")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tulostetaan Julkaisuvuosi: ");

                    foreach (Movies movie in movieList)
                    {                      
                        Console.WriteLine($"Elokuvan nimi: {movie.title}," +
                                          $" Julkaisuvuosi: {movie.year} " +
                                          $"Genre: {movie.genre}");
                    }

                    //haetaan elokuvat nimen mukaan
                    Console.WriteLine();
                    Console.WriteLine("Syötä elokuvan nimi: ");
                    string userInputTitle = Console.ReadLine();
                    bool match = false;

                    foreach (Movies movie in movieList)
                    {
                        if (userInputTitle == movie.title)
                        {
                            match = true;
                            Console.WriteLine($"Nimi: {movie.title}\n" +
                                              $"Tuotenumero: {movie.year}\n" +
                                              $"Ryhmä: {movie.genre}");
                        }
                    }
                    if (match!= true)
                    {
                        Console.WriteLine("Syötit väärän elokuvan!");
                    }
                }
                else
                {
                    Console.WriteLine("Haulla ei löytynyt elokuvia!");
                }
            }

            else if (!File.Exists(filePath))
            {
                throw new Exception("Virhe: Tiedostoa ei löytynyt!");
            }
            return "";
        }

        //tulostetaan elokuvat julkaisuvuoden mukaan
        public string PrintByYear(string year)
        {
            List<Movies> moviesList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));

            foreach (Movies movie  in moviesList)
            {
                if (movie.year == year)
                {
                    Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                      $"Julkaisuvuosi: {movie.year}\n" +
                                      $"Genre: {movie.genre}\n");
                }  
            }
            return "";
        }

        //tulostetaan elokuvat genreittäin
        public string PrintByGenre(string menu)
        {
            List<Movies> movieList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));

            foreach (Movies movie in movieList)
            {
                if (menu == "1")
                {
                    if (movie.genre == "Action")
                    {
                        Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                          $"Julkaisuvuosi: {movie.year}\n" +
                                          $"Genre: {movie.genre}\n");
                    }
                }
                else if (menu == "2")
                {
                    if (movie.genre == "Comedy")
                    {
                        Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                          $"Julkaisuvuosi: {movie.year}\n" +
                                          $"Genre: {movie.genre}\n");
                    }
                }
                else if (menu == "3")
                {
                    if (movie.genre == "Drama")
                    {
                        Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                          $"Julkaisuvuosi: {movie.year}\n" +
                                          $"Genre: {movie.genre}\n");
                    }
                }
                else if (menu == "4")
                {
                    if (movie.genre == "Adventure")
                    {
                        Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                          $"Julkaisuvuosi: {movie.year}\n" +
                                          $"Genre: {movie.genre}\n");
                    }
                }
                else if (menu == "5")
                {
                    if (movie.genre == "Science Fiction")
                    {
                        Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                          $"Julkaisuvuosi: {movie.year}\n" +
                                          $"Genre: {movie.genre}\n");
                       
                    }
                    else if (menu == "6")
                    {
                        if (movie.genre == "Thriller")
                        {
                            Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                              $"Julkaisuvuosi: {movie.year}\n" +
                                              $"Genre: {movie.genre}\n");
                        }
                    }
                    else if (menu == "7")
                    {
                        if (movie.genre == "Western")
                        {
                            Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                              $"Julkaisuvuosi: {movie.year}\n" +
                                              $"Genre: {movie.genre}\n");
                        }
                    }
                    else if (menu == "8")
                    {
                        if (movie.genre == "Romance")
                        {
                            Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                              $"Julkaisuvuosi: {movie.year}\n" +
                                              $"Genre: {movie.genre}\n");
                        }
                    }
                    else if (menu == "9")
                    {
                        if (movie.genre == "Satire")
                        {
                            Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                              $"Julkaisuvuosi: {movie.year}\n" +
                                              $"Genre: {movie.genre}\n");
                        }
                    }
                    else if (menu == "10")
                    {
                        if (movie.genre == "Biography")
                        {
                            Console.WriteLine($"Elokuvan nimi: {movie.title}\n" +
                                              $"Julkaisuvuosi: {movie.year}\n" +
                                              $"Genre: {movie.genre}\n");
                        }
                    }
                    else
                    {
                     return "";
                    }
                   
                }                
            }
            return "";                   
        }
    }
}


