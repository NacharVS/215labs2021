using Labs215Y2K.Bank;
using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Account acc1 = new Account("Ivan", 5000);
            acc1.BalanceChangeEvent += Show;
            acc1.Balance = 3000;

        }

        static void Show(double a, double b)
        {
            Console.WriteLine($"balancr changed with {a}, new balance ={b}");
        }
    }
}
