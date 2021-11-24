using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods
    {
        private  string _name;
        private  double _balance;
        private  int _id;
        private int _datebirth;
        public int _finalage;
        private static double rate = 0.09;
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Console.Write("Введите имя: ");
                _name = Console.ReadLine();
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
        public int DateBirth
        {
            get
            {
                return _datebirth;
            }
            set
            {
                Console.Write("Введите год рождения: ");
                _datebirth = int.Parse(Console.ReadLine());
                
            }
        }
        public void proverka()
        {
            if (DateBirth < 1900 && DateBirth > 2021)
            {
                Console.WriteLine("нверно");
               
            }
        }
        public int Finalage
        {
            get
            {
                return _finalage;
            }
            set
            {
                _finalage = DateTime.Now.Year - DateBirth;
            }
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"id: {_id} Имя: {_name} Возраст: {_finalage} Баланс = {_balance}"); 
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
