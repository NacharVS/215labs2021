using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class _01
    {
        public static void array78()
        {
            int[,] c = new int[5, 5];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for ( int j = 0; j < c.GetLength(1); j++)
                {
                    if ( i == 0)
                    {
                        c[i, 0] = 1;
                        c[i, 1] = 2;
                        c[i, 2] = 3;
                        c[i, 3] = 4;
                        c[i, 4] = 5;
                        Console.Write($"{c[i, j]}");
                    }
                }
            }
        }
    }
}
