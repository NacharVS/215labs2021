using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class work
    {
        public static void bot()
        string a = Console.ReadLine(); 

        if (a == "да") 
            if (d == "3") 
                Console.WriteLine("не плохо, старайся…"); 
        if (d == "4") 
            Console.WriteLine("хорошо, ты можешь, лучше!"); 
        if (d == "5") 
            Console.WriteLine("ничего себе, молодец!!!)");

        Console.WriteLine("А настоящий?");
        string s = Console.ReadLine();
        if (s == "да")
            Console.WriteLine("приятно познакомиться, меня зовут Давид, я самый глупый бот на свете");
        else
            Console.WriteLine("приятно познакомиться, меня зовут Давид, я самый глупый бот на свете"); 
    }
}
public static void min()
    //даиагональ
{
    int[] array = new int[100];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.z.Next(100);
        Console.WriteLine(array[i]);
    }

    int max = array[0];
    int min = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }


    Console.WriteLine("min" + min);
    Console.WriteLine("max" + max);
    Console.ReadKey();
}
namespace ех2_диагональ
{
    class Program
    {
        static void Ma()
           //диагональ
        {
            Console.WriteLine(" вычисим диагональ матрицы");
            {
                int[,] array = new int[3, 5];
                int summ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random.Next(10, 100);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();

                }
                int summ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        s++;
                        summ += array[j];
                    }
                }
                Console.WriteLine(summ);
            }
        }
        static void perevorot()
            //переворот числа
        {
            int a = int.Parse(Console.ReadLine());
            int a1 = 0;
            while (a > 0)
            {
                a1 *= 10;
                a1 += a % 10;
                a /= 10;
            }
            Console.WriteLine($"{a1}");
        }
    }
}
class main5446
//потенциальная энергия
{
    public static void ex1()
    {
        Console.WriteLine("Введите массу и высоту ");
        int massa = int.Parse(Console.ReadLine());
        int visota = int.Parse(Console.ReadLine());
        int g = 10;
        int energia = massa * g * visota;
        Console.WriteLine($" = {F}");
    }
}
public static void SUMMA()
//сумма строки
{
   
    int[,] array = new int[3, 3];

    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            array[y, x] = z.Next(10, 100);
            Console.Write("{ array[y, x]} ");

        }
        Console.WriteLine();
    }
    Random z = new Random();
    int sum = 0;

    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            sum += array[y, x];
        }
        Console.WriteLine(sum);
        sum = 0;
    }
  
    }

