using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    interface IEmployeOperations 
    {
        string Name { get; set; }
        double Rubbalance { get; set; }
        double Usdbalance { get; set; }
        int Id { get; set; }
        int Age { get; set; }
        int DateBirth { get; set; }
        void NameChange(AccountMethods acc);
        void BirthDateChange(IEmployeOperations acc);
        void RateChange();
        void UsdWithdChange();
        void RubWithdChange();
        void UsdDepChange();
        void RubDepChange();
        void TransactionChange();
        void list(IEmployeOperations acc);
        void AgeInput(AccountMethods acc);
    }
}
