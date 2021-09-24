using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧатБот
{
    class Бот
    {
        static void Чатбот(string[] args)
        {
            Console.WriteLine("Hello, my name is Rick.And yours?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);
            Console.ReadLine();
            Console.WriteLine("Do you want to play the game guess the number ?");
            Console.WriteLine("Enter 1 - true or 0 - false");
            int answer = int.Parse(Console.ReadLine());
            int count = 0;
            Random rand = new Random();
            int value = rand.Next(0, 20);
            Console.WriteLine("Enter a number from 0 to 20");
            int number = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                while (count <= 20)
                {
                    if (number == value)
                    {
                        Console.WriteLine("Yes!Congratulations, you won");
                        break;
                    }
                    else
                    {
                        count++;
                        if (count == 21)
                        {
                            Console.WriteLine("I'm sorry, but you've wasted all your attempts");
                            break;
                        }
                        Console.WriteLine("No, it's not a mysterious number" + value + "attempt №" + count);
                        value = Convert.ToInt32(Console.ReadLine());
                        {
                            Console.ReadLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("See you soon!");
            }
        }
    }
}
