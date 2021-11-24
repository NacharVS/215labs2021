using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods
    {
        private  string _name;
        private  double _balance;
        private int _id;
        private static double rate = 0.09;
        private int[] dateofbirth = new int[3];
        private int[] finalage = new int[3];
        
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
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
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

        public void AgeInput()
        {
            Console.Write($"Введите год рождения {Name} : ");
            int date = int.Parse(Console.ReadLine());
            if (date < 1900 || date > 2021)
            {
                Console.WriteLine();
                while (date < 1900 || date > 2021)
                {
                    date = 0;
                    Console.Write("Неверный год рождения! Введите заново: ");
                    date = int.Parse(Console.ReadLine());
                    if (date > 1900 && date < 2021)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            dateofbirth[i] += date;
                            break;
                        }
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    dateofbirth[i] += date;
                }
            }
            
        }
        public void ShowInfo()
        {
            for (int i = 0; i < 1; i++)
            {
                finalage[i] = DateTime.Now.Year - dateofbirth[i];
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"id: {Id} Имя: {Name} Возраст: {finalage[i]} Баланс = {Balance}");
            }
        }

        public void ShowProfit(AccountMethods acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.Balance += acc.Balance * rate;
            }
        }

        public void Deposit(AccountMethods acc, int depo)
        {
            Console.WriteLine();
            Console.WriteLine("Введите сумму которую хотите добавить");
            depo = int.Parse(Console.ReadLine());
            if (depo < 0)
            {
                Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
            }
            else
            {
                acc.Balance += depo;
                Console.WriteLine($"{acc.Name} - начислено {depo}");
            }
        }

        public void Withdraw(AccountMethods acc, int withd)
        {
            if (acc.Balance <= 0)
            {
                Console.WriteLine($"{acc.Name} не имеет денег на счету для вывода");
            }
            else
            {
                Console.WriteLine();
                Console.Write("Введите сумму которую хотите вывести: ");
                withd = int.Parse(Console.ReadLine());
                if (withd <= acc.Balance)
                {
                    acc.Balance -= withd;
                    Console.WriteLine($"{acc.Name} - успешно выведено {withd}");
                    acc.ShowInfo();
                    Info.start();
                }
                else
                {
                    Console.WriteLine($"У {acc.Name} нет столько денег на счету для вывода");
                    Info.start();
                }

            }
        }

        public static void Transaction(AccountMethods accSeller, AccountMethods accGetter)
        {
            if (accSeller.Balance <= 0)
            {
                Console.WriteLine($"У {accSeller.Name} нет денег на счёту для транзакции!");
            }
            else
            {
                Console.Write("Введите сумму для транзакции: ");
                double transsum = double.Parse(Console.ReadLine());
                if (transsum > accSeller.Balance)
                {
                    Console.WriteLine($"{accSeller.Name} не имеет {transsum} для транзакции");
                }
                else
                {
                    accSeller.Balance -= transsum;
                    accGetter.Balance += transsum;
                    Console.WriteLine($"{accGetter.Name} успешно получил {transsum}");
                }
            }
        }
    }
}
