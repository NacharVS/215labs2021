﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    interface IOperationClient
    {
        public void Showinfo(Account acc);
        public void ShowProfit(Account account, int months);
        public void Withdraw(Account account);
        public void Transaction(Account accSeller, Account accGetter);
        public void Deposit(Account account);
        public void Convertation(Account account);
        void ChangeName(Account account);

    }
}