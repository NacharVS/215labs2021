using System;
using System.Linq;

namespace Deletor
{
    public class MainClass
    {
        public static void Main()
        {
            int[,] array = new int[10, 10];
            int[] arraytwo = new int[10];


            //MaxMin.Maxmin.ex1(); // - максимальный элемент массива
            //Multplus.MultPlus.ex2();  // - Сумма и умножение массива
            //MaxElement.MaxElem.ex3(); // - Максимальный элемент в каждой строке
            //SumMatrix.SumMatrix.ex4(); // - Сумма каждой строки матрицы
            // SwapArray.Swap.ex5(); // - Меняет местами строки массива
            //TwoIdentElementDeletor.Deletor.ex7(); // - находит одинаковые числа в массиве
            // MatrixMult.Matrix.ex6(); // - Произведение двух матриц
            //Fill.Matrix.ex10(array);
            Labs215Y2K.ArrayOperations.ArrayGeneration(array,10);


            //Console.WriteLine();
            //Labs215Y2K.ArrayOperations.ArrayGeneration(arraytwo,5,500);
            //Magazin.Ashan.catalog();
            
        }
        public static void magaz(int[] numberofproduct,int yesno, string[] catalog, string[] korzina, int counter,int  cycleoperation,int[] countofproduct, int[] korzinakolvo,int[] price,int[] Sum, int[] sumtwo,int[] korzinaprice)
        {
            int cou = 1;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                if (numberofproduct[cou] < 6)
                {
                    Sum[cou] += price[numberofproduct[cou]] * countofproduct[cou];
                    korzinaprice[cou] = Sum[cou];
                }
                Console.WriteLine();
                if (numberofproduct[cou] > 5 && countofproduct[cou] % 100 == 0)
                {
                    int check = countofproduct[cou] / 100;
                    sumtwo[cou] += price[numberofproduct[cou]] * check;
                    korzinaprice[cou] = sumtwo[cou];
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                //if (numberofproduct[cou] != 0)
                //{
                //    korzina[counter] = catalog[numberofproduct[cou]];
                //    Console.Write($"Корзина: {korzina[counter]}");
                //    counter++;

                //}
                cou++;
                cycleoperation--;
            }
            //if (numberofproduct[cou] < 6)
            //{
            //    korzinaprice[counter] = Sum[counter];
            //}
            //else
            //{
            //    korzinaprice[counter] = sumtwo[counter];
            //}
            Console.WriteLine();
            Console.Write($"Товар:       Кол-во:         Цена:");
            Console.WriteLine();
            for (int i = 0; i < numberofproduct.Length; i++)
            {
                korzina[counter] = catalog[numberofproduct[i]];
                Console.Write($"{  korzina[counter]}          ");
                Console.Write($"{  countofproduct[counter]}          ");
                korzinakolvo[counter] = price[numberofproduct[i]];
                Console.Write($"{  korzinakolvo[counter]}         ");
                //Console.Write($"{korzinaprice[counter]}");
                counter++;
                Console.WriteLine();
            }
        }

        
    }
}
