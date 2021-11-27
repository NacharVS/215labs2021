﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.Bank
{
    interface IClientOperation
    {
        double Balance { get; set; }
        double DollarBalance { get; set; }
        int UserId { get; set; }
        void Info(Account acc);
        void ShowInfo(Account acc);
        void ShowProfit(Account acc, int mountcounter);
        void Deposit(Account acc);
        void Withdraw(Account acc);
        void Transaction(Account acc, Account accSeller, Account accGetter);
        void MoneyConvert(Account acc);
    }
}
