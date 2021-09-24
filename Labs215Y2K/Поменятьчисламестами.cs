using System;
namespace ПереворотЧисла
{
    class Поменятьчисламестами
    {
        static void число(string[] args)
        {

            int a = 5, b = 2;
            a = a + b;
            b = a - b;
            a = a - b;
            string resulta = "a=";
            string resultb = "b=";
            Console.WriteLine(resulta + a);
            Console.WriteLine(resultb + b);
        }
    }
}
