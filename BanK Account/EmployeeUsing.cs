﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class EmployeeUsing : AccountMethods ,   IEmployeOperations
    {

        void IEmployeOperations.BirthDateChange(IEmployeOperations acc)
        {
           AccountMethods acc1 = new Info("Альфред", 2000, 100, 195234);
            acc = acc1;
            acc.NameChange(acc1);
        }
        void IEmployeOperations.NameChange(AccountMethods acc)
        {
            //Console.WriteLine();
            //Info.Showid();
            //Console.Write("Введите id клиента для смены имени: ");
            //int answer = int.Parse(Console.ReadLine());
            //switch (answer)
            //{
            //    case 195234:

            //}
            
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
        internal static void EmployeeStart()
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
            Console.WriteLine("9 - Изменить лимит на транзакцию");
            Console.WriteLine("0 - Выйти из сеанса");
            Console.WriteLine();
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Info.employeelist();
                    Console.WriteLine();
                    EmployeeUsing.EmployeeStart();
                    break;
                case 2:
                    break;
            }

        }
        public static void abiba()
        {
            AccountMethods acc1 = new Info("Альфред", 2000, 100, 195234);
            IEmployeOperations acc = acc1;
            acc.NameChange(acc1);
        }
    }
}
