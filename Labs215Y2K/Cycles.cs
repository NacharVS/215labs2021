using System;
using System.Collections.Generic;
using System.Text;

namespace Cycle
{
      static public class Cycles
    {
        public static void Sgrt()
        //Cтепень числа
        { 
            
            Console.WriteLine("Введите число ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Его степень");
            int b = int.Parse(Console.ReadLine());
            int rezult = 1;
            while( b  >  0 )
            {
                b--;
                rezult = rezult * a;
            }
            Console.WriteLine(rezult);
        }
        public static void HackDoor()
            //Подбор Домофона
        {
            Console.WriteLine("Введите число ");
            int summ = int.Parse(Console.ReadLine()); 
            for (int N1 = 0; N1 <= 9; N1++)
            {
                for (int N2 = N1+1 ; N2 <= 9 ; N2++)
                {
                    for (int N3 = N2+1 ; N3 <= 9 ; N3++)
                    {
                        if (N1 + N2 + N3 == summ)
                        {
                            Console.Write(N1);
                            Console.Write(N2);
                            Console.WriteLine(N3);
                        }
                        
                    }
                }
            }
        }
        public static void Reversenubmer()
            //перевеворот числа
        {
            Console.Write("Число"); 
            
            int Number = int.Parse(Console.ReadLine());
            int a;
            while (Number > 0)
            {
                a = Number  %  10;
                Number=Number/ 10;
                Console.Write( a);
            }
           
        }
        public static void ReversoNumber()
         // Одинаковые цифры в числе
        {
            Console.Write("Число");
            int Number = int.Parse(Console.ReadLine());




            for (int i = Number; i >=0; i = Number / 10)
            {
                int a;
                a = i % 10;
              
                while (i>0)
                {
                    
                    if (a == i % 10) 
                    {
                        i = i / 10;
                        Console.Write(a);
                    }
                    else 
                    {
                        Console.Write(i % 10);
                    }
                    i = i / 10;

               
                }
                Console.WriteLine();
            }
       
            

        }
    }
}
