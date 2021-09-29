using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class simplecalculator
    //простой калькулятор
    {
        public static void ex()
        {
            double num1, num2;
            string znak;
            Console.WriteLine("Введите первое число");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Какой способ: '-' '+' '*' '/' '^' ");
            znak = Console.ReadLine();
            switch (znak)
            {
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "^":
                    Console.WriteLine(Math.Pow(num1, num2));
                    break;
                default:
                    Console.WriteLine("Не могу выполнить действие");
                    break;
            }
        }
    }
}
