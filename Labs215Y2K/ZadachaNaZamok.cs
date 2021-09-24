using System;

namespace ZadaChaNaZaMok
{
    public class ZamokClass
    {
        public static void Zamok()
        {
            Console.WriteLine("Write your sum...");
            int sum = int.Parse(Console.ReadLine());

            if ((sum > 0) && (sum < 25))
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int l = i + 1; l < 10; l++)
                    {
                        for (int j = l + 1; j < 10; j++)
                        {
                            if ((i + l + j) == sum)
                            {
                                if ((i != l) && (l != j) && (j != i))
                                {
                                    Console.WriteLine(i + "" + l + "" + j);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Number must be between 1 - 25");
                Console.WriteLine();
            }
        }
    }
}
