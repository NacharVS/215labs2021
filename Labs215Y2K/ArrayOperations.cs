using System;
using System.Collections.Generic;
using System.Text;
public static class ArrayM2
{
    public static void CreateArray()
    {
        Console.WriteLine("Ширина И Длина Матрицы");
        int A = int.Parse(Console.ReadLine()); 
       
        int[,] array = new int[A, A];
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
        Console.WriteLine("Первый  - ");int Vvod1 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Второй - ");
        int Vvod2 = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Перый столбик - №", Vvod1);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($" {array[i, Vvod1]}");
            swap = array[i, Vvod1];
            array1[i, Vvod2] = swap;
        }

        Console.WriteLine();

        Console.Write("Второй столбик -№", Vvod2);

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


    public static void sumMatrix()
    {
        Console.WriteLine("Ширина И Длина Матрицы");
        int A = int.Parse(Console.ReadLine());
        int[,] array1 = new int[A, A];
        int sum = 0;

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(0); j++)
            {
                array1[i, j] = new Random().Next(0, 2);
                Console.Write($"{array1[i, j]} ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < array1.GetLength(0); i++)

        {
            for (int j = 0; j < array1.GetLength(0); j++)
            {
                sum += array1[i, j];

            }
            Console.Write($" summ - {sum}");
            Console.WriteLine();
            sum = 0;
        }


    }
    public static void MatrixNAmatritcy()
    {
        Console.WriteLine("Ширина  Матрицы 1");
        int b = int.Parse(Console.ReadLine()); 
        
        Console.WriteLine("Длина Матрицы 1");
        int B = int.Parse(Console.ReadLine());
        int[,] array = new int[B, b];
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
                Console.Write($" {array[i, j]}");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("Ширина  Матрицы 2");
        
        int a = int.Parse(Console.ReadLine()); 
        
        Console.WriteLine();
        Console.WriteLine(" Длина Матрицы 2"); 

        int A= int.Parse(Console.ReadLine());
        int[,] arraytwo = new int[A, a];
       
        for (int i = 0; i < arraytwo.GetLength(0); i++)
        {

            for (int j = 0; j < arraytwo.GetLength(1); j++)
            {
                arraytwo[i, j] = new Random().Next(0, 10);
                Console.Write($" {arraytwo[i, j]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        int[,] sumarray = new int[3, 3];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < arraytwo.GetLength(1); j++)
            {
                sumarray[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    sumarray[i, j] += array[i, k] * arraytwo[k, j];
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(sumarray[i, j] + " ");
            }

            Console.WriteLine();
        }

    }
}





