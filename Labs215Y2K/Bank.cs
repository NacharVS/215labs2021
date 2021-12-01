using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Bank
    {
        static void Main(string[] args)
        {

            Imploer acc1 = new Imploer("Ян", 15000, "89001651005", 2005, 5000);
            Client acc2 = new Client("Дмитрий", 16000, "89600369975", 2004, 20);
            Client acc3 = new Client("Илья", 5000, "89895527896", 2004, 50);
            Client acc4 = new Client("Александр", 6000, "89566427952", 2003, 200);
            Client acc5 = new Client("Никита", 1000, "85365674824", 2004, 300);
            Client acc6 = new Client("Артем", 1300, "87946476803", 2004, 450);

            Client[] accounts = new Client[6];
            accounts[1] = acc2;
            accounts[2] = acc3;
            accounts[3] = acc4;
            accounts[4] = acc5;
            accounts[5] = acc6;

            while (true)
            {
                Console.WriteLine();
                for (int i = 0; i < accounts.Length; i++)
                {
                    accounts[i].ShowInfo();
                }
                Console.WriteLine();

                Console.WriteLine("Выберите аккаунт:");
                Console.WriteLine("Введите ID");
                string fff = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine();
                    acc1.ShowInfo();
                    for (int i = 0; i < accounts.Length; i++)
                    {
                        if (accounts[i].ID1 == fff)
                        {
                            accounts[i].ShowInfo();

                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine("Выберите услугу:");
                    Console.WriteLine("Внести наличные(1)");
                    Console.WriteLine("Снять наличные(2)");
                    Console.WriteLine("Перевести деньги(3)");
                    Console.WriteLine("Показать ставку(4)");
                    Console.WriteLine("Конвертировать валюту(5)");
                    Console.WriteLine("Поменять аккаунт(6)");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму");
                        double cash = double.Parse(Console.ReadLine());
                        if (acc1.ID1 == fff)
                        {
                            acc1.Deposit(acc1, cash);
                        }
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            if (accounts[i].ID1 == fff)
                            {
                                accounts[i].Deposit(accounts[i], cash);

                            }
                        }
                        continue;
                    }
                    if (a == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму");
                        double cash = double.Parse(Console.ReadLine());
                        if (acc1.ID1 == fff)
                        {
                            acc1.Deposit(acc1, cash);
                        }
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            if (accounts[i].ID1 == fff)
                            {
                                accounts[i].Withdraw(accounts[i], cash);

                            }
                        }
                        continue;
                    }
                    if (a == 3)
                    {
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            if (accounts[i].ID1 == fff)
                            {
                                Console.WriteLine($"Выберите валюту");
                                Console.WriteLine($"Рубли(1)");
                                Console.WriteLine($"Доллары(2)");
                                int valute = int.Parse(Console.ReadLine());
                                Console.WriteLine("Выберите аккаунт на который хотите перевести деньги");
                                Console.WriteLine("Введите ID");
                                string ddd = Console.ReadLine();

                                Console.WriteLine();
                                for (int j = 0; j < accounts.Length; j++)
                                {
                                    if (accounts[j].ID1 == ddd)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"Введите сумму, которую хотите перевести {accounts[j].NAME}");
                                        double money = double.Parse(Console.ReadLine());
                                        accounts[i].Transaction(accounts[i], accounts[j], money, valute);

                                    }
                                }
                            }
                        }
                    }
                    if (a == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Введите количество месяцев");
                        int month = int.Parse(Console.ReadLine());
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            if (accounts[i].ID1 == fff)
                            {
                                accounts[i].ShowProfit(accounts[i], month);
                            }
                        }
                    }
                    if (a == 5)
                    {
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            if (accounts[i].ID1 == fff)
                            {
                                accounts[i].Conversation(accounts[i]);
                            }
                        }
                    }
                    if (a == 6)
                    {
                        break;
                    }
                    if (a == 7)
                    {
                        Console.WriteLine("Наберите 1, 2, 3, 4, 5 или 6");
                    }
                    else
                    {
                        Console.WriteLine("Наберите 1, 2, 3, 4, 5 или 6");
                    }
                }
            }
        }
    }
}
        
