using System;
namespace flip
{
    class flipnum
    {
        public static void ex7()
        {
            int result = 0;
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                result = num % 10;
                num = num / 10;
                Console.Write(result);
            }


        }
    }
}
