using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForDataBase.Data_Base;

namespace ForDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Extensions.AddToDataBase("Ivan", 33);
            Console.ReadKey();
        }
    }
}
