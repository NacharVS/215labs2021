using System;
using System.Linq;

namespace Deletor
{
    public class MainClass
    {
        public static void Main()
        {
            int[] FirstArray = new int[] { 1, 2, 3, 2 };
            int[] SecondArray = { 1, 3, 5, 2 };
            var result = FirstArray.Distinct().ToArray();
            Console.WriteLine(result);
            SecondArray.Distinct().ToArray();
            for (int i = 0; i < FirstArray.Length; i++)
            {
                Console.WriteLine(result);

            }
        }
    }
}