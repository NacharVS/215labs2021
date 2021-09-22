using System;

namespace abdullin3
{
   
class Program
        {
            static void Main(string[] args)
            {
                int number, result = 0;

                Console.Write("enter number: ");
                number = Int32.Parse(Console.ReadLine());

                while (number > 0)
                {
                    result *= 10;
                    result += number % 10;
                    number /= 10;
                }

                Console.WriteLine(result);

            }
        }
    
}