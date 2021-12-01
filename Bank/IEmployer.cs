using System;
using System.Collections.Generic;
using System.Text;

namespace BANK
{
    interface IEmployer
    {
        public void ChangeName(Account account);
        public void ChangeRate();
        public void ChangeYear(Account account);
    }
}
