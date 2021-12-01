using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Account
    {

        private string _Name;
        private double _BalanceRubs;
        private string _ID;
        private int _DataOfBirth;
        private double _BalanceDollar;

        private static double rate = 0.09;
        private static double curs = 74.4;

        public Account(string Name, double BalanceRubs, string ID, int DataOfBirth, double BalanceDollar)
        {
            this._Name = Name;
            this._BalanceRubs = BalanceRubs;
            this._ID = ID;
            this._DataOfBirth = DataOfBirth;
            this._BalanceDollar = BalanceDollar;

        }

        public string NAME
        {
            get
            { return _Name; }
        }

        public double BALanceRubs
        {
            get { return _BalanceRubs; }
        }

        public string ID1
        {
            get { return _ID; }
        }

        public int DATAOfBirth
        {
            get { return _DataOfBirth; }
        }

        public double BALANCeDollar
        {
            get { return _BalanceDollar; }
        }



        public void ShowInfo()
        {
            System.Console.WriteLine($"{NAME} - {BALanceRubs} рублей - {BALANCeDollar} долларов, год рождения - {DATAOfBirth}");
        }

        public void Deposit(Account acc, double money)
        {
            acc._BalanceRubs += money;
            Console.WriteLine($"На счет было зачислено {money} рублей.");
        }

        public void Withdraw(Account acc, double money)
        {
            acc._BalanceRubs -= money;
            Console.WriteLine($"С счета было списано {money} рублей.");
        }

        public void Transaction(Account accSeller, Account accGetter, double money, int valute)
        {
            if (valute == 1)
            {
                accSeller._BalanceRubs -= money;
                accGetter._BalanceRubs += money;
                Console.WriteLine($"С счета {accSeller._Name} было переведено {money} рублей на счет {accGetter._Name}.");
            }
            if (valute == 2)
            {
                accSeller._BalanceDollar -= money;
                accGetter._BalanceDollar += money;
                Console.WriteLine($"С счета {accSeller._Name} было переведено {money} долларов на счет {accGetter._Name}.");
            }
        }
        public void ShowProfit(Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc._BalanceRubs += acc._BalanceRubs * rate;
                acc._BalanceDollar += acc._BalanceDollar * rate;
            }
        }
        public void Conversation(Account acc)
        {
            Console.WriteLine($"Выберите в какую валюту хотите конвертировать:");
            Console.WriteLine($"В рубли(1)");
            Console.WriteLine($"В доллары(2)");
            int valute = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите сумму, которую хотите конвертировать");
            double money = double.Parse(Console.ReadLine());
            if (valute == 1)
            {
                acc._BalanceDollar -= money;
                acc._BalanceRubs += money * curs;
            }
            if (valute == 2)
            {
                acc._BalanceRubs -= money;
                acc._BalanceDollar += money / curs;
            }
        }

    }
}
