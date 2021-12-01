using System;
using System.Collections.Generic;
using System.Text;

namespace BANK
{
    interface IUserOperations
    {
        public void Showinfo();
        public void ShowProfit(int months);
        public void Withdraw(Account account);
        public void Transaction(Account accSeller, Account accGetter);
        public void Deposit(Account account);
        public void Convertation(Account account);
    }
}
