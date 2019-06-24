using Inheritance.Entities;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            System.Console.WriteLine(account.Balance);

            //account.Balance = 200.00 //doesnt work, becausa de the variable wasnt protetected
        }
    }
}
