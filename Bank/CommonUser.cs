using System;
using System.Collections.Generic;
using System.Text;

namespace BANK
{
    class CommonUser : Account, IUserOperations
    {
        public CommonUser(string name, double balanceRUB, double balanceUSD, int yearOfBirth, int id) : base(name, balanceRUB, balanceUSD, yearOfBirth, id)
        {

        }
        public override void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank for operations with bank account");
        }
    }
}
