using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Account
    {
        public string name;
        public double balance;
        public int id;

        public static double rate = 0.09;

        public Account(string name, double balance, int id)
        {
            this.name = name;
            this.balance = balance;
            this.id = id;
        }

        public void ShowInfo(Account acc)
        {
            if (acc.balance > 0)
            {
                Console.WriteLine($"Пользователь - {name} \t Баланс - {balance}   \t id - {id}");
            }
        }

        public static void ShowProfit(Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public void Deposit(Account acc)
        {
            Console.WriteLine();
            Console.WriteLine($"{acc.name} - {acc.balance}");
            Console.WriteLine("Укажите сумму, которую вы хотите внести");
            double DepositMoney = double.Parse(Console.ReadLine());
            acc.balance = acc.balance + DepositMoney;
        }

        public void Withdraw(Account acc)
        {
            Console.WriteLine();
            Console.WriteLine($"{acc.name} - {acc.balance}");
            Console.WriteLine("Укажите сумму, которую вы хотите вывести");
            double WithdrawMoney = double.Parse(Console.ReadLine());
            acc.balance = acc.balance - WithdrawMoney;
            if (acc.balance < 0)
            {
                Console.WriteLine("На балансе недостаточно средств");

            }
        }

        public static void Transaction(Account acc, Account accSeller, Account accGetter)
        {
            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя от которого вы хотите перевести");
            int AccGetterSeller = int.Parse(Console.ReadLine());

            if (AccGetterSeller == acc.id)
            {
                Console.WriteLine($"Укажите сумму, которую вы хотите перевести");
                double TransactionMoney = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите Id пользователя которому вы хотите перевести");
                int AccGetterId = int.Parse(Console.ReadLine());
                if (AccGetterId == acc.id)
                {
                    Console.WriteLine($"{acc.name} - {acc.balance}");
                    accSeller.balance -= TransactionMoney;
                    accGetter.balance += TransactionMoney;
                }
            }
        }
       
    }
}
