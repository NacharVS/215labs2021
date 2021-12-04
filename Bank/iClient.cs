using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface iClient
    {
        void AgeInput(List<Info> accounts);
        void ShowInfo(List<Info> accounts);
    }
}
