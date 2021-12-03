using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class BankAccounts
    {
        private string _name;
        private int _age;
        private double _balance;
        private int _id;
        private double _dollarbalance;

        public BankAccounts(string name, int age, double balance, double dollarbalance, int id)
        {
            _name = name;
            _age = age;
            _balance = balance;
            _id = id;
            _dollarbalance = dollarbalance;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 1900 || value >= DateTime.Now.Year)
                {
                    Console.WriteLine("Вы ввели неверный год рождения");
                }
                else
                {
                    Age = DateTime.Now.Year - value;
                }
            }
        }

        public double Balance { get => _balance; set => _balance = value; }
        public int Id { get => _id; set => _id = value; }
        public double Dollarbalance { get => _dollarbalance; set => _dollarbalance = value; }


    }
}
