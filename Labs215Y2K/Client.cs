using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Client : Account, Client1
    {
        public Client(string Name, double BalanceRubs, string ID, int DataOfBirth, double BalanceDollar) : base(Name, BalanceRubs, ID, DataOfBirth, BalanceDollar)
        {
        }
    }
}
