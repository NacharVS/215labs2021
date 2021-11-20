using System;

namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Ivan", 5000);
            Account acc2 = new Account("Fedor", 6000);
            Account acc3 = new Account("Elena", 3000);
            acc1.ShowInfo();
            acc2.ShowInfo();
            acc3.ShowInfo();
            Console.WriteLine();
            Account.rate = 0.09;
            Account.ShowProfit(acc1, 1);
            Account.ShowProfit(acc3, 1);
            Account.ShowProfit(acc3, 1);
            acc1.ShowInfo();
            acc2.ShowInfo();
            acc3.ShowInfo();
        }
    }
}
