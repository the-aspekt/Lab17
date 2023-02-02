using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class BankAccount<T>
    {
        public T Account { get; set; }
        public double Balance { get; set; }
        public string ClientName { get; set; }

        //public BankAccount(T account, double balance, string clientName)
        //{
        //    Account = account;
        //    Balance = balance;
        //    ClientName = clientName;
        //}

        public string GetInfo()
        { return $"{ClientName} имеет счет № {Account} с балансом {Balance}"; }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Account = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО клиента");
            ClientName = Console.ReadLine();
            Console.WriteLine("Введите баланс клиента");
            Balance = Convert.ToDouble(Console.ReadLine());

        }
        public void InputBalance()
        {
            Console.WriteLine("Введите баланс клиента");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void AddBalance()
        {
            Console.WriteLine("Введите изменение баланса клиента");
            Balance += Convert.ToDouble(Console.ReadLine());
        }

    }


}
