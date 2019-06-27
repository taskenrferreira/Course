using System;
using System.IO;
using System.Globalization;
using SourceSummary.Entities;

namespace SourceSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\source.csv";
            string targetDirectory = @"C:\temp\out\";
            string targetPath = @"C:\temp\out\summary.csv";            

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                //if (!File.Exists(targetPath))
                //{
                //    File.Create(targetPath);
                //}                

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] arr = line.Split(',');

                        string product = arr[0];
                        double price = double.Parse(arr[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(arr[2]);

                        Product prod = new Product(product, price, quantity);
                        sw.WriteLine(product + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
