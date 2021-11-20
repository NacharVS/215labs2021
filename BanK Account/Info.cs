using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class Info
    {
        public static AccountMethods acc1 = new AccountMethods("Альфред", 2000);
        public static AccountMethods acc2 = new AccountMethods("Илья", 10000);
        public static AccountMethods acc3 = new AccountMethods("Александр", 15000);

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
                    Console.WriteLine("Всего 3 клиента. Введите номер, чтобы просмотреть информацию");
                    int answer1 = int.Parse(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:
                            Console.WriteLine();
                            acc1.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            Console.WriteLine();
                            acc2.ShowInfo();
                            Info.start();
                            break;
                        case 3:
                            Console.WriteLine();
                            acc3.ShowInfo();
                            Info.start();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.start();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Всего 3 клиента. Введите номер, чтобы просмотреть информацию");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Введите кол-во месяцев для начисления %");
                            int monthammount1 = int.Parse(Console.ReadLine());
                            acc1.ShowProfit(acc1,monthammount1);
                            acc1.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Введите кол-во месяцев для начисления %");
                            int monthammount2 = int.Parse(Console.ReadLine());
                            acc2.ShowProfit(acc2, monthammount2);
                            acc2.ShowInfo();
                            Info.start();
                            break;
                        case 3:
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
                    break;
                case 3:
                    Console.Write("Введите номер клиента которому желаете пополнить балик (3 номера): ");
                    int number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму которую хотите добавить");
                            int depo = int.Parse(Console.ReadLine());
                            acc1.Deposit(acc1, depo);
                            acc1.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму которую хотите добавить");
                            int depo1 = int.Parse(Console.ReadLine());
                            acc2.Deposit(acc2, depo1);
                            acc2.ShowInfo();
                            Info.start();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму которую хотите добавить");
                            int depo3 = int.Parse(Console.ReadLine());
                            acc3.Deposit(acc3, depo3);
                            acc3.ShowInfo();
                            Info.start();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.start();
                            break;
                    }
                    break;
                case 4:
                    Console.Write("Введите номер клиента которому желаете вывести балик (3 номера): ");
                    int number4 = int.Parse(Console.ReadLine());
                    switch (number4)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму которую хотите вывести");
                            int withd = int.Parse(Console.ReadLine());
                            acc1.Withdraw(acc1, withd);
                            acc1.ShowInfo();
                            Info.start();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму которую хотите вывести");
                            int withd2 = int.Parse(Console.ReadLine());
                            acc2.Withdraw(acc2, withd2);
                            acc2.ShowInfo();
                            Info.start();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму которую хотите вывести");
                            int withd3 = int.Parse(Console.ReadLine());
                            acc3.Withdraw(acc3, withd3);
                            acc3.ShowInfo();
                            Info.start();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.start();
                            break;
                    }
                    break;
                case 5:
                    Console.Write("Введите номер клиента от которого желаете сделать транзакцию (3 номера): ");
                    int number5 = int.Parse(Console.ReadLine());
                    switch (number5)
                    {
                        case 1:
                            Console.Write("Введите номер клиента которому желаете сделать транзакцию (2,3 номера): ");
                            int answer11 = int.Parse(Console.ReadLine());
                            switch (answer11)
                            {
                                case 2:
                                    Console.WriteLine("Введите кол-во денег,  чтобы отправить");
                                    int trans = int.Parse(Console.ReadLine());
                                    acc1.balance -= trans;
                                    acc2.balance += trans;
                                    Info.start();
                                    break;
                                case 3:
                                    Console.WriteLine("Введите кол-во денег,  чтобы отправить");
                                    int trans1 = int.Parse(Console.ReadLine());
                                    acc1.balance -= trans1;
                                    acc3.balance += trans1;
                                    Info.start();
                                    break;
                                default:
                                    Console.WriteLine("Неверный номер!");
                                    Info.start();
                                    break;
                            }
                            break;
   
                        case 2:
                            Console.Write("Введите номер клиента которому желаете сделать транзакцию (1,3 номера): ");
                            int answer111 = int.Parse(Console.ReadLine());
                            switch (answer111)
                            {
                                case 1:
                                    Console.WriteLine("Введите кол-во денег,  чтобы отправить");
                                    int trans21 = int.Parse(Console.ReadLine());
                                    acc2.balance -= trans21;
                                    acc1.balance += trans21;
                                    Info.start();
                                    break;
                                case 3:
                                    Console.WriteLine("Введите кол-во денег,  чтобы отправить");
                                    int trans12 = int.Parse(Console.ReadLine());
                                    acc2.balance -= trans12;
                                    acc3.balance += trans12;
                                    Info.start();
                                    break;
                                default:
                                    Console.WriteLine("Неверный номер!");
                                    Info.start();
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("Введите номер клиента которому желаете сделать транзакцию (1,2 номера): ");
                            int answer1111 = int.Parse(Console.ReadLine());
                            switch (answer1111)
                            {
                                case 1:
                                    Console.WriteLine("Введите кол-во денег,  чтобы отправить");
                                    int trans212 = int.Parse(Console.ReadLine());
                                    acc3.balance -= trans212;
                                    acc1.balance += trans212;
                                    Info.start();
                                    break;
                                case 2:
                                    Console.WriteLine("Введите кол-во денег,  чтобы отправить");
                                    int trans122 = int.Parse(Console.ReadLine());
                                    acc3.balance -= trans122;
                                    acc2.balance += trans122;
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
                    break;
            }
        }
        
    }

}
