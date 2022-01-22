using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForDataBase.Data_Base;

namespace ForDataBase.Data_Base
{
    class Program
    {
        static void Main(string[] args)
        {

            Extensions.AddToDataBase();
            //Extensions.EditDocument();
            //Extensions.GetAllFromDataBase();
            //Extensions.SexSort(null);
            Console.ReadKey();
        }
    }
}

