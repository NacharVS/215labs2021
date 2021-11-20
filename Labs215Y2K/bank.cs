using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class bank
    {
        public string name;
        public double balance;

        public static double rate = 0.09;

        public void Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {balance}");
        }

        public static void ShowProfit( Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public void Deposit(double money)
        {

        }

        public void Withdraw(double money)
        {

        }

        public static void Transaction(Account accSeller, Account accGetter)
        {

        }
    }
}
