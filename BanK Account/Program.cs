using System;
using BanK_Account;

namespace BanK_Account
{
    class Program
    {

        static void Main(string[] args)
        {
            AccountMethods acc1 = new Info("Альфред", 2000, 100, 195234, 0, 0);
            AccountMethods acc2 = new Info("Илья", 10000, 300, 300592, 0, 0);
            AccountMethods acc3 = new Info("Александр", 15000, 750, 666777, 0, 0);
            IEmployeOperations ac1 = acc1;
            IEmployeOperations ac2 = acc2;
            IEmployeOperations ac3 = acc3;
            Info.usingquestion(ac1,ac2,ac3,acc1,acc2,acc3);
            

        }
        static void ShowName(AccountMethods acc, string old)
        {
            Console.WriteLine($"Успешно! Id: {acc.Id} Старое имя: {old} Текущее имя: {acc.Name}");
        }
    }
}