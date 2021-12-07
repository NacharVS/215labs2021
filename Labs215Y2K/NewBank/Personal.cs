using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.NewBank
{
    class Personal
    {
        private string _name;
        private string _surname;
        private int _age;
        private double _balance;
        private int _id;
        private double _dollarbalance;

        public Personal(string name, string surname, int age, double balance, double dollarbalance, int id)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _balance = balance;
            _id = id;
            _dollarbalance = dollarbalance;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public double Balance { get => _balance; set => _balance = value; }
        public int Id { get => _id; set => _id = value; }
        public double Dollarbalance { get => _dollarbalance; set => _dollarbalance = value; }
        public int Age { get => _age; set => _age = value; }

        public static double rate = 0.09;
        public static double dollarcurse = 74.63;
    }
}
