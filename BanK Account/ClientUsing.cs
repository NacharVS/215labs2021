using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class ClientUsing : AccountMethods , IClientOperations
    {
        void IClientOperations.ConvertOp(AccountMethods acc)
        {

        }

        void IClientOperations.deposit(IClientOperations acc)
        {
            
        }

        void IClientOperations.trans()
        {
            
        }

        void IClientOperations.withdraw()
        {
            
        }
        internal static void startusing(AccountMethods acc)
        {
            Console.WriteLine();
            acc.AgeInput();
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
                    acc.ShowInfo();
                    ClientUsing.startusing(acc);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write("Введите кол-во месяцев под процент: ");
                    int mounthcount = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    acc.ShowProfit(acc, mounthcount);
                    acc.ShowInfo();
                    ClientUsing.startusing(acc);
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine($"Рублевой счёт = {acc.RubBalance} р. Долларовый счёт = {acc.UsdBalance} $");
                    int withd = 0;
                    acc.Withdraw(acc, withd);
                    ClientUsing.startusing(acc);
                    break;
                case 4:
                    Console.WriteLine();
                    int depo = 0;
                    acc.Deposit(acc, depo);
                    acc.ShowInfo();
                    ClientUsing.startusing(acc);
                    break;
                case 5:
                    Console.WriteLine();
                    Info.Showid();
                    Info.TransactionTwo(acc);
                    ClientUsing.startusing(acc);
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine($"Рублевой счёт = {acc.RubBalance} р. Долларовый счёт = {acc.UsdBalance} $");
                    Console.WriteLine("С какого счета вы хотите произвевсти конвертацию? 1 - c рублевого; 2 - с долларового");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            acc.RubConvertation(acc);
                            Console.WriteLine();
                            acc.ShowInfo();
                            ClientUsing.startusing(acc);
                            break;
                        case 2:
                            acc.UsdConvertation(acc);
                            Console.WriteLine();
                            acc.ShowInfo();
                            ClientUsing.startusing(acc);
                            break;
                        default:
                            Console.WriteLine("Неверная цифра!");
                            ClientUsing.startusing(acc);
                            break;
                    }
                    break;
                case 7:
                    Info.usingquestion();
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    ClientUsing.startusing(acc);
                    break;



            }
            
        }
    }
}
