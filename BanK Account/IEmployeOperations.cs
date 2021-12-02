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
        void NameChange(AccountMethods acc, string old);
        void list(IEmployeOperations acc);
        void AgeInput(AccountMethods acc);
        void RateChange(IEmployeOperations ac);
        void RubTransactionChange(IEmployeOperations ac);
        void UsdDepoLimitChange(IEmployeOperations ac);
        void RubDepoLimitChange(IEmployeOperations ac);
        void RubWithLimitChange(IEmployeOperations ac);
        void UsdwithLimitChange(IEmployeOperations ac);
        void UsdTransactionChange(IEmployeOperations ac);
    }
}
