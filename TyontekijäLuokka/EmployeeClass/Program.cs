using System;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------työntekijäluokka-----------------------------");
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Mikko Rantanen", 0, "varastomies", 5000);
            employees[1] = new Employee("Hannu Taipale", 1, "koordinaattori", 3000);
            employees[2] = new Employee("Kirsi Kekola", 2, "sihteeri", 2500);
            Console.WriteLine("---------------------------------------------------------------------------");

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployee();
            }
            employees[0].CompareSalary(employees[1]);
            employees[0].CompareSalary(employees[2]);
            employees[1].CompareSalary(employees[2]);
        }
    }
}
