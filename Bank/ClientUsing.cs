using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class ClientUsing : AccountMethods
    {
        internal static void clientstart(List<iClient> accounts, int id, int newid)
        {
            newid++;
            for (int i = id; i < accounts.Count;)
            {
                
                if (accounts[i].Age == 0)
                {
                    accounts[i].AgeInput(accounts,id);
                    Console.WriteLine();
                    Console.WriteLine("Что вы хотите сделать?");
                    Console.WriteLine("1 - Просмотреть информацию о себе");
                    Console.WriteLine("2 - Положить деньги под процент");
                    Console.WriteLine("3 - Вывести деньги со счёта");
                    Console.WriteLine("4 - Пополнить счёт");
                    Console.WriteLine("5 - Сделать транзакцию");
                    Console.WriteLine("6 - Выполнить конвертацию");
                    Console.WriteLine("7 - Выйти из аккаунта");
                    int answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            accounts[i].ShowInfo(accounts, id);
                            break;
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write("Введите кол-во месяцев под процент: ");
                            int mounthcount = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            accounts[i].ShowProfit(accounts, mounthcount,id);
                            accounts[i].ShowInfo(accounts, id);
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 3:
                            Console.WriteLine();  
                            Console.WriteLine($"Рублевой счёт = {accounts[i].RubBalance} р. Долларовый счёт = {accounts[i].UsdBalance} $");
                            int withd = 0;
                            accounts[i].Withdraw(accounts, withd, id, newid);
                            break;
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 4:
                            Console.WriteLine();
                            int depo = 0;
                            accounts[i].Depostit(accounts, depo, id, newid);
                            break;
                        case 5:
                            Console.WriteLine();
                            Info.ClientsList(accounts);
                            Console.Write("Введите id клиента, которому желаете сделать транзакцию: ");
                            int id2 = int.Parse(Console.ReadLine());
                            if (id == id2)
                            {
                                Console.WriteLine("Нельзя сделать перевод самому себе!");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else if (id != id2)
                            {
                                accounts[i].Transation(accounts, id, id2, newid);
                            }
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.WriteLine($"Рублевой счёт = {accounts[i].RubBalance} р. Долларовый счёт = {accounts[i].UsdBalance} $");
                            Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                            int answer2 = int.Parse(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    accounts[i].RubConvertation(accounts, id);
                                    Console.WriteLine();
                                    accounts[i].ShowInfo(accounts, id);
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                case 2:
                                    accounts[i].UsdConvertation(accounts, id);
                                    Console.WriteLine();
                                    accounts[i].ShowInfo(accounts, id);
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                default:
                                    Console.WriteLine("Неверная цифра!");
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                            }
                            break;
                        case 7:
                            Info.startbank(accounts, id, newid);
                            break;
                        default:
                            Console.WriteLine("Неверное число!");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;



                    }
                }
                else if (accounts[i].Age > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Что вы хотите сделать?");
                    Console.WriteLine("1 - Просмотреть информацию о себе");
                    Console.WriteLine("2 - Положить деньги под процент");
                    Console.WriteLine("3 - Вывести деньги со счёта");
                    Console.WriteLine("4 - Пополнить счёт");
                    Console.WriteLine("5 - Сделать транзакцию");
                    Console.WriteLine("6 - Выполнить конвертацию");
                    Console.WriteLine("7 - Выйти из аккаунта");
                    int answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            accounts[i].ShowInfo(accounts, id);
                            break;
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write("Введите кол-во месяцев под процент: ");
                            int mounthcount = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            accounts[i].ShowProfit(accounts, mounthcount, id);
                            accounts[i].ShowInfo(accounts, id);
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine($"Рублевой счёт = {accounts[i].RubBalance} р. Долларовый счёт = {accounts[i].UsdBalance} $");
                            int withd = 0;
                            accounts[i].Withdraw(accounts, withd, id, newid);
                            break;
                            break;
                        case 4:
                            Console.WriteLine();
                            int depo = 0;
                            accounts[i].Depostit(accounts, depo, id, newid);
                            accounts[i].ShowInfo(accounts, id);
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 5:
                            Console.WriteLine();
                            Info.ClientsList(accounts);
                            Console.Write("Введите id клиента, которому желаете сделать транзакцию: ");
                            int id2 = int.Parse(Console.ReadLine());
                            accounts[i].Transation(accounts, id, id2, newid);
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.WriteLine($"Рублевой счёт = {accounts[i].RubBalance} р. Долларовый счёт = {accounts[i].UsdBalance} $");
                            Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                            int answer2 = int.Parse(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    accounts[i].RubConvertation(accounts, id);
                                    Console.WriteLine();
                                    accounts[i].ShowInfo(accounts, id);
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                case 2:
                                    accounts[i].UsdConvertation(accounts, id);
                                    Console.WriteLine();
                                    accounts[i].ShowInfo(accounts, id);
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                default:
                                    Console.WriteLine("Неверная цифра!");
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                            }
                            break;
                        case 7:
                            Info.startbank(accounts, id, newid);
                            break;
                        default:
                            Console.WriteLine("Неверное число!");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;



                    }



                
                }
            
            }
        }
    }
}
