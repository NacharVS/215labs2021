using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justforfun
{
    class Account
    {
        public string name;
        public double balance;
        public string id;

        public static double rate = 0.09;

        public Account(string name, double balance, string id)
        {
            this.name = name;
            this.balance = balance;
            this.id = id;
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
            if (money > 0)
            {
                money += cash;
                Console.WriteLine($"Поздравляем. {cash} рублей было зачислено на Ваш счёт.");
            }
            else
                Console.WriteLine("Жулик, не воруй!");
        }

        public void Withdraw(ref double money)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите снять");
            double cash = double.Parse(Console.ReadLine());
            if (money > 0)
            {
                money += cash;
                Console.WriteLine($"{cash} рублей было снято со счёта.");
            }
            else
                Console.WriteLine("Жулик, не воруй!");
        }

        public static void Transaction(Account accSeller, Account accGetter)
        {
            Console.WriteLine($"Введите сумму, которую хотите перевести {accGetter.name}");
            double money = double.Parse(Console.ReadLine());
            if (money > 0)
            {
                if (money <= accSeller.balance)
                {
                    accSeller.balance -= money;
                    accGetter.balance += money;
                    Console.WriteLine($"Со счёта {accSeller.name} было переведено {accGetter.name} {money} рублей");
                }
                else
                    Console.WriteLine("На вашем счету недостаточно средств.");
            }
            else
                Console.WriteLine("Жулик, не воруй!");
        }
    }
}
