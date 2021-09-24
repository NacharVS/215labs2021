using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class doorcodecombination
    {
        public static void ex1()
        {
            int a = int.Parse(Console.ReadLine());
            for (int x1 = 0; x1 <= 9; x1++)
            {
                for (int x2 = x1 + 1; x2 <= 9; x2++)
                {
                    for (int x3 = x2 + 1; x3 <= 9; x3++)
                    {
                        if ((x1 + x2 + x3 == a) && (x1 != x2) && (x1 != x3) && (x2 != x3))
                        {
                            Console.Write(x1);
                            Console.Write(x2);
                            Console.WriteLine(x3);
                        }
                        else Console.Write("");
                    }
                }
            }
        }
    }
}
