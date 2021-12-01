﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods : IEmployeOperations
    {
        private string _name;
        private double _rubbalance;
        private double _usdbalance;
        private int _id;
        private static double rate = 0.09;
        private int _datebirth;
        private int _age;
        private static double wellrate = 76;
        private double withdrawrubmaxlimit = 30000;
        private double withdrawrubminlimit = 100;
        private double withdrawusdmaxlimit = 1000;
        private double withdrawusdminlimit = 50;
        private double depositrubminlimit = 50;
        private double depositrubmaxlimit = 100000;
        private double depositusdminlimit = 10;
        private double depositusdmaxlimit = 5000;
        private double rubmaxtransaction = 50000;
        private double usdmaxtransaction = 2500;

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

        string IEmployeOperations.Name
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
        double IEmployeOperations.Rubbalance
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
        double IEmployeOperations.Usdbalance
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
        int IEmployeOperations.Id
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
        int IEmployeOperations.Age
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
        int IEmployeOperations.DateBirth
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
        public void AgeInput(AccountMethods acc)
        {
            Console.Write($"Введите дату рождения {acc.Name}: ");
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
                        acc.DateBirth += date;
                        acc.Age += DateTime.Now.Year - acc.DateBirth;
                        break;
                    }
                }
            }
            else if (date > 1900 || date < 2021)
            {
                acc.DateBirth += date;
                acc.Age += DateTime.Now.Year - acc.DateBirth;
            }
            Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
        }    
        public void ShowInfo()
        {
              Console.WriteLine($"id: {Id} Имя: {Name} Возраст: {Age} Баланс в рублях = {RubBalance} р. Баланс в долларах = {UsdBalance} $");
        }
        public void ShowId()
        {
            Console.WriteLine($"id: {Id} Имя: {Name}");
        }

        public void ShowProfit(AccountMethods acc, int month)
        {
            Console.WriteLine("Какой счёт вы хотите использовать под проценты? 1 - рублевой; 2 - долларовый");
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < month; i++)
                    {
                        acc.RubBalance += acc.RubBalance * rate;
                    }
                    break;
                case 2:
                    for (int i = 0; i < month; i++)
                    {
                        acc.UsdBalance += acc.UsdBalance * rate;
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.start();
                    break;
            }
        }

        public void Deposit(AccountMethods acc, int depo)
        {
            Console.WriteLine();
            Console.WriteLine("Лимит на пополнение в рублях - 100.000 р. в долларах - 5.000 $");
            Console.WriteLine("Куда вы хотите ввести деньги? 1 - на рублевой счёт; 2 - на долларовый счёт");
            Console.Write("Введите число: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    depo = int.Parse(Console.ReadLine());
                    if (depo < 0)
                    {
                        Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
                    }
                    else if (depo <= depositrubmaxlimit)
                    {
                        if (depo > depositrubminlimit)
                        {
                            acc.RubBalance += depo;
                            Console.WriteLine($"{acc.Name} - начислено {depo} р. на рублевой счёт");
                        }
                        else if (depo < depositrubminlimit)
                        {
                            Console.WriteLine("Нельзя внести менее 50 рублей");
                            break;
                        }
                    }
                    else if (depo > depositrubmaxlimit)
                    {
                        Console.WriteLine("Нельзя внести более 100.000 р.");
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    depo = int.Parse(Console.ReadLine());
                    if (depo < 0)
                    {
                        Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
                    }
                    else if (depo <= depositusdmaxlimit)
                    {
                        if (depo > depositusdminlimit)
                        {
                            acc.UsdBalance += depo;
                            Console.WriteLine($"{acc.Name} - начислено {depo} $");
                        }
                        else if (depo < depositrubminlimit)
                        {
                            Console.WriteLine("Нельзя внести менее 10 $");
                            break;
                        }
                    }
                    else if (depo > depositusdmaxlimit)
                    {
                        Console.WriteLine("Нельзя внести более 5.000 $");
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.start();
                    break;
            }
            
        }

        public void Withdraw(AccountMethods acc, int withd)
        {
            Console.WriteLine();
            Console.WriteLine("Лимит на снятие денег с рублевого счёта - 30.000 р. с долларового счёта - 1.000 $");
            Console.WriteLine("С какого счёта вы хотите вывести деньги? 1 - c рублевого счёта; 2 - c долларового счёта");
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (acc.RubBalance <= 0)
                    {
                        Console.WriteLine($"{acc.Name} не имеет денег на счету для вывода");
                    }
                    else if (acc.RubBalance > 0)
                    {
                        Console.WriteLine();
                        Console.Write("Введите сумму которую хотите вывести: ");
                        withd = int.Parse(Console.ReadLine());
                        if (withd > withdrawrubmaxlimit)
                        {
                            Console.WriteLine("Нельзя вывести более 30.000 руб.");
                            break;
                        }
                        else if (withd <= acc.RubBalance)
                        {
                            if (withd < withdrawrubminlimit)
                            {
                                Console.WriteLine("Нельзя вывести меньше 100 руб.");
                                break;
                            }
                            else if (withd < withdrawrubmaxlimit)
                            {
                                acc.RubBalance -= withd;
                                Console.WriteLine($"{acc.Name} - успешно выведено {withd} р.");
                                acc.ShowInfo();
                            }
                        }
                        else if (withd < withdrawrubminlimit)
                        {
                            Console.WriteLine("Нельзя вывести меньше 100 руб.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"У {acc.Name} нет столько р. на счету для вывода");
                            
                        }

                    }
                    break;
                case 2:
                    if (acc.UsdBalance <= 0)
                    {
                        Console.WriteLine($"{acc.Name} не имеет денег на счету для вывода");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Введите сумму которую хотите вывести: ");
                        withd = int.Parse(Console.ReadLine());
                        if (withd > withdrawusdmaxlimit)
                        {
                            Console.WriteLine("Нельзя вывести более 1.000 $");
                            break;
                        }
                        else if (withd <= acc.UsdBalance)
                        {
                            if (withd < withdrawusdminlimit)
                            {
                                Console.WriteLine("Нельзя вывести меньше 50$");
                                break;
                            }
                            if (withd < withdrawusdmaxlimit)
                            {
                                acc.UsdBalance -= withd;
                                Console.WriteLine($"{acc.Name} - успешно выведено {withd} $");
                                acc.ShowInfo();
                            }
                        }
                        else if (answer < withdrawusdminlimit)
                        {
                            Console.WriteLine("Нельзя вывести меньше 50 $ .");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"У {acc.Name} нет столько $ на счету для вывода");
                            
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    break;
            } 
        }
        public void Transaction(AccountMethods accSeller, AccountMethods accGetter)
        {
            Console.WriteLine($"Лимит для перевода на рублевой счёт - {rubmaxtransaction} р. долларовый счёт - {usdmaxtransaction} $ ");
            Console.WriteLine("С какого счёта вы хотите совершить перевод? 1 - с рублевого счёта; 2 - с долларового счёта");
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (accSeller.RubBalance <= 0)
                    {
                        Console.WriteLine($"У {accSeller.Name} нет денег на счёту для транзакции!");
                    }
                    else
                    {
                        Console.Write("Введите сумму для транзакции: ");
                        double transsum = double.Parse(Console.ReadLine());
                        if (transsum > accSeller.RubBalance)
                        {
                            Console.WriteLine($"{accSeller.Name} не имеет {transsum} р. для транзакции");
                        }
                        else
                        {
                            if (transsum < rubmaxtransaction)
                            {
                                accSeller.RubBalance -= transsum;
                                accGetter.RubBalance += transsum;
                                Console.WriteLine($"{accGetter.Name} успешно получил {transsum} р.");
                            }
                            else if (transsum > rubmaxtransaction)
                            {
                                Console.WriteLine("Превышен лимит для перевода!");
                            }
                        }
                    }
                    break;
                case 2:
                    if (accSeller.UsdBalance <= 0)
                    {
                        Console.WriteLine($"У {accSeller.Name} нет денег на счёту для транзакции!");
                    }
                    else
                    {
                        Console.Write("Введите сумму для транзакции: ");
                        double transsum = double.Parse(Console.ReadLine());
                        if (transsum > accSeller.UsdBalance)
                        {
                            Console.WriteLine($"{accSeller.Name} не имеет {transsum} для транзакции");
                        }
                        else
                        {
                            if (transsum < usdmaxtransaction)
                            {
                                accSeller.UsdBalance -= transsum;
                                accGetter.UsdBalance += transsum;
                                Console.WriteLine($"{accGetter.Name} успешно получил {transsum} $");
                            }
                            else if (transsum > usdmaxtransaction)
                            {
                                Console.WriteLine("Превышен лимит для перевода!");
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.start();
                    break;

            }
            
        }
        public void RubConvertation(AccountMethods acc)
        {
            Console.Write("Введите сумму для конвертации в рублях: ");
            double answer = double.Parse(Console.ReadLine());
            if (answer > acc.RubBalance)
            {
                Console.WriteLine($"У {acc.Name} нет столько money в рублях!");
                Info.start();
            }
            else
            {
                double sum;
                sum = answer / wellrate;
                int sum1 = Convert.ToInt32(sum);
                acc.UsdBalance += sum1;
                double sum2 = Convert.ToDouble(sum1);
                double F = sum - sum2;
                acc.RubBalance += F * wellrate;
                acc.RubBalance -= answer;
                Console.WriteLine($"{acc.Name} успешно конвертировал {answer} р. в доллары!");
            }
            
        }
        public void UsdConvertation(AccountMethods acc)
        {
            Console.Write("Введите сумму для конвертации в долларах: ");
            double answer = double.Parse(Console.ReadLine());
            if (answer > acc.UsdBalance)
            {
                Console.WriteLine($"У {acc.Name} нет столько money в долларах!");
                Info.start();
            }
            else
            {
                double sum;
                sum = answer * wellrate;
                int sum1 = Convert.ToInt32(sum);
                acc.RubBalance += sum1;
                double sum2 = Convert.ToDouble(sum1);
                acc.UsdBalance -= answer;
                Console.WriteLine($"{acc.Name} успешно конвертировал {answer} $ в рубли!");
            }
        }
        void IEmployeOperations.NameChange(AccountMethods acc)
        {
            Console.WriteLine($"{acc.Id} Текущее имя {acc.Name}");
            Console.Write("Введите новое имя: ");
            string answer = Console.ReadLine();
            acc.Name = answer;
            Console.WriteLine($"Успешно! Id: {acc.Id} Текущее имя: {acc.Name}");
        }

        void IEmployeOperations.BirthDateChange(IEmployeOperations acc)
        {
            
        }

        void IEmployeOperations.RateChange()
        {
            
        }

        void IEmployeOperations.UsdWithdChange()
        {
            
        }

        void IEmployeOperations.RubWithdChange()
        {
            
        }

        void IEmployeOperations.UsdDepChange()
        {
            
        }

        void IEmployeOperations.RubDepChange()
        {
            
        }

        void IEmployeOperations.TransactionChange()
        {
            
        }

        void IEmployeOperations.list(IEmployeOperations acc)
        {
            Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
        }

        void IEmployeOperations.AgeInput(AccountMethods acc)
        {
            if (acc.Age > 0)
            {
                Console.WriteLine();
            }
            else if (acc.Age == 0)
            {
                Console.Write($"Введите дату рождения {acc.Name}: ");
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
                            acc.DateBirth += date;
                            acc.Age += DateTime.Now.Year - acc.DateBirth;
                            break;
                        }
                    }
                }
                else if (date > 1900 || date < 2021)
                {
                    acc.DateBirth += date;
                    acc.Age += DateTime.Now.Year - acc.DateBirth;
                }
                Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
            }
            
        }
    }
}
