using System;
using KirjaLuokka;

namespace KirjaLuokka
{
    class Program
    {
        
        static void Main(string[] args)
        {
         
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*Kirjat ja hinnat*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            Book book1 = new Book("Jere", "Aki Linnanahde", "0001", 27.50);          
            Book book2 = new Book("C# Ohjelmointi", "Ghodrat moghadampour", "0003", 22.50);

            book1.CompareBooks(book2);
            Console.WriteLine(book2.CompareBooks(book1));
        }
    }


}
