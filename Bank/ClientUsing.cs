using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class ClientUsing : AccountMethods
    {
        internal static void clientstart(List<Info> accounts, List<iClient> accounts2)
        {
            Info.ClientsList(accounts);
            Console.Write("Введите Id аккаунта, за которого желаете войти: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < accounts.Count;i++)
            {
                i = id;
                if (accounts[i].Age == 0)
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
                            for (int j = 0; j < accounts.Count;j++)
                            {
                                j = id;
                                accounts2[j].ShowInfo(accounts);
                                break;
                            }
                            ClientUsing.clientstart(accounts, accounts2);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write("Введите кол-во месяцев под процент: ");
                            int mounthcount = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            for (int k = 0; k < accounts.Count;k++)
                            {
                                k = id;
                                accounts2[k].ShowProfit(accounts, mounthcount, accounts2);
                                accounts2[k].ShowInfo(accounts);
                                break;
                            }
                            ClientUsing.clientstart(accounts, accounts2);
                            break;
                        case 3:
                            Console.WriteLine();
                            for (int l = 0; l < accounts.Count; l++)
                            {
                                l = id;
                                Console.WriteLine($"Рублевой счёт = {accounts[l].RubBalance} р. Долларовый счёт = {accounts[l].UsdBalance} $");
                                int withd = 0;
                                accounts2[l].Withdraw(accounts, withd, accounts2);
                                break;
                            }
                            ClientUsing.clientstart(accounts, accounts2);
                            break;
                        //case 4:
                        //    Console.WriteLine();
                        //    int depo = 0;
                        //    acc.Deposit(acc, depo);
                        //    acc.ShowInfo(acc);
                        //    ClientUsing.startusing(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //    break;
                        //case 5:
                        //    Console.WriteLine();
                        //    Info.Showid();
                        //    Info.TransactionTwo(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //    ClientUsing.startusing(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //    break;
                        //case 6:
                        //    Console.WriteLine();
                        //    Console.WriteLine($"Рублевой счёт = {acc.RubBalance} р. Долларовый счёт = {acc.UsdBalance} $");
                        //    Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                        //    int answer2 = int.Parse(Console.ReadLine());
                        //    switch (answer2)
                        //    {
                        //        case 1:
                        //            acc.RubConvertation(acc);
                        //            Console.WriteLine();
                        //            acc.ShowInfo(acc);
                        //            ClientUsing.startusing(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //            break;
                        //        case 2:
                        //            acc.UsdConvertation(acc);
                        //            Console.WriteLine();
                        //            acc.ShowInfo(acc);
                        //            ClientUsing.startusing(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //            break;
                        //        default:
                        //            Console.WriteLine("Неверная цифра!");
                        //            ClientUsing.startusing(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //            break;
                        //    }
                        //    break;
                        //case 7:
                        //    Info.usingquestion(ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //    break;
                        //default:
                        //    Console.WriteLine("Неверное число!");
                        //    ClientUsing.startusing(acc, ac1, ac2, ac3, acc1, acc2, acc3, old);
                        //    break;



                    }
                }
            
            }
        }
    }
}
