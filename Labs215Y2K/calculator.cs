using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class calculator
    {
        public static void ex4()
        {
            int a, b;

            float result;
            Console.WriteLine("enter 1st number= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие");
            string opperation = Console.ReadLine();
            switch (opperation)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine(result);
                    break;
                case "%":
                    result = a % b;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Я не знаю такой операции");
                    break; ;
            }
        }
    }
}