using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.NewBank
{
    class BankAccounts
    {
        private string _name;
        private int _age;
        private double _balance;
        private int _id;
        private double _dollarbalance;

        public BankAccounts(string name, int age, double balance,double dollarbalance, int id)
        {
            this._name = name;
            this._age = age;
            this._balance = balance;
            this._id = id;
            this._dollarbalance = dollarbalance;
        }

        public string Name { get => _name; set => _name = value; }
        public double Balance { get => _balance; set => _balance = value; }
        public int Id { get => _id; set => _id = value; }
        public double Dollarbalance { get => _dollarbalance; set => _dollarbalance = value; }
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

        public static double rate = 0.09;
        public static double dollarcurse = 74.63;

    }
}