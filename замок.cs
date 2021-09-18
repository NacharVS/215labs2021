using System;

namespace дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int mama = int.Parse(Console.ReadLine());
            for (int a = 0; a <= 9; a++)
            {
                for (int b = a + 1; b <= 9; b++)
                {
                    for (int c = b + 1; c <= 9; c++)
                    {
                        if ((a + b + c == mama) && (a != b) && (a != c) && (b != c))
                        {
                            Console.Write(a);
                            Console.Write(b);
                            Console.WriteLine(c);
                        }
                        else Console.Write("");
                    }
                }
            }
        }
    }
}