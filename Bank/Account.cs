using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
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

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {balance}");
        }

        public static void ShowProfit(Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public void Deposit(ref double money)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите внести");
            double cash = double.Parse(Console.ReadLine());
            money += cash;
            Console.WriteLine($"Поздравляем. {cash} рублей было зачислено на Ваш счёт.");
        }

        public void Withdraw(ref double money)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите снять");
            double cash = double.Parse(Console.ReadLine());
            money += cash;
            Console.WriteLine($"{cash} рублей было снято со счёта.");
        }

        public static void Transaction(Account accSeller, Account accGetter)
        {
            Console.WriteLine($"Введите сумму, которую хотите перевести {accGetter.name}");
            double money = double.Parse(Console.ReadLine());
            accSeller.balance -= money;
            accGetter.balance += money;
            Console.WriteLine($"Со счёта {accSeller.name} было переведено {accGetter.name} {money} рублей");
        }
    }
}
