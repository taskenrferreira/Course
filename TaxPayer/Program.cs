using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayers.Entities;

namespace TaxPayers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    

                    list.Add(new Individual(healthExpenditure, name, annualIncome));
                }
                else
                {                
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(employees, name, annualIncome));
                }

                Console.WriteLine("");
            }

            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;

            foreach (TaxPayer tp in list)
            {
                sum += tp.TaxesPaid();
                Console.WriteLine($"{tp.Name}: $ {tp.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
