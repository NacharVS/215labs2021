using System;

namespace Magazin
{
    class Ashan
    {
        public static void catalog()
        {
            string[] korzina = new string[1000];
            int Sum = 0;
            int sumtwo = 0;


            string[] catalog = new string[] { "0. Гречка ", "1. Макароны ", "2. Молоко ", "3. Хлеб ", "4. Батон ", "5. Конфеты ", "6. Чипсы ", "7. Сухари ", "8. Солёный попкорн ", "9. Семечки Белочка " };
            int[] price = new int[] { 130, 250, 50, 30, 30, 150, 100, 50, 150, 200 };
            string priceteg = "руб.";

            for (int i = 0; i < catalog.Length; i++)
            {
                Console.Write($"{catalog[i]}");
                if (i > 4)
                {
                    Console.Write($" (Развес)");
                }
                Console.Write($" => {price[i]} " + priceteg);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выберите номер товара: ");
            int[] numberofproduct = new int[10];
            numberofproduct[0] = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Для продолжения введите - 1, для завершения - 0");
            int yesno = int.Parse(Console.ReadLine());
            int counter = 0;
            if (yesno == 1)
            {
                Deletor.MainClass.magaz(numberofproduct,yesno,catalog,korzina,counter);
            }
            else
            {
                Console.WriteLine("aboba");
            }
            /*Console.WriteLine("Кол-во товара (товары на развес указывать в граммах с шагом в 100): ");
            int countofproduct = int.Parse(Console.ReadLine());
            if (numberofproduct < 6)
            {
                Sum += price[numberofproduct] * countofproduct;
                Console.WriteLine(Sum);
            }
            Console.WriteLine();
            if (numberofproduct > 5 && countofproduct % 100 == 0)
            {
                int check = countofproduct / 100;
                sumtwo += price[numberofproduct] * check;
                Console.WriteLine(sumtwo);
            }
            else
            {
                Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
            }
            if (numberofproduct != 0)
            {
                int counter = 0;
                korzina[counter] = catalog[numberofproduct];
                Console.Write($"Корзина: {korzina[counter]}");
                counter++;

            }*/
        }
    }
}
