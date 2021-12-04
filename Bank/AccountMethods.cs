using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class AccountMethods : IEmploye , iClient
    {
        private string _name;
        private double _rubbalance;
        private double _usdbalance;
        private int _id;
        private static double rate = 0.09;
        private int _datebirth;
        private int _age;
        private static double wellrate = 76;
        private static double withdrawrubmaxlimit = 30000;
        private static double withdrawrubminlimit = 100;
        private static double withdrawusdmaxlimit = 1000;
        private static double withdrawusdminlimit = 50;
        private static double depositrubminlimit = 50;
        private static double depositrubmaxlimit = 100000;
        private static double depositusdminlimit = 10;
        private static double depositusdmaxlimit = 5000;
        private static double rubmaxtransaction = 50000;
        private static double usdmaxtransaction = 2500;

        public int DateBirth
        {
            get
            {
                return _datebirth;
            }
            set
            {
                _datebirth = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double RubBalance
        {
            get
            {
                return _rubbalance;
            }
            set
            {
                _rubbalance = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public double UsdBalance
        {
            get
            {
                return _usdbalance;
            }
            set
            {
                _usdbalance = value;
            }
        }
        int IEmploye.DateBirth
        {
            get
            {
                return _datebirth;
            }
            set
            {
                _datebirth = value;
            }
        }
        int IEmploye.Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        int IEmploye.Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        string IEmploye.Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        double IEmploye.RubBalance
        {
            get
            {
                return _rubbalance;
            }
            set
            {
                _rubbalance = value;
            }
        }
        double IEmploye.UsdBalance
        {
            get
            {
                return _usdbalance;
            }
            set
            {
                _usdbalance = value;
            }
        }

        void IEmploye.NameChange(List<Info> accounts, string old)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine($"{accounts[i].Id} Текущее имя {accounts[i].Name}");
                old = accounts[i].Name;
                Console.Write("Введите новое имя: ");
                string answer = Console.ReadLine();
                accounts[i].Name = answer;
                Console.WriteLine($"Успешно! Id: {accounts[i].Id} Старое имя: {old} Текущее имя: {accounts[i].Name}");
                break;
            }
            
        }
        void IEmploye.AgeInput(List<Info> accounts)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Age > 0)
                {
                    continue;
                }
                else if (accounts[i].Age == 0)
                {
                    Console.Write($"Введите дату рождения {accounts[i].Name}: ");
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
                                accounts[i].DateBirth += date;
                                accounts[i].Age += DateTime.Now.Year - accounts[i].DateBirth;
                                break;
                            }
                        }
                    }
                    else if (date > 1900 || date < 2021)
                    {
                        accounts[i].DateBirth += date;
                        accounts[i].Age += DateTime.Now.Year - accounts[i].DateBirth;
                    }
                    Console.WriteLine($"Имя: {accounts[i].Name} Id: {accounts[i].Id} Дата рождения: {accounts[i].DateBirth} Возраст: {accounts[i].Age}");
                }
            }
            
        }

        void IEmploye.RateChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущая банковская ставка = {rate}; ");
            Console.Write($"Введите новую ставку: ");
            double answer = double.Parse(Console.ReadLine());
            if (rate > 0)
            {
                rate = 0;
                rate += answer;
                Console.WriteLine($"Успешно! Текущая ставка = {rate}");
            }
            else if (rate == 0)
            {
                rate += answer;
                Console.WriteLine($"Успешно! Текущая ставка = {rate}");
            }
        }

        void IEmploye.RubTransactionChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущий макс лимит на транзакцию в рублях = {rubmaxtransaction} р.");
            Console.Write($"Введите новый мин. лимит: ");
            double lim = double.Parse(Console.ReadLine());
            if (rubmaxtransaction > 0)
            {
                rubmaxtransaction = 0;
                rubmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {rubmaxtransaction} р.");
            }
            else if (rubmaxtransaction == 0)
            {
                rubmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {rubmaxtransaction} р.");
            }
        }

        void IEmploye.UsdDepoLimitChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на пополнение в долларах: мин. лимит = {depositusdminlimit} $.  макс. лимит = {depositusdmaxlimit} $.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (depositusdminlimit > 0)
                    {
                        depositusdminlimit = 0;
                        depositusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositusdminlimit} $.");
                    }
                    else if (depositusdminlimit == 0)
                    {
                        depositusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositusdminlimit} $.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (depositusdmaxlimit > 0)
                    {
                        depositusdmaxlimit = 0;
                        depositusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {depositusdmaxlimit} $.");
                    }
                    else if (depositusdmaxlimit == 0)
                    {
                        depositusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositusdmaxlimit} $.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmploye.RubDepoLimitChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на пополнение в рублях: мин. лимит = {depositrubminlimit} р.  макс. лимит = {depositrubmaxlimit} р.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (depositrubminlimit > 0)
                    {
                        depositrubminlimit = 0;
                        depositrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositrubminlimit} р.");
                    }
                    else if (depositrubminlimit == 0)
                    {
                        depositrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositrubminlimit} р.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (depositrubmaxlimit > 0)
                    {
                        depositrubmaxlimit = 0;
                        depositrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {depositrubmaxlimit} р.");
                    }
                    else if (depositrubmaxlimit == 0)
                    {
                        depositrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositrubmaxlimit} р.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmploye.RubWithLimitChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на вывод в рублях: мин. лимит = {withdrawrubminlimit} р.  макс. лимит = {withdrawrubmaxlimit} р.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (withdrawrubminlimit > 0)
                    {
                        withdrawrubminlimit = 0;
                        withdrawrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawrubminlimit} р.");
                    }
                    else if (withdrawrubminlimit == 0)
                    {
                        withdrawrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawrubminlimit} р.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (withdrawrubmaxlimit > 0)
                    {
                        withdrawrubmaxlimit = 0;
                        withdrawrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {withdrawrubmaxlimit} р.");
                    }
                    else if (withdrawrubmaxlimit == 0)
                    {
                        withdrawrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawrubmaxlimit} р.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }
        void IEmploye.UsdwithLimitChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на вывод в долларах: мин. лимит = {withdrawusdminlimit} $.  макс. лимит = {withdrawusdmaxlimit} $.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (withdrawusdminlimit > 0)
                    {
                        withdrawusdminlimit = 0;
                        withdrawusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawusdminlimit} $.");
                    }
                    else if (withdrawusdminlimit == 0)
                    {
                        withdrawusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawusdminlimit} $.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (withdrawusdmaxlimit > 0)
                    {
                        withdrawusdmaxlimit = 0;
                        withdrawusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {withdrawusdmaxlimit} $.");
                    }
                    else if (withdrawusdmaxlimit == 0)
                    {
                        withdrawusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawusdmaxlimit} $.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmploye.UsdTransactionChange(List<Info> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущий макс лимит на транзакцию в долларах = {usdmaxtransaction} $.");
            Console.Write($"Введите новый мин. лимит: ");
            double lim = double.Parse(Console.ReadLine());
            if (usdmaxtransaction > 0)
            {
                usdmaxtransaction = 0;
                usdmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {usdmaxtransaction} $.");
            }
            else if (usdmaxtransaction == 0)
            {
                usdmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {usdmaxtransaction} $.");
            }
        }

        void iClient.AgeInput(List<Info> accounts)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Age > 0)
                {
                    continue;
                }
                else if (accounts[i].Age == 0)
                {
                    Console.Write($"Введите дату рождения {accounts[i].Name}: ");
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
                                accounts[i].DateBirth += date;
                                accounts[i].Age += DateTime.Now.Year - accounts[i].DateBirth;
                                break;
                            }
                        }
                    }
                    else if (date > 1900 || date < 2021)
                    {
                        accounts[i].DateBirth += date;
                        accounts[i].Age += DateTime.Now.Year - accounts[i].DateBirth;
                    }
                    Console.WriteLine($"Имя: {accounts[i].Name} Id: {accounts[i].Id} Дата рождения: {accounts[i].DateBirth} Возраст: {accounts[i].Age}");
                }
            }

        }
        void iClient.ShowInfo(List<Info> accounts)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine($"id: {accounts[i].Id} Имя: {accounts[i].Name} Возраст: {accounts[i].Age} Баланс в рублях = {accounts[i].RubBalance} р. Баланс в долларах = {accounts[i].UsdBalance} $");
                break;
            }
        }
    }
    
}
