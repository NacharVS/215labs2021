using System;

namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            MaxValue = 10;
            MinValue = 0;
            ArrayOperations.ArrayGeneration(array);
        }
    }
}
