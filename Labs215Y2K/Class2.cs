using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Account
    {
        private string _name;
        private int _balance;
        private int _age;
        private string _id;
        private int _yearOfBirth;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                _name = value;
            }
        }
        public int Balance
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
        public int Age
        {
            get
            {

                return _age;
            }
            set
            {
                if (value > 1910 & value <= DateTime.Now.Year)
                {
                    _age = value = DateTime.Now.Year - value;
                }
                _age = value;

            }
        }
        public string Id
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
        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;

            }
            set
            {
                _yearOfBirth = value;
            }
        }



    }

}
