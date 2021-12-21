using Labs215Y2K;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    interface IEmployer
    {
        public void ChangeName(Account account);
        public void ChangeRate();
        public void ChangeYear(Account account);
    }
}