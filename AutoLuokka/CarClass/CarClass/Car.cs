using System;
using System.Collections.Generic;
using System.Text;

namespace AutoLuokka
{
    class Car
    {
        public string brand;
        public int speed = 100;

        public Car()
        {
        }
        public Car(string brand, int speed)
        { this.brand = brand;
          this.speed = speed;
        }
        public void AskData() 
        {
            Console.Write("Syötä auton merkki:");  //kysytään käyttäjältä automerkit
            brand = Console.ReadLine();  
            Console.Write("Syötä auton huippunopeus: ");
            string speedValue = Console.ReadLine();
            int.TryParse(speedValue, out speed);
    }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Ajoneuvon {brand} nopeus {speed}");
        }
        public void Accelerate(string speedValue)  //nopeuden lisäys
         {
           if (!int.TryParse(speedValue, out int iSpeed))
           {
             iSpeed = 0;
           }
           if (iSpeed > 0)
           {
             this.speed += iSpeed;
             Console.WriteLine($"Nopeutta lisättiin {iSpeed}. uusi nopeus on" +
                 $" {this.speed} kilometriä tunnissa\n**************************************************************************** *");
           }
             else if (iSpeed == 0) 
                {
                 Console.WriteLine("Nopeus ei muuttunut");
                }      
                else         
                {
                    Console.WriteLine("Muutosta negatiiviseksi ei sallita");
                }
                }
        public void Brake() //jarrutus
        {
            speed = 90 * speed / 100;
            Console.WriteLine($"\n JARRUTETAAN!!!.....\nnopeus hidastettiin {speed} kilometriin tunnissa");  
        }
    }
} 
