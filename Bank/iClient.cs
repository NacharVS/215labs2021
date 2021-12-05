using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface iClient
    {
        string Name { get; set; }
        double RubBalance { get; set; }
        double UsdBalance { get; set; }
        int Id { get; set; }
        int Age { get; set; }
        int DateBirth { get; set; }
        void AgeInput(List<iClient> accounts, int id);
        void ShowInfo(List<iClient> accounts, int id);
        void ShowProfit(List<iClient> accounts, int month, int id);
        void Withdraw(List<iClient> accounts, int withd, int id,int newid);
        void NameChange(List<iClient> accounts, string old);
        void RateChange(List<iClient> accounts);
        void RubDepoLimitChange(List<iClient> accounts);
        void UsdDepoLimitChange(List<iClient> accounts);
        void RubWithLimitChange(List<iClient> accounts);
        void UsdwithLimitChange(List<iClient> accounts);
        void RubTransactionChange(List<iClient> accounts);
        void UsdTransactionChange(List<iClient> accounts);
        void Depostit(List<iClient> accounts, int depo, int id, int newid);
        void Transation(List<iClient> accounts, int id, int id2, int newid);
        void RubConvertation(List<iClient> accounts, int id);
        void UsdConvertation(List<iClient> accounts, int id);
    }
}
