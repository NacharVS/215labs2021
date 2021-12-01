using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Imploer : Account, Imploer1
    {
        public Imploer(string Name, double BalanceRubs, string ID, int DataOfBirth, double BalanceDollar) : base(Name, BalanceRubs, ID, DataOfBirth, BalanceDollar)
        {
        }
    }
}
