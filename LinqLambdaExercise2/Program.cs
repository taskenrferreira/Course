using System;
using LinqLambdaExercise2.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace LinqLambdaExercise2 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\temp\linq2.csv";
            
            List<Product> Products = new List<Product>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    Products.Add(new Product(sr.ReadLine()));
                }
            }
            
            double avg = Products.Select(p => p.Price).Average();
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = Products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string name in names) {
                Console.WriteLine(name);
            }            
        }
    }
}
