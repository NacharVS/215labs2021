using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.Bank
{
    class Account
    {
        public string name;
        public double balance;

        public static double rate = 0.09;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowInfo(Account acc)
        {
            if (acc.balance > 0)
            {
                System.Console.WriteLine($"{name} - {balance}");
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
            double DepositMoney =  double.Parse(Console.ReadLine());
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

        public void Transaction(Account acc,Account accSeller, Account accGetter)
        {
            Console.WriteLine();
            Console.WriteLine($"{acc.name} - {acc.balance}");
            Console.WriteLine($"Укажите сумму, которую вы хотите перевести");
            double TransactionMoney = double.Parse(Console.ReadLine());
            accSeller.balance -= TransactionMoney;
            accGetter.balance += TransactionMoney;
        }
    }
}
