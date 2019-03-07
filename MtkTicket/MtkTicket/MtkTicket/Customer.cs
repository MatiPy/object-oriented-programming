using System;
using System.Collections.Generic;
using System.Text;

namespace MtkTicket
{
    class Customer
    {
        private readonly string name = null;
        private bool student = false;
        private bool milPerson = false;
        private bool mtkMbr = false;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name {
            get {
                return this.name;
            }
        }
        public int Age
        {
            get; set; } = 0;

        public bool Student
        {
            get { return student; } set { student = value; }
        }
        public bool MtkMbr
        {
            get { return mtkMbr; }
            set { mtkMbr = value; }
        }
        public bool MilPerson
        { get { return milPerson; }
            set { milPerson = value; }
        }
        private const double normalPrice = 16;             //peruslippu 16e 
3  
        public double SearchForPrice()
        {
            double price = normalPrice;  

            if (Age < 7)
            {
                price = 0;
                Console.WriteLine("\n      Tervetuloa! Sinulle on ilmainen sisäänpääsy");
            }
            else if (Age  >= 65)
            {
                price *= 0.50;
                Console.WriteLine("\n        Hei Eläkeläinen saat lippusi puoleen hintaan");
            }  
            else if (mtkMbr && Student)
            {
                price *= 0.40; Console.WriteLine("\nOlet Jäsen sekä opiskelija!");
            }
            else if (Age <= 15)
            {
                price *= 0.50;
            }
            else if (MilPerson)
            {
                price *= 0.50;
            }
            else if (Student)
            {
                price *= 0.55;
            }
            else if (MtkMbr)
            {
                price *= 0.85;
                Console.WriteLine("\n  " + "                 *** Hei jäsenemme ***");
            }
            else
            {

            }
            return price;
        }
    }
}