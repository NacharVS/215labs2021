using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class User : Account
    {
        public User(string name, double balanceRUB, double balanceUSD, int yearOfBirth, int id, string password) : base(name, balanceRUB, balanceUSD, yearOfBirth, id, password)
        {
        }
    }
}
