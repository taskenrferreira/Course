using System;
using System.Collections.Generic;
using VirtualOverride.Entities;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            //classe abtract pode ser listado, mas nao instanciada

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1001, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1001, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1001, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            System.Console.WriteLine("Total balance: " + sum.ToString());

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString());
            }
        }
    }
}

