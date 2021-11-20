using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods
    {
        public string name;
        public double balance;
        public static double rate = 0.09;

        public AccountMethods(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {balance}");
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
            acc.balance -= withd;
        }

        public static void Transaction(AccountMethods accSeller, AccountMethods accGetter)
        {

        }
    }
}
