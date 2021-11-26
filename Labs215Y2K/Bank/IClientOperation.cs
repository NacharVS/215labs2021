using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.Bank
{
    interface IClientOperation
    {
        double Balance { get; set; }
        double DollarBalance { get; set; }
        int UserId { get; set; }
        void Info(IClientOperation acc);
        void ShowInfo(IClientOperation acc);
        void ShowProfit(IClientOperation acc, int mountcounter);
        void Deposit(IClientOperation acc);
        void Withdraw(IClientOperation acc);
        void Transaction(IClientOperation acc, IClientOperation accSeller, IClientOperation accGetter);
        void MoneyConvert(IClientOperation acc);
    }
}
