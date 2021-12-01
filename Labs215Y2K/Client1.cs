using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    interface Client1
    {
        public void ShowInfo();
        public void Deposit(Account acc, double money);
        public void Withdraw(Account acc, double money);
        public void Transaction(Account accSeller, Account accGetter, double money, int valute);
        public void ShowProfit(Account acc, int month);
        public void Conversation(Account acc);
    }
}
