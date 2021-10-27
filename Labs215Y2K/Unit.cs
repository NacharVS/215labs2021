using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Unit
    {
        private string _typeUnit;
        private static int _currenthealth;
        private static int _maxhealth;
        private int _mindamage;
        private int _maxdamage;
        public string TypeUnit
        {
            get
            {
                return _typeUnit;

            }
            set
            {
                _typeUnit = value;
            }
        }
        public static int Currenthealth
        {
            get
            {
                return _currenthealth;
            }
            set
            {
                _currenthealth = value;
            }
        }
        public static int Maxhealth
        {
            get
            {
                return _maxhealth;
            }
            set
            {
                _maxhealth = value;
            }
        }
        public int Mindamage
        {
            get
            {
                return _mindamage;
            }
            set
            {
                _mindamage = value;
            }
        }
        public int Maxdamage
        {
            get
            {
                return _maxdamage;
            }
            set
            {
                _maxdamage = value;
            }
        }
         public void Move()
        {
            Console.WriteLine($" {TypeUnit} is moving");
        }
    }
}
