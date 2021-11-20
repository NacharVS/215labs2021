using System;
using System.ComponentModel.DataAnnotations;
using Units;
using Action;
using Labs215Y2K.Bank;

namespace Labs215Y2K
{
    class Program
    {
         static void Main(string[] args)
         {
            ////int[] qq = new int[10];
            //int[,] qqnya = new int[10, 5];
            ////ArrayOperations.ArrayGeneration(qq, 11, 50);
            //ArrayOperations.ArrayGeneration(qqnya, 2);
            //Magazin.Ashan.catalog();
            //StudentsSort.StudentsSort.StudentSort();

            Account acc1 = new Account("Ivan", 5000);
            Account acc2 = new Account("Fedor", 6000);
            Account acc3 = new Account("Elena", 3000);
            Account acc4 = new Account("Yarik", 100);
            Account acc5 = new Account("Egorik", 100000);

            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            acc4.ShowInfo(acc4);
            acc5.ShowInfo(acc5);
            Console.WriteLine();

            Account.rate = 0.09;
            Account.ShowProfit(acc1, 1);
            Account.ShowProfit(acc3, 1);
            Account.ShowProfit(acc3, 1);
            Account.ShowProfit(acc4, 1);
            Account.ShowProfit(acc5, 1);


            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            acc4.ShowInfo(acc4);
            acc5.ShowInfo(acc5);

            acc1.Deposit(acc1);
            acc1.ShowInfo(acc1);

            acc4.Withdraw(acc4);
            acc4.ShowInfo(acc4);

        }
        public static void magaz(int[] numberofproduct, int yesno, string[] catalog, string[] korzina, int counter, int cycleoperation, int[] countofproduct, int[] korzinakolvo, int[] price, int[] Sum, int[] sumtwo, int[] korzinaprice)
        {
            int cou = 1;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                cou++;
                cycleoperation--;
                if (numberofproduct[cou] < 6)
                {
                    Sum[cou] += price[numberofproduct[cou]] * countofproduct[cou];
                    Console.WriteLine(Sum);
                }
                Console.WriteLine();

                if (numberofproduct[cou] > 5 && countofproduct[cou] % 100 == 0)
                {
                    int check = countofproduct[cou] / 100;
                    sumtwo[cou] += price[numberofproduct[cou]] * check;
                    Console.WriteLine(sumtwo);
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                if (numberofproduct[cou] != 0)
                {
                    korzina[counter] = catalog[numberofproduct[cou]];
                    Console.Write($"Корзина: {korzina[counter]}");
                    counter++;

                }

            }
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

                if (numberofproduct[cou] < 6)
                {
                    korzinaprice[counter] = Sum[counter];
                }
                else
                {
                    korzinaprice[counter] = sumtwo[counter];
                }
                Console.WriteLine($"{korzinaprice[counter]}");
                counter++;
                Console.WriteLine();
            }
        }

        //public static void UnitsCreator()
        //{
            //NewAshan Product1 = new NewAshan(1, "Гречка", 130.50,"шт.", 9);
            //NewAshan Product2 = new NewAshan(2, "Макароны", 250.50, "шт.", 8);
            //NewAshan Product3 = new NewAshan(3, "Молоко", 50.50, "шт.", 7);
            //NewAshan Product4 = new NewAshan(4, "Хлеб", 30.50, "шт.", 4);
            //NewAshan Product5 = new NewAshan(5, "Батон", 30.50, "шт.", 5);
            //NewAshan Product6 = new NewAshan(6, "Конфеты", 150.50, "кг.", 11);
            //NewAshan Product7 = new NewAshan(7, "Чипсы", 100.50, "кг.", 5);
            //NewAshan Product8 = new NewAshan(8, "Сухари", 50.50, "кг.", 4);
            //NewAshan Product9 = new NewAshan(9, "Попкорн", 150.50, "кг.", 6);
            //NewAshan Product10 = new NewAshan(10, "Семечки", 200.50, "кг.", 3);

            //Console.WriteLine("Хотите увидеть список продуктов? 1 - да, 2 - нет");
            //int YesOrNo = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (YesOrNo == 1)
            //{
            //    Console.Write("Номер товара \t Название товара \t Цена товара (за 1 шт. или кг) \t Кол-во товара");
            //    Console.WriteLine();
            //    Console.WriteLine($"{Product1.NumberOfProduct} \t \t {Product1.Names} \t \t {Product1.Price} \t {Product1.PieceOrWeight} \t \t \t {Product1.Quantity}");
            //    Console.WriteLine($"{Product2.NumberOfProduct} \t \t {Product2.Names} \t \t {Product2.Price} \t {Product2.PieceOrWeight} \t \t \t {Product2.Quantity}");
            //    Console.WriteLine($"{Product3.NumberOfProduct} \t \t {Product3.Names} \t \t {Product3.Price} \t {Product3.PieceOrWeight} \t \t \t {Product3.Quantity}");
            //    Console.WriteLine($"{Product4.NumberOfProduct} \t \t {Product4.Names} \t \t \t {Product4.Price} \t {Product4.PieceOrWeight} \t \t \t {Product4.Quantity}");
            //    Console.WriteLine($"{Product5.NumberOfProduct} \t \t {Product5.Names} \t \t \t {Product5.Price} \t {Product5.PieceOrWeight} \t \t \t {Product5.Quantity}");
            //    Console.WriteLine($"{Product6.NumberOfProduct} \t \t {Product6.Names} \t \t {Product6.Price} \t {Product6.PieceOrWeight} \t \t \t {Product6.Quantity}");
            //    Console.WriteLine($"{Product7.NumberOfProduct} \t \t {Product7.Names} \t \t \t {Product7.Price} \t {Product7.PieceOrWeight} \t \t \t {Product7.Quantity}");
            //    Console.WriteLine($"{Product8.NumberOfProduct} \t \t {Product8.Names} \t \t {Product8.Price} \t {Product8.PieceOrWeight} \t \t \t {Product8.Quantity}");
            //    Console.WriteLine($"{Product9.NumberOfProduct} \t \t {Product9.Names} \t \t {Product9.Price} \t {Product9.PieceOrWeight} \t \t \t {Product9.Quantity}");
            //    Console.WriteLine($"{Product10.NumberOfProduct} \t \t {Product10.Names} \t \t {Product10.Price} \t {Product10.PieceOrWeight} \t \t \t {Product10.Quantity}");

            //}
            //else
            //{
            //    Console.WriteLine("Список не выведен");
            //}

        //}
    }
}
