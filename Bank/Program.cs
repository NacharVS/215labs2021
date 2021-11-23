using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justforfun
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Ivan", 5000, "1");
            Account acc2 = new Account("Fedor", 6000, "2");
            Account acc3 = new Account("Elena", 3000, "3");

            Console.WriteLine("Введите Ваш ID.");
            string chose = Console.ReadLine();
            Console.WriteLine("Введите ID пользователя, которому Вы хотите перевести деньги.");
            string chose2 = Console.ReadLine();

            if (chose == "1")
            {
                switch (chose)
                {
                    case "1":
                        Console.WriteLine("Невозможно отправить деньги самому себе.");
                        break;
                    case "2":
                        Account.Transaction(acc1, acc2);
                        break;
                    case "3":
                        Account.Transaction(acc1, acc3);
                        break;
                }
            }

            if (chose == "2")
            {
                switch (chose)
                {
                    case "1":
                        Account.Transaction(acc2, acc1);
                        
                        break;
                    case "2":
                        Console.WriteLine("Невозможно отправить деньги самому себе.");
                        break;
                    case "3":
                        Account.Transaction(acc2, acc3);
                        break;
                }
            }

            if (chose == "3")
            {
                switch (chose)
                {
                    case "1":
                        Account.Transaction(acc3, acc1);
                        break;
                    case "2":
                        Account.Transaction(acc3, acc2);
                        break;
                    case "3":
                        Console.WriteLine("Невозможно отправить деньги самому себе.");
                        break;
                }
            }




            acc1.ShowInfo();
            acc3.ShowInfo();
            Console.ReadKey();
        }
    }
}
