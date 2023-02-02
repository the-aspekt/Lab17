using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<string> account1 = new BankAccount<string>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());
            BankAccount<int> account2 = new BankAccount<int>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());
            account2.AddBalance();
            Console.WriteLine(account2.GetInfo());

            Console.ReadLine();
        }
    }
}
