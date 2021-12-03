using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface IEmploye
    {
        string Name { get; set; }
        double RubBalance { get; set; }
        double UsdBalance { get; set; }
        int Id { get; set; }
        int Age { get; set; }
        int DateBirth { get; set; }
        void NameChange(List<Info> accounts, string old);
        void AgeInput(List<Info> accounts);
        void RateChange(List<Info> accounts);
        void RubTransactionChange(IEmploye ac);
        void UsdDepoLimitChange(IEmploye ac);
        void RubDepoLimitChange(IEmploye ac);
        void RubWithLimitChange(IEmploye ac);
        void UsdwithLimitChange(IEmploye ac);
        void UsdTransactionChange(IEmploye ac);
    }
}
