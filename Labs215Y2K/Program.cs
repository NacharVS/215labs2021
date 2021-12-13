using Labs215Y2K.Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            OperatorOverload obj1 = new OperatorOverload("first", 20);
            OperatorOverload obj2 = new OperatorOverload("second", 10);
            
        
            Console.WriteLine(obj1 < obj2);
        }

        static void Show(double a, double b)
        {
            Console.WriteLine($"balancr changed with {a}, new balance ={b}");
        }
    }
}
