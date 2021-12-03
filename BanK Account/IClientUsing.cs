using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    interface IClientUsing
    {
        string Name { get; set; }
        double RubBalance { get; set; }
        double UsdBalance { get; set; }
        int Id { get; set; }
        int Age { get; set; }
        int DateBirth { get; set; }
        void ShowInfo(IClientUsing acc);
        void AgeInput(IClientUsing acc);
        void ShowProfit(IClientUsing acc, int month);
        void Withdraw(IClientUsing acc, int withd);
        void Deposit(IClientUsing acc, int depo);
        void Transaction(IClientUsing accSeller, IClientUsing accGetter);
        void RubConvertation(IClientUsing acc);
        void UsdConvertation(IClientUsing acc);



    }
}
