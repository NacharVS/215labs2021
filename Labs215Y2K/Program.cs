using Labs215Y2K.Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("Ivan", 3000));
            accounts.Add(new Account("Ruslan", 3000));
            accounts.Add(new Account("Denis", 3000));
            //string name = Console.ReadLine();
            accounts.Add(new Account("Ravil", 2000));
            Account testacc = new Account("Ivan", 3000);
            Console.WriteLine(accounts.Contains(testacc));
            

        }

        static void Show(double a, double b)
        {
            Console.WriteLine($"balancr changed with {a}, new balance ={b}");
        }
    }
}
