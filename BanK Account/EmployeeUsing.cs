using System;
using System.Collections.Generic;
using System.Text;
using BanK_Account;

namespace BanK_Account
{
    class EmployeeUsing : AccountMethods, IEmployeOperations
    {

        void IEmployeOperations.BirthDateChange(IEmployeOperations acc)
        {

        }
        void IEmployeOperations.NameChange(AccountMethods acc)
        {

        }

        void IEmployeOperations.RateChange()
        {

        }

        void IEmployeOperations.RubDepChange()
        {

        }

        void IEmployeOperations.RubWithdChange()
        {

        }

        void IEmployeOperations.TransactionChange()
        {

        }

        void IEmployeOperations.UsdDepChange()
        {

        }

        void IEmployeOperations.UsdWithdChange()
        {

        }
        void IEmployeOperations.AgeInput(AccountMethods acc )
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

        internal static void EmployeeStart()
        {

            AccountMethods acc1 = new Info("Альфред", 2000, 100, 195234, 0, 0);
            AccountMethods acc2 = new Info("Илья", 10000, 300, 300592, 0, 0);
            AccountMethods acc3 = new Info("Александр", 15000, 750, 666777, 0, 0);
            IEmployeOperations ac1 = acc1;
            IEmployeOperations ac2 = acc2;
            IEmployeOperations ac3 = acc3;

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть сведения о всех клиентах");
            Console.WriteLine("2 - Изменить имя клиентов");
            Console.WriteLine("3 - Изменить возраст клиентов");
            Console.WriteLine("4 - Изменить процентную ставку");
            Console.WriteLine("5 - Изменить лимиты на пополнение в рублях");
            Console.WriteLine("6 - Изменить лимиты на пополнение в долларах");
            Console.WriteLine("7 - Изменить лимиты на вывод в рублях");
            Console.WriteLine("8 - Изменить лимиты на вывод в долларах");
            Console.WriteLine("9 - Изменить лимит на транзакцию");
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
                    else
                    {
                        ac1.list(acc1);
                    }
                    if (acc2.Age == 0)
                    {
                        ac2.AgeInput(acc2);
                    }
                    else
                    {
                        ac2.list(acc2);
                    }
                    if (acc3.Age == 0)
                    {
                        ac3.AgeInput(acc3);
                    }
                    else
                    {
                        ac3.list(acc3);
                    }
                    ac1.list(acc1);
                    ac2.list(acc2);
                    ac3.list(acc3);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart();
                    break;
                case 2:
                    Console.WriteLine();
                    ac1.list(acc1);
                    ac2.list(acc2);
                    ac3.list(acc3);
                    Console.WriteLine();
                    EmployeeUsing.namechange();
                    ac1.list(acc1);
                    ac2.list(acc2);
                    ac3.list(acc3);
                    break;
            }
        }
        public static void namechange()
        {
            AccountMethods acc1 = new Info("Альфред", 2000, 100, 195234, 0, 0);
            AccountMethods acc2 = new Info("Илья", 10000, 300, 300592, 0, 0);
            AccountMethods acc3 = new Info("Александр", 15000, 750, 666777, 0, 0);
            IEmployeOperations ac1 = acc1;
            IEmployeOperations ac2 = acc2;
            IEmployeOperations ac3 = acc3;
            Console.Write("Напишите id клиента, которому желаете поменять имя: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 195234:
                    ac1.NameChange(acc1);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart();
                    break;
                case 300592:
                    ac2.NameChange(acc2);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart();
                    break;
                case 666777:
                    ac3.NameChange(acc3);
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart();
                    break;
                default:
                    Console.WriteLine("Неверный ID!");
                    EmployeeUsing.EmployeeStart();
                    break;
            }
        }
    }
}
