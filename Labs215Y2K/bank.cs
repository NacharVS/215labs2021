using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class bank
    {
        class Employee : Person
        {
            private static int zp = 35000;
            private static double zp_balans = 0;
            public static void employee()
            {
                Console.WriteLine($"Сегодняшнее число: {DateTime.Now}");
                if (DateTime.Now.Day > 28)
                {
                    zp_balans += zp;
                    Console.WriteLine($"Ваша зарплата {zp_balans} рублей");

                }
                else
                {
                    Console.WriteLine($"Зарплата начислится 28 го числа");
                }
            }
        }
    }
}
