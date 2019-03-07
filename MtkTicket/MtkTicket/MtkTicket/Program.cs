using System;

namespace MtkTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Pohjustetaan tiedot maatalousnäyttelyn oikean lipun valintaan-------------------");
            Console.Write("-------------------------------Kerro lippumaatille nimesi---------------------------------------\n");
            var name = Console.ReadLine();
            var customer = new Customer(name);
            int age = -1;

            while (age < 0)
            {
                Console.Write("Syötä ikäsi: ");
                if 
                    (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Väärä syöte!");
                    age = -1;
                }
                else
                {
                    customer.Age = age;
                }
            }
            Console.WriteLine("\nOhjelma Kysyy sinulta seuraavaksi tietoja lipun ostoa varten....\n"
                + "             Paina jotakin jatkaaksesi\n****************************************************************\n");
            Console.ReadKey();

            customer.Student = YesNo
                ("\nKerro oletko Opiskelija?\n");
            customer.MtkMbr = YesNo
                ("\nKerro oletko MTK:n jäsen?\n");
            //kysytään käyttäjältä tiedot  
            customer.MilPerson = YesNo("\nKerro oletko Varusmies?\n"); 
            
            Console.WriteLine($"\n**************Sinun Lippusi hinta {name} on****************\n {customer.SearchForPrice()} Euroa");
            Console.ReadKey();
        }
        private static bool YesNo(string ask)
        {
            while (true)
            {
                Console.Write("\n{0}Näppäin[K]=Kyllä -- [E]=Ei:", ask);
                char c = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                
                if (c == 'K')
                {
                    return true;
                }
                if (c == 'E')
                {
                    return false;
                }
                Console.WriteLine("Vastaa seuraavasti [K=Kyllä] [E=Ei]");
            }
        }
    }
}