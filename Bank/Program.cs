using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Ivan", 5000);
            Account acc2 = new Account("Fedor", 6000);
            Account acc3 = new Account("Elena", 3000);

            Account.Transaction(acc1, acc3);
            acc1.ShowInfo();
            acc3.ShowInfo();
        }
    }
}
