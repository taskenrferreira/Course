using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using LinqLambdaExercise.Entities;

namespace LinqLambdaExercise {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\temp\linq.csv";
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            List<Employee> Employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    Employees.Add(new Employee(sr.ReadLine()));
                }
            }

            Console.WriteLine("Email of people whose salary is more than: " + salary.ToString("F2", CultureInfo.InvariantCulture));
            var r1 = Employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
            //var r1 = 
            //    from p in Employees
            //    where p.Salary > salary
            //    orderby p.Email ascending
            //    select p.Email;

            foreach (String s in r1) { 
                Console.WriteLine(s);  
            }

            Console.WriteLine();
            var r2 = Employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum().ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + r2);
        }
    }
}
