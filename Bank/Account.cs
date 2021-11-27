using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account: IEmployer, IUserOperations
    {
        private string _name;
        private double _balanceRUB;
        private double _balanceUSD;
        private int _id;
        private int _yearOfBirth;
        public static double currencyCourse = 74.37;


        private static double _rate = 0.09;

        public string Name { get => _name; set => _name = value; }
        public double BalanceRUB
        {   
            get 
            {return _balanceRUB;}
            set 
            { 
                if (value < 0)
                    Console.WriteLine("Баланс не может быть отрицательным.");

                else 
                {
                    _balanceRUB = value;
                }
            }           
        }
        public double BalanceUSD
        {
            get
            { return _balanceUSD; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Баланс не может быть отрицательным.");

                else
                {
                    _balanceUSD = value;
                }
            }
        }

        public int Id
        {
            get
            { return _id; }
            set
            {
                if (value < 0)
                    Console.WriteLine("ID пользователя не может быть отрицательным.");

                else
                {
                    _id = value;
                }
            }
        }
        public int Age
        {
            get
            { return _yearOfBirth; }
            set
            {
                if (value > 1900 & value <= DateTime.Now.Year)
                    _yearOfBirth = DateTime.Now.Year - value;

                else
                {
                    Console.WriteLine("Некорректный год рождения.");
                }
            }
        }

        public static double Rate { get => _rate; set => _rate = value; }

        public Account(string name, double balanceRUB, double balanceUSD, int yearOfBirth, int id)
        {
            Age = yearOfBirth;
            Id = id;
            Name = name;
            BalanceRUB = balanceRUB;
            BalanceUSD = balanceUSD;
        }

        public void Withdraw(Account account)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите снять");
            double cash = double.Parse(Console.ReadLine());
            if (cash >= 0 & account.BalanceRUB >= cash)
                account.BalanceRUB -= cash;
            Console.WriteLine($"{cash} рублей было снято со счёта.");
        }

        public void Transaction(Account accSeller, Account accGetter)
        {
            Console.WriteLine($"Введите сумму, которую хотите перевести {accGetter.Name}");
            double money = double.Parse(Console.ReadLine());
            if (accSeller.BalanceRUB >= money)
            {
                accSeller.BalanceRUB -= money;
                accGetter.BalanceRUB += money;
                Console.WriteLine($"Со счёта {accSeller.Name} было переведено {accGetter.Name} {money} рублей");
            }
            else
                Console.WriteLine("Ошибка. На Вашем счету недостаточно средств.");
        }

        public void Deposit(Account account)
        {
            Console.WriteLine("Введите количество денег, которое Вы хотите внести");
            double cash = double.Parse(Console.ReadLine());
            if (cash >= 0)
            {
                account.BalanceRUB += cash;
                Console.WriteLine($"Поздравляем. {cash} рублей было зачислено на Ваш счёт.");
            }
            else
                Console.WriteLine("Введите корректную сумму.");
        }

        public void Convertation(Account account)
        {
            Console.WriteLine("Приветствуем Вас в обменнике.Выберите действие.");
            Console.WriteLine("(1) Обмен РУБЛЕЙ на ДОЛЛАРЫ.");
            Console.WriteLine("(2) Обмен ДОЛЛАРОВ на РУБЛИ.");
            string chose = Console.ReadLine();
            switch (chose)
            {
                case "1":
                    {
                        Console.WriteLine($"Здесь Вы можете обменять свои рубли на доллары по курсу { Account.currencyCourse} рублей за доллар.");
                        Console.WriteLine("Введите сумму, которую хотите конвертировать в доллары.");
                        Console.WriteLine("Мы способны конвертировать только целочисленную сумму.Остаток вернётся на Ваш рублёвый баланс.");
                        double change = int.Parse(Console.ReadLine());
                        if (account.BalanceRUB >= change)
                        {
                            account.BalanceRUB -= change;
                            double calculate = 0;
                            calculate = change / Account.currencyCourse;


                            change %= Account.currencyCourse;
                            calculate = Convert.ToInt32(calculate);
                            account.BalanceUSD += calculate;

                            account.BalanceRUB += change;
                            Console.WriteLine($"Итого в долларах выйдет { calculate} $. Остальные средства - { change} руб будут зачислены на Ваш рублёвый баланс.");
                        }
                        else

                            Console.WriteLine("На Вашем счету недостаточно средств для совершения данной операции.");

                    }
                    break;
                case "2":
                    {
                        Console.WriteLine($"Здесь Вы можете обменять свои доллары на рубли по курсу { 1 / Account.currencyCourse} рублей за доллар.");
                        Console.WriteLine("Введите сумму, которую хотите конвертировать в рубли.");
                        Console.WriteLine("Мы способны конвертировать только целочисленную сумму.Остаток вернётся на Ваш долларовый баланс.");
                        double change = double.Parse(Console.ReadLine());
                        if (account.BalanceUSD >= change)
                        {
                            double test;
                            double test2;
                            account.BalanceUSD -= change;
                            double calculate = 0;
                            calculate = change * Account.currencyCourse;


                            test2 = Math.Round(calculate, 2);
                            calculate = Convert.ToInt32(calculate);
                            test = calculate - test2;

                            test /= Account.currencyCourse;



                            account.BalanceUSD += calculate;

                            account.BalanceRUB += test;
                            Console.WriteLine($"Итого в рублях выйдет { calculate} руб. Остальные средства - {test}  долларов будут зачислены на Ваш долларовый баланс.");
                        }
                        else
                            Console.WriteLine("На Вашем счету недостаточно средств для совершения данной операции.");
                    }
                    break;
            }
        }

        public void Showinfo(Account acc)
        {
            Console.WriteLine($"{acc.Name} возраст: {acc.Age}  [{acc.Id} ID] - {acc.BalanceRUB} рублей");
        }

        public void ShowProfit(Account acc, int months)
        {
            for (int i = 0; i < months; i++)
            {
                acc.BalanceRUB += acc.BalanceRUB * Rate;
            }
            Console.WriteLine($"Ваш баланс будет составлять: {acc.BalanceRUB}.");
        }

        public void ChangeName(Account account)
        {
            Console.WriteLine("Введите новое имя клиента");
            account.Name = Console.ReadLine();
        }
        public void ChangeRate()
        {
            Console.WriteLine("Введите новую ставку (месячную)");
            Rate = int.Parse(Console.ReadLine());
        }
        public void ChangeYear(Account account)
        {
            Console.WriteLine("Введите новый год рождения пользователя");
            account.Age = int.Parse(Console.ReadLine());
        }
    }
}
