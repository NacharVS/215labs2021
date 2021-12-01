using System;
using System.Collections.Generic;
using System.Text;
using BanK_Account;

namespace BanK_Account
{
    class EmployeeUsing : AccountMethods, IEmployeOperations
    {
        readonly IEmployeOperations ac1 = new Info("Альфред", 2000, 100, 195234, 0, 0);
        readonly IEmployeOperations ac2 = new Info("Илья", 10000, 300, 300592, 0, 0);
        readonly IEmployeOperations ac3 = new Info("Александр", 15000, 750, 666777, 0, 0);
        void IEmployeOperations.NameChange(AccountMethods acc)
        {

        }

        void IEmployeOperations.AgeInput(AccountMethods acc)
        {
            Console.Write($"Введите дату рождения {acc.Name}: ");
            int date = int.Parse(Console.ReadLine());
            if (date < 1900 || date > 2021)
            {
                while (date < 1900 || date > 2021)
                {
                    date = 0;
                    Console.Write("Дата неверна! Введите по новой: ");
                    date = int.Parse(Console.ReadLine());
                    if (date < 1900 || date > 2021)
                    {
                        continue;
                    }
                    else if (date > 1900 || date < 2021)
                    {
                        acc.DateBirth += date;
                        acc.Age += DateTime.Now.Year - acc.DateBirth;
                        break;
                    }
                }
            }
            else if (date > 1900 || date < 2021)
            {
                acc.DateBirth += date;
                acc.Age += DateTime.Now.Year - acc.DateBirth;
            }
            Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
        }
        void IEmployeOperations.list(IEmployeOperations acc)
        {
            Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
        }

        internal static void EmployeeStart(IEmployeOperations ac1, IEmployeOperations ac2, IEmployeOperations ac3, AccountMethods acc1, AccountMethods acc2, AccountMethods acc3)
        {

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть сведения о всех клиентах");
            Console.WriteLine("2 - Изменить имя клиентов");
            Console.WriteLine("3 - Изменить возраст клиентов");
            Console.WriteLine("4 - Изменить процентную ставку");
            Console.WriteLine("5 - Изменить лимиты на пополнение в рублях");
            Console.WriteLine("6 - Изменить лимиты на пополнение в долларах");
            Console.WriteLine("7 - Изменить лимиты на вывод в рублях");
            Console.WriteLine("8 - Изменить лимиты на вывод в долларах");
            Console.WriteLine("9 - Изменить лимит на транзакцию в рублях");
            Console.WriteLine("10 - Изменить лимит на транзакцию в долларах");
            Console.WriteLine("0 - Выйти из сеанса");
            Console.WriteLine();
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (ac1.Age == 0)
                    {
                        ac1.AgeInput(acc1);
                    }
                    if (acc2.Age == 0)
                    {
                        ac2.AgeInput(acc2);
                    }
                    if (acc3.Age == 0)
                    {
                        ac3.AgeInput(acc3);
                    }
                    Console.WriteLine();
                    ac1.list(ac1);
                    ac2.list(ac2);
                    ac3.list(ac3);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 2:
                    Console.WriteLine();
                    ac1.list(ac1);
                    ac2.list(ac2);
                    ac3.list(ac3);
                    Console.WriteLine();
                    EmployeeUsing.namechange(ac1, ac2, ac3, acc1, acc2, acc3);
                    ac1.list(ac1);
                    ac2.list(ac2);
                    ac3.list(ac3);
                    break;
                case 3:
                    ac1.list(ac1);
                    ac2.list(ac2);
                    ac3.list(ac3);
                    Console.WriteLine();
                    EmployeeUsing.agechange(ac1, ac2, ac3, acc1, acc2, acc3);
                    Console.WriteLine();
                    ac1.list(ac1);
                    ac2.list(ac2);
                    ac3.list(ac3);
                    break;
                case 4:
                    AccountMethods.ratechange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 5:
                    AccountMethods.rubdepolimitchange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 6:
                    AccountMethods.usddepolimitchange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 7:
                    AccountMethods.rubwithlimitchange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 8:
                    AccountMethods.usdwithlimchange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 9:
                    AccountMethods.rubtransactionchange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 10:
                    AccountMethods.usdtransactionchange();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 0:
                    Info.usingquestion(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
            }
        }
        public static void agechange(IEmployeOperations ac1, IEmployeOperations ac2, IEmployeOperations ac3, AccountMethods acc1, AccountMethods acc2, AccountMethods acc3)
        {
            Console.Write("Напишите id клиента, которому желаете поменять возраст: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 195234:
                    acc1.Age = 0;
                    ac1.Age = 0;
                    ac1.DateBirth = 0;
                    acc1.DateBirth = 0;
                    ac1.AgeInput(acc1);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 300592:
                    acc2.Age = 0;
                    ac2.Age = 0;
                    ac2.DateBirth = 0;
                    acc2.DateBirth = 0;
                    ac2.AgeInput(acc2);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 666777:
                    acc3.Age = 0;
                    ac3.Age = 0;
                    ac3.DateBirth = 0;
                    acc3.DateBirth = 0;
                    ac3.AgeInput(acc3);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                default:
                    Console.WriteLine("Неверный ID!");
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
            }
        }
        public static void namechange(IEmployeOperations ac1, IEmployeOperations ac2, IEmployeOperations ac3, AccountMethods acc1, AccountMethods acc2, AccountMethods acc3)
        {
            Console.Write("Напишите id клиента, которому желаете поменять имя: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 195234:
                    ac1.NameChange(acc1);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1,  ac2,  ac3, acc1,  acc2,  acc3);
                    break;
                case 300592:
                    ac2.NameChange(acc2);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                case 666777:
                    ac3.NameChange(acc3);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
                default:
                    Console.WriteLine("Неверный ID!");
                    EmployeeUsing.EmployeeStart(ac1, ac2, ac3, acc1, acc2, acc3);
                    break;
            }
        }
    }
}
