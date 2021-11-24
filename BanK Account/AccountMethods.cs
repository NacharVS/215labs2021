using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods
    {
        private static string _name;
        private static double _balance;
        private static int _id;
        private static double rate = 0.09;
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
        

        public void ShowInfo()
        {
            System.Console.WriteLine($"id: {_id} {_name} - {_balance}");
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
                accSeller.Balance -= transsum;
                accGetter.Balance += transsum;
                Console.WriteLine($"{accGetter.Name} успешно получил {transsum}");
            }
        }
    }
}
