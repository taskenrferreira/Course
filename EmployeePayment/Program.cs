using System;
using System.Collections.Generic;
using System.Globalization;
using EmployeePayment.Entities;

namespace EmployeePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hour: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
                
                if (outsourced == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge));
                } else
                {
                    list.Add(new Employee(name, hour, valuePerHour));
                }

                Console.WriteLine("");
            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee e in list)
            {
                Console.WriteLine($"{e.Name} - $ {e.Payment().ToString("F2", CultureInfo.InvariantCulture)}");                
            }

            //Console.WriteLine(employee);
        }
    }
}
