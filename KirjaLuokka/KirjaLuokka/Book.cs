using System;
using System.Collections.Generic;
using System.Text;

namespace KirjaLuokka
{
   class Book
   {
        public string title;
        public string author;
        public string id;
        public double price;

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Kirja: {this.title}\n" +  $"kirjoittaja{this.author}\n" +
                $"id: {this.id}\n" + $"Hinta: {this.price.ToString()}\n)");
        }
        public string CompareBooks(Book book)
        {
          Console.WriteLine($"Kirja: {book.title} hinta: {this.price.ToString()}\n");

            if (this.price > book.price)
            {
                Console.WriteLine("*********************************************************\n");
                return $"{book.title} kirja on kalliimpi kuin {this.title} kirja\n";
            }
            else
            {
                Console.WriteLine("*********************************************************\n");
                return $"{this.title} kirja on kalliimpi kuin {book.title} kirja.\n*********************************************************";
       
            }
        }
    }
}






