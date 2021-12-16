using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShopNew1.start();
            string a = "BBlat";
            for (int i = a.Length -1;i >=0;i--)
            {
                Console.Write($"{a[i]}");
            }
            a = a.Remove(0, 2);
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}
