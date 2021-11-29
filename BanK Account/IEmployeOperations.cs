using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    interface IEmployeOperations
    {
        void NameChange(AccountMethods acc);
        void BirthDateChange(IEmployeOperations acc);
        void RateChange();
        void UsdWithdChange();
        void RubWithdChange();
        void UsdDepChange();
        void RubDepChange();
        void TransactionChange();

    }
}
