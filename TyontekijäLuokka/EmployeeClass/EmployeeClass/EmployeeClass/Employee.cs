using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClass
{
    class Employee
    {
        public string name;
        public int id;
        public string position;
        public int salary;
        private static int counter = 0;

        public Employee()
        {
            this.name = System.String.Empty; this.id = counter++;
        }
        public Employee(string name, int id, string position, int salary)
        {
            this.name = name;
            this.id = counter++;
            this.position = position;
            this.salary = salary;
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Työntekijän nimi: {this.name}" +
                $" ID: {this.id}  Tehtava:  {this.position} Palkka: {this.salary}");
            Console.WriteLine("-----------------------------------\n");
        }
        public override string ToString()
        {
            return this.id + " : " + this.name;

        }
        public void CompareSalary(Employee employee)
        {
            Console.WriteLine($"Työntekijän:  {this.name}:  palkka on: " +
                $"{this.salary}: {employee.name}: palkka on: {employee.salary}");
            Console.WriteLine("----------------------------------");

            if (this.salary > employee.salary)
            {
                Console.WriteLine($"{this.name} tienaa enemmän kuin: {employee.name}" +
                    $" {this.salary - employee.salary}");

            }
            else if (this.salary == employee.salary)
            {
                Console.WriteLine($"{this.name} ja {employee.name} " +
                    $"on sama palkka: {this.salary}.");
            }
            else
            {
                Console.WriteLine($"{employee.name} Tienaa enemmän kuin {this.name}" +
                    $" by {employee.salary - this.salary}.");
            }
            Console.WriteLine("----------------------------------");
        }
    }
}