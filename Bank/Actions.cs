using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Actions
    {
        public static void ShowInfo(Account acc)
        {
            System.Console.WriteLine($"{acc.Name} возраст: {acc.Age}  [{acc.Id} ID] - {acc.Balance} рублей");
        }

        public static void ShowProfit(Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.Balance += acc.Balance * Account.rate;
            }
            Console.WriteLine($"Ваш баланс будет составлять: {acc.Balance}.");
        }
        public static void Deposit(Account account)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите внести");
            double cash = double.Parse(Console.ReadLine());
            if (cash >= 0)
            {
                account.Balance += cash;
                Console.WriteLine($"Поздравляем. {cash} рублей было зачислено на Ваш счёт.");
            }
            else
                Console.WriteLine("Введите корректную сумму.");
        }

        public static void Withdraw(Account account)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите снять");
            double cash = double.Parse(Console.ReadLine());
            if (cash >= 0 & account.Balance>=cash)
            account.Balance -= cash;
            Console.WriteLine($"{cash} рублей было снято со счёта.");
        }

        public static void Transaction(Account accSeller, Account accGetter)
        {
          
            

            Console.WriteLine($"Введите сумму, которую хотите перевести {accGetter.Name}");
            double money = double.Parse(Console.ReadLine());
            if (accSeller.Balance >= money)
            {
                accSeller.Balance -= money;
                accGetter.Balance += money;
                Console.WriteLine($"Со счёта {accSeller.Name} было переведено {accGetter.Name} {money} рублей");
            }
            else
            Console.WriteLine("Ошибка. На Вашем счету недостаточно средств.");
        }
    }
}
