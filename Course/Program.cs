using EnumsExample.Entities;
using EnumsExample.Entities.Enums;
using System;

namespace EnumsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);
        }
    }
}
