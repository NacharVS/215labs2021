using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface iClient
    {
        void AgeInput(List<Info> accounts);
        void ShowInfo(List<Info> accounts);
        void ShowProfit(List<Info> accounts, int month, List<iClient> accounts2);
        void Withdraw(List<Info> accounts, int withd, List<iClient> accounts2);
    }
}
