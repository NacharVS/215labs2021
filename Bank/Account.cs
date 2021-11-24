using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {
        private string _name;
        private double _balance;
        private int _id;
        private int _yearOfBirth;


        public static double rate = 0.09;

        public string Name { get => _name; set => _name = value; }
        public double Balance
        {   
            get 
            {return _balance;}
            set 
            { 
                if (value < 0)
                    Console.WriteLine("Баланс не может быть отрицательным.");

                else 
                {
                    _balance = value;
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


        public Account(string name, double balance, int yearOfBirth, int id)
        {
            Age = yearOfBirth;
            Id = id;
            Name = name;
            Balance = balance;
        }



      
    }
}
