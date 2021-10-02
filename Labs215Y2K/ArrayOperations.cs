using System;
using System.Collections.Generic;
using System.Text;
public static class ArrayM2
{
    public static void CreateArray()
    {
        int[,] array = new int[10, 10];
        int[,] array1 = new int[array.GetLength(1), array.GetLength(0)];
        int swap = 0;


        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
                Console.Write($" {array[i, j]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Какой столбец с каким поменять");
        Console.WriteLine("Первый  - ");
        int Vvod1 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Второй - ");
        int Vvod2 = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Перый столбик - №", Vvod1);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($" {array[i, Vvod1]}");
            swap = array[i, Vvod1];
            array1[i, Vvod2] = swap;
        }

        Console.WriteLine();

        Console.WriteLine("Второй столбик -№", Vvod2);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($" {array[i, Vvod2]}");
            swap = array[i, Vvod2];
            array1[i, Vvod1] = swap;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Замена");

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (j  == Vvod1 && j!= Vvod2) 
                {
                 Console.Write($" {array1[i, Vvod1]}");
                }
                if (j  == Vvod2 && j != Vvod1)
                {
                    Console.Write($" {array1[i, Vvod2]}");
                }
                if (j != Vvod2 && j != Vvod1)
                {
                    Console.Write($" {array[i, j]}");
                }
                
            }
            Console.WriteLine();
        }
            Console.WriteLine();
    }



}





