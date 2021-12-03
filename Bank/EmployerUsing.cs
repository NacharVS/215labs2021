using System;
using System.Collections.Generic;
using System.Text;

namespace Bank 
{
    class EmployerUsing : AccountMethods
    {
        public static void accountslist(List<Info> accounts)
        {
            for (int i = 0; i < accounts.Count;i++)
            {
                Console.WriteLine($"Имя: {accounts[i].Name} Id: {accounts[i].Id} Дата рождения: {accounts[i].DateBirth} Возраст: {accounts[i].Age}");
            }
            
        }
        internal static void EmployeStart(List<Info> accounts, List<IEmploye> accounts1)
        {
            string old = "";
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
                    for (int i = 0; i < accounts.Count; i++)
                    {
                        if (accounts[i].Age == 0)
                        {
                            for (int j = 0; j < accounts.Count; j++)
                            {
                                accounts1[i].AgeInput(accounts);
                            }
                        }
                        else { }
                    }
                    Console.WriteLine();
                    EmployerUsing.accountslist(accounts);
                    Console.WriteLine();
                    EmployerUsing.EmployeStart(accounts, accounts1);
                    break;
                case 2:
                    for (int i = 0; i < 1; i++)
                    {
                        i = int.Parse(Console.ReadLine()); 
                        accounts1[i].NameChange(accounts, old);
                    }

            }
        }
    }
}
