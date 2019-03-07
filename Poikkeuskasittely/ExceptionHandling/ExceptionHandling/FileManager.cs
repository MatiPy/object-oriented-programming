using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }

        public WordListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    class FileManager
    {
        public string filePath;

        public FileManager()
        {
        }

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadWords()
        {
            string content = string.Empty;

            try
            {
                content = ReadFile();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e.Message}");
            }

            return content;
        }

        private string ReadFile()
        {
            if (File.Exists(filePath))
            {

                List<Movie> movielList = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(this.filePath));


                foreach (Movie movie in movielList)
                {
                    Console.WriteLine($"Name: {movie.Name}\n Year: {movie.Year}");
                }
            }

            else if  (!File.Exists(filePath))
                {
                    throw new WordListNotFoundException("file not available");
                }


            
                string directoryName = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string fileExtension = Path.GetExtension(filePath);

                Console.WriteLine("directoryName: " + directoryName);
                Console.WriteLine("fileName: " + fileName);
                Console.WriteLine("fileExtension: " + fileExtension);

                string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
                return fileContent;
            



        }
    }
}
        
