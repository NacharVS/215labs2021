using System;
using System.Collections.Generic;
using System.Text;
using Bank;

namespace Bank
{
    class Info : AccountMethods 
    {
        public Info(string name, double rubbalance, double usdbalance, int id, int datebirth, int age)
        {
            Name = name;
            RubBalance = rubbalance;
            UsdBalance = usdbalance;
            Id = id;
            DateBirth = datebirth;
            Age = age;
        }
        
        public static void startbank(List<iClient> accounts, int id, int newid)
        {
            string old = "";
            Console.WriteLine("Добро пожаловать в банк!");
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Войти за сотрудника банка");
            Console.WriteLine("2 - Войти за клиента банка;");
            Console.WriteLine("3 - Зарегестрироваться в банке");
            Console.WriteLine("4 - Завершить сеанс");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    EmployerUsing.EmployeStart(accounts, id, newid);
                    break;
                case 2:
                    Info.ClientsList(accounts);
                    Console.Write("Введите Id аккаунта, за которого желаете войти: ");
                    id = int.Parse(Console.ReadLine());
                    ClientUsing.clientstart(accounts, id, newid);
                    break;
                case 3:
                    Info.ClientAdd(accounts, newid);
                    for (int i = newid; i < accounts.Count;i++)
                    {
                        if (accounts[i].DateBirth < 1900 || accounts[i].DateBirth > 2021)
                        {
                            while (accounts[i].DateBirth < 1900 || accounts[i].DateBirth > 2021)
                            {
                                accounts[i].DateBirth = 0;
                                Console.Write("Дата рождения неверна! Введите заново: ");
                                int date = int.Parse(Console.ReadLine());
                                accounts[i].DateBirth += date;
                                if (accounts[i].DateBirth < 1900 || accounts[i].DateBirth > 2021)
                                {
                                    continue;
                                }
                                else if (accounts[i].DateBirth > 1900 || accounts[i].DateBirth < 2021)
                                {
                                    accounts[i].Age = DateTime.Now.Year - accounts[i].DateBirth;
                                    break;
                                }
                            }
                            break;
                        }
                        else if (accounts[i].DateBirth > 1900 || accounts[i].DateBirth < 2021)
                        {
                            accounts[i].Age = DateTime.Now.Year - accounts[i].DateBirth;
                            break;
                        }
                        
                    }
                    break;
                case 4:
                    Console.WriteLine("Досвидания!");
                    break;
            }
        }
        public static void ClientAdd(List<iClient> accounts, int newid)
        {
            Console.WriteLine();
            Console.WriteLine("Введите поочерёдно, нажимая Enter: 1 - Имя; 2 - Дата рождения;");
            accounts.Add(new Info(Console.ReadLine(), 0, 0, newid, int.Parse(Console.ReadLine()), 0));
            for (int i = newid; i < accounts.Count; i++)
            {
                if (accounts[i].DateBirth < 1900 || accounts[i].DateBirth > 2021)
                {
                    while (accounts[i].DateBirth < 1900 || accounts[i].DateBirth > 2021)
                    {
                        accounts[i].DateBirth = 0;
                        Console.Write("Дата рождения неверна! Введите заново: ");
                        int date = int.Parse(Console.ReadLine());
                        accounts[i].DateBirth += date;
                        if (accounts[i].DateBirth < 1900 || accounts[i].DateBirth > 2021)
                        {
                            continue;
                        }
                        else if (accounts[i].DateBirth > 1900 || accounts[i].DateBirth < 2021)
                        {
                            accounts[i].Age = DateTime.Now.Year - accounts[i].DateBirth;
                            break;
                        }
                    }
                    break;
                }
                else if (accounts[i].DateBirth > 1900 || accounts[i].DateBirth < 2021)
                {
                    accounts[i].Age = DateTime.Now.Year - accounts[i].DateBirth;
                    break;
                }
            }
            ClientUsing.clientstart(accounts, newid, newid);
        }
        public static void ClientsList(List<iClient> accounts)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine($"Id: {accounts[i].Id} {accounts[i].Name}");
            }
        }
    }
}
