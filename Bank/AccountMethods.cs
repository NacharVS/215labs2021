using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class AccountMethods
    {
        private string _name;
        private double _rubbalance;
        private double _usdbalance;
        private int _id;
        private static double rate = 0.09;
        private int _datebirth;
        private int _age;
        private static double wellrate = 76;
        private static double withdrawrubmaxlimit = 30000;
        private static double withdrawrubminlimit = 100;
        private static double withdrawusdmaxlimit = 1000;
        private static double withdrawusdminlimit = 50;
        private static double depositrubminlimit = 50;
        private static double depositrubmaxlimit = 100000;
        private static double depositusdminlimit = 10;
        private static double depositusdmaxlimit = 5000;
        private static double rubmaxtransaction = 50000;
        private static double usdmaxtransaction = 2500;

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
    }
}
