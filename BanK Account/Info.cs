using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class Info
    {

        public static AccountMethods acc1 = new AccountMethods("Альфред", 2000,195234);
        public static AccountMethods acc2 = new AccountMethods("Илья", 10000,300592);
        public static AccountMethods acc3 = new AccountMethods("Александр", 15000,666777);

        public static void start()
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть список клиентов");
            Console.WriteLine("2 - Просмотреть начисление по депозиту");
            Console.WriteLine("3 - Сделать пополнение на счёт клиента");
            Console.WriteLine("4 - Вывести со счёта клиента");
            Console.WriteLine("5 - Сделать транзакцию");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Info.list();
                    Info.start();
                    break;
                case 2:
                    Info.procents();
                    break;
                case 3:
                    Info.deposit();
                    break;
                case 4:
                    Info.withdraw();
                    break;
                case 5:
                    Info.Trans();
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }
        public static void list()
        {
            Console.WriteLine();
            acc1.ShowInfo();
            acc2.ShowInfo();
            acc3.ShowInfo();
      
        }
        public static void procents()
        {
            Info.list();
            Console.WriteLine("Всего 3 клиента. Введите id, чтобы просмотреть информацию");
            int answer2 = int.Parse(Console.ReadLine());
            switch (answer2)
            {
                case 195234:
                    Console.WriteLine();
                    Console.WriteLine("Введите кол-во месяцев для начисления %");
                    int monthammount1 = int.Parse(Console.ReadLine());
                    acc1.ShowProfit(acc1, monthammount1);
                    acc1.ShowInfo();
                    Info.start();
                    break;
                case 300592:
                    Console.WriteLine();
                    Console.WriteLine("Введите кол-во месяцев для начисления %");
                    int monthammount2 = int.Parse(Console.ReadLine());
                    acc2.ShowProfit(acc2, monthammount2);
                    acc2.ShowInfo();
                    Info.start();
                    break;
                case 666777:
                    Console.WriteLine();
                    Console.WriteLine("Введите кол-во месяцев для начисления %");
                    int monthammount3 = int.Parse(Console.ReadLine());
                    acc3.ShowProfit(acc3, monthammount3);
                    acc3.ShowInfo();
                    Info.start();
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }
        public static void deposit()
        {
            Info.list();
            Console.Write("Введите id клиента которому желаете пополнить балик (3 номера): ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 195234:
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    int depo = int.Parse(Console.ReadLine());
                    acc1.Deposit(acc1, depo);
                    Console.WriteLine($"{acc1.name} - начислено {depo}");
                    acc1.ShowInfo();
                    Info.start();
                    break;
                case 300592:
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    int depo1 = int.Parse(Console.ReadLine());
                    acc2.Deposit(acc2, depo1);
                    Console.WriteLine($"{acc2.name} - начислено {depo1}");
                    acc2.ShowInfo();
                    Info.start();
                    break;
                case 666777:
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    int depo3 = int.Parse(Console.ReadLine());
                    acc3.Deposit(acc3, depo3);
                    Console.WriteLine($"{acc3.name} - начислено {depo3}");
                    acc3.ShowInfo();
                    Info.start();
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }
        public static void withdraw()
        {
            Info.list();
            Console.Write("Введите id клиента которому желаете вывести балик : ");
            int number4 = int.Parse(Console.ReadLine());
            switch (number4)
            {
                case 195234:
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму которую хотите вывести");
                    int withd = int.Parse(Console.ReadLine());
                    acc1.Withdraw(acc1, withd);
                    Console.WriteLine($"{acc1.name} - успешно выведено {withd}");
                    acc1.ShowInfo();
                    Info.start();
                    break;
                case 300592:
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму которую хотите вывести");
                    int withd2 = int.Parse(Console.ReadLine());
                    acc2.Withdraw(acc2, withd2);
                    Console.WriteLine($"{acc2.name} - успешно выведено {withd2}");
                    acc2.ShowInfo();
                    Info.start();
                    break;
                case 666777:
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму которую хотите вывести");
                    int withd3 = int.Parse(Console.ReadLine());
                    acc3.Withdraw(acc3, withd3);
                    Console.WriteLine($"{acc3.name} - успешно выведено {withd3}");
                    acc3.ShowInfo();
                    Info.start();
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }
        public static void Trans()
        {
            Info.list();
            Console.Write("Введите id клиента от которого желаете сделать транзакцию : ");
            int number5 = int.Parse(Console.ReadLine());
            switch (number5)
            {
                case 195234:
                    Console.Write("Введите id клиента которому желаете сделать транзакцию: ");
                    int answer11 = int.Parse(Console.ReadLine());
                    switch (answer11)
                    {
                        case 300592:
                            AccountMethods.Transaction(acc1, acc2);
                            Info.start();
                            break;
                        case 666777:
                            AccountMethods.Transaction(acc1, acc3);
                            Info.start();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.start();
                            break;
                    }
                    break;
                case 300592:
                    Console.Write("Введите id клиента которому желаете сделать транзакцию: ");
                    int answer12 = int.Parse(Console.ReadLine());
                    switch (answer12)
                    {
                        case 195234:
                            AccountMethods.Transaction(acc2, acc1);
                            Info.start();
                            break;
                        case 666777:
                            AccountMethods.Transaction(acc2, acc3);
                            Info.start();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.start();
                            break;
                    }
                    break;
                case 666777:
                    Console.Write("Введите id клиента которому желаете сделать транзакцию: ");
                    int answer13 = int.Parse(Console.ReadLine());
                    switch (answer13)
                    {
                        case 195234:
                            AccountMethods.Transaction(acc3, acc1);
                            Info.start();
                            break;
                        case 300592:
                            AccountMethods.Transaction(acc3, acc2);
                            Info.start();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.start();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }

    }
}

