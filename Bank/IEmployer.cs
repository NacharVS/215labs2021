using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IEmployer
    {
        public void ChangeName(Account account);
        public void ChangeRate();
        public void ChangeYear(Account account);
    }
}
