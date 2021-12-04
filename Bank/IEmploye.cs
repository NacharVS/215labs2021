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
        void RubTransactionChange(List<Info> accounts);
        void UsdDepoLimitChange(List<Info> accounts);
        void RubDepoLimitChange(List<Info> accounts);
        void RubWithLimitChange(List<Info> accounts);
        void UsdwithLimitChange(List<Info> accounts);
        void UsdTransactionChange(List<Info> accounts);
    }
}
