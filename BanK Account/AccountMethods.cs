using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods
    {
        public string name;
        public double balance;
        public int id;
        public static double rate = 0.09;

        public AccountMethods(string name, double balance, int id)
        {
            this.name = name;
            this.balance = balance;
            this.id = id;
  
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"id: {id} {name} - {balance}");
        }

        public void ShowProfit(AccountMethods acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public void Deposit(AccountMethods acc, int depo)
        {
            acc.balance += depo;
        }

        public void Withdraw(AccountMethods acc, int withd)
        {
            if (acc.balance <= 0)
            {
                Console.WriteLine($"{acc.name} не имеет денег на счету для вывода");
            }
            else
            {
                acc.balance -= withd;
            }
        }

        public static void Transaction(AccountMethods accSeller, AccountMethods accGetter)
        {
            if (accSeller.balance <= 0)
            {
                Console.WriteLine($"У {accSeller.name} нет денег на счёту для транзакции!");
            }
            else
            {
                Console.Write("Введите сумму для транзакции: ");
                double transsum = double.Parse(Console.ReadLine());
                accSeller.balance -= transsum;
                accGetter.balance += transsum;
                Console.WriteLine($"{accGetter.name} успешно получил {transsum}");
            }
        }
    }
}
