using System;

namespace BanK_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info.start();
            //IClientOperations acc1 = new Info("Manunya", 300, 1, 5);
            Info.usingquestion();
            IEmployeOperations acc1 = new Info(Console.ReadLine(), 2000, 100, 195234);
            IEmployeOperations acc2 = new Info(Console.ReadLine(), 10000, 300, 300592);
            IEmployeOperations acc3 = new Info(Console.ReadLine(), 15000, 750, 666777);
            acc1.NameChange(acc1)
        }
    }
}
