using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account 
{
    class Info : AccountMethods
    {
        public Info(string name, double rubbalance, double usdbalance, int id)
        {
            Name = name;
            RubBalance = rubbalance;
            UsdBalance = usdbalance;
            Id = id;
        }

        private static AccountMethods acc1 = new Info("Альфред", 2000,100,195234);
        private static AccountMethods acc2 = new Info("Илья", 10000,300,300592);
        private static AccountMethods acc3 = new Info("Александр", 15000,750,666777);
        

        public static void start()
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть список клиентов");
            Console.WriteLine("2 - Просмотреть начисление по депозиту");
            Console.WriteLine("3 - Сделать пополнение на счёт клиента");
            Console.WriteLine("4 - Вывести со счёта клиента");
            Console.WriteLine("5 - Сделать транзакцию");
            Console.WriteLine("6 - Сделать конвертацию со счетов");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    acc1.AgeInput();
                    acc2.AgeInput();
                    acc3.AgeInput();
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
                case 6:
                    Info.ConvertOp();
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }
        public static void ConvertOp()
        {
            Console.WriteLine();
            acc1.ShowInfo();
            acc2.ShowInfo();
            acc3.ShowInfo();
            Console.Write("Введите id клиента: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 195234:
                    Console.WriteLine();
                    Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                    int answer1 = int.Parse(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:
                            acc1.RubConvertation(acc1);
                            Console.WriteLine();
                            acc1.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            acc1.UsdConvertation(acc1);
                            Console.WriteLine();
                            acc1.ShowInfo();
                            Info.start();
                            break;
                        default:
                            break;
                    }
                    break;
                case 300592:
                    Console.WriteLine();
                    Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            acc2.RubConvertation(acc2);
                            Console.WriteLine();
                            acc2.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            acc2.UsdConvertation(acc2);
                            Console.WriteLine();
                            acc2.ShowInfo();
                            Info.start();
                            break;
                        default:
                            break;
                    }
                    break;
                case 666777:
                    Console.WriteLine();
                    Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                    int answer3 = int.Parse(Console.ReadLine());
                    switch (answer3)
                    {
                        case 1:
                            acc3.RubConvertation(acc3);
                            Console.WriteLine();
                            acc3.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            acc3.UsdConvertation(acc3);
                            Console.WriteLine();
                            acc3.ShowInfo();
                            Info.start();
                            break;
                        default:
                            break;
                    }
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
            Console.Write("Введите id клиента которому желаете пополнить баланс: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 195234:
                    int depo1 = 0;
                    acc1.Deposit(acc1,depo1);
                    acc1.ShowInfo();
                    Info.start();
                    break;
                case 300592:
                    int depo2 = 0;
                    acc2.Deposit(acc2, depo2);
                    acc2.ShowInfo();
                    Info.start();
                    break;
                case 666777:
                    int depo3 = 0;
                    acc3.Deposit(acc3, depo3);
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
            Console.Write("Введите id клиента которому желаете вывести баланс: ");
            int number4 = int.Parse(Console.ReadLine());
            switch (number4)
            {
                case 195234:
                    int withd1 = 0;
                    acc1.Withdraw(acc1, withd1);
                    break;
                case 300592:
                    int withd2 = 0;
                    acc2.Withdraw(acc2, withd2);
                    break;
                case 666777:
                    int withd3 = 0;
                    acc3.Withdraw(acc3, withd3);
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
                    if (acc1.RubBalance <= 0)
                    {
                        Console.WriteLine($"У {acc1.Name} нет денег на счёту для транзакции!");
                        Info.start();
                        break;
                    }
                    else if (acc1.UsdBalance <= 0)
                    {
                        Console.WriteLine($"У {acc1.Name} нет денег на счёту для транзакции!");
                        Info.start();
                        break;
                    }
                    else
                    {
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
                    }
                case 300592:
                    if (acc2.RubBalance <= 0)
                    {
                        Console.WriteLine($"У {acc2.Name} нет денег на счёту для транзакции!");
                        Info.start();
                        break;
                    }
                    else if (acc2.UsdBalance <= 0)
                    {
                        Console.WriteLine($"У {acc2.Name} нет денег на счёту для транзакции!");
                        Info.start();
                        break;
                    }
                    else
                    {
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
                    }
                case 666777:
                    if (acc3.RubBalance <= 0)
                    {
                        Console.WriteLine($"У {acc3.Name} нет денег на счёту для транзакции!");
                        Info.start();
                        break;
                    }
                    else if (acc3.UsdBalance <= 0)
                    {
                        Console.WriteLine($"У {acc3.Name} нет денег на счёту для транзакции!");
                        Info.start();
                        break;
                    }
                    else
                    {
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
                    }
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
        }

    }
}

