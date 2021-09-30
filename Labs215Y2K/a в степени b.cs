using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class a_в_степени_b
    {
        public static void Ex1() 
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            if (b == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= b; i++)
                {
                    a = a * c;
                }
                Console.WriteLine(a);
            }
        }
    }
}
