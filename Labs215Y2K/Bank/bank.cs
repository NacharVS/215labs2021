using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Account:IAccaunt
    {
        public delegate void NameValueChangeDelagate(string name, string Oldname);
        public event NameValueChangeDelagate NameChangeEvent;


        private string _name ;
        private double _balance;
        private int _id;

        public static double rate = 0.09;

        public string Name 
        { get => _name;
            set 
            {
                string Oldname = _name;
                _name = value;
                NameChangeEvent?.Invoke(_name,Oldname);
            }
        }
        public double Balance { get => _balance; set => _balance = value; }
        public int Id { get => _id; set => _id = value; }

        public Account(string name, double balance, int id)
        {
            this.Name = name;
            this.Balance = balance;
            this.Id = id;
        }

        public void ShowInfo(Account acc)
        {
            if (acc.Balance > 0)
            {
                Console.WriteLine($"Пользователь - {Name} \t Баланс - {Balance}   \t _id - {Id}");
            }
        }

        public  void ShowProfit(Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.Balance += acc.Balance * rate;
            }
        }

        public void Deposit(Account acc)
        {
            Console.WriteLine();
            Console.WriteLine($"{acc.Name} - {acc.Balance}");
            Console.WriteLine("Укажите сумму, которую вы хотите внести");
            double DepositMoney = double.Parse(Console.ReadLine());
            acc.Balance = acc.Balance + DepositMoney;
        }

        public void Withdraw(Account acc)
        {
            Console.WriteLine();
            Console.WriteLine($"{acc.Name} - {acc.Balance}");
            Console.WriteLine("Укажите сумму, которую вы хотите вывести");
            double WithdrawMoney = double.Parse(Console.ReadLine());
            acc.Balance = acc.Balance - WithdrawMoney;
            if (acc.Balance < 0)
            {
                Console.WriteLine("На балансе недостаточно средств");

            }
        }

        public  void Transaction(Account acc, Account accGetter)
        {
            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя от которого вы хотите перевести");
            int AccGetterSeller = int.Parse(Console.ReadLine());

            if (AccGetterSeller == acc.Id)
            {
                Console.WriteLine($"Укажите сумму, которую вы хотите перевести");
                double TransactionMoney = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите Id пользователя которому вы хотите перевести");
                int AccGetterId = int.Parse(Console.ReadLine());
                if (AccGetterId == accGetter.Id)
                {
                   
                    acc.Balance -= TransactionMoney;
                    Console.WriteLine($"{acc.Name} - {acc.Balance}");
                    accGetter.Balance += TransactionMoney;
                }
            }
        }
       
    }
}
