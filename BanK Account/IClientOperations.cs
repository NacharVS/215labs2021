using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    interface IClientOperations  
    {
        void ConvertOp(AccountMethods acc);
        void deposit(IClientOperations acc);
        void withdraw();
        void trans();
    }
}
