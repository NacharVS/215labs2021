using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class AccountMethods : IEmploye
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
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"{accounts[i].Id} Текущее имя {accounts[i].Name}");
                old = accounts[i].Name;
                Console.Write("Введите новое имя: ");
                string answer = Console.ReadLine();
                accounts[i].Name = answer;
                Console.WriteLine($"Успешно! Id: {accounts[i].Id} Старое имя: {old} Текущее имя: {accounts[i].Name}");
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
            
        }

        void IEmploye.RubTransactionChange(IEmploye ac)
        {
            
        }

        void IEmploye.UsdDepoLimitChange(IEmploye ac)
        {
            
        }

        void IEmploye.RubDepoLimitChange(IEmploye ac)
        {
            
        }

        void IEmploye.RubWithLimitChange(IEmploye ac)
        {
            
        }

        void IEmploye.UsdwithLimitChange(IEmploye ac)
        {
            
        }

        void IEmploye.UsdTransactionChange(IEmploye ac)
        {
            
        }
    }
}
