using Course01.Entities;
using Course01.Entities.Enums;
using System;
using System.Globalization;

namespace Course01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            WorkerLevel level;
            double baseSalary;
            int count;

            DateTime date;
            double valuePerHour;
            int hours;

            string monthYear;

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base salary");
            baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Worker worker = new Worker{name, level, baseSalary);

            Console.Write("How many contracts to this worker?");
            count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Hours");
                hours = int.Parse(Console.ReadLine());
                Console.WriteLine();

                HourContract hourContract = new HourContract(date,valuePerHour,hours);

                Worker.AddContract(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            monthYear = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(worker);

        }
    }
}
