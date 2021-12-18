using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Base
    {

        static void Main(string[] args)
        {

            Random z = new Random();
            int test = 1000;
            int yellow = 0;
            int red = 0;
            while (true)
            {
                test--;
                if (z.Next(0, 2) == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    yellow++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    red++;
                }
                Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "АХАХАХАХ КАК СМЕШНО ПРОСТО КАПЕЦ" + "\t");
                if (test == 0)
                {

                    break;
                }

            }
            Console.WriteLine("Yellow: " + yellow);
            Console.WriteLine("Red: " + red);
            Console.ReadKey();


        }
    }
}
