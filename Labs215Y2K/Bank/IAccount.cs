using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    interface IAccount
    {

        public void ShowInfo(Account acc);
        public void ShowProfit(Account acc, int mouths);
        public void Withdraw(Account acc);
        public void Transaction(Account acc, Account accGetter);
        public void Deposit(Account acc);

    }
}
