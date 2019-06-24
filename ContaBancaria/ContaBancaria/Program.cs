using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            

            Console.Write("Haverá depósito inical? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if ((resp == 's') || (resp == 'S')) {
                Console.Write("Entre o valor do depósito inicial: ");
                Conta c = new Conta(numero, titular, double.Parse(Console.ReadLine()));;
            } else
            {
                Conta c = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            c.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            c.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine(c);

        }
    }
}