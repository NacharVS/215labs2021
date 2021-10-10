using System;

namespace Magazin
{
    class Ashan
    {
        public static void catalog()
        {
            string[] korzina = new string[1000];
            int[] korzinakolvo = new int[10];
            int[] korzinaprice = new int[10];
            int massivelength = 0;
            int yesno = 1;

            string[] catalog = new string[] { "0. Гречка ", "1. Макароны ", "2. Молоко ", "3. Хлеб   ", "4. Батон  ", "5. Конфеты ", "6. Чипсы ", "7. Сухари ", "8. Попкорн ", "9. Семечки " };
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
            Console.WriteLine("Введите кол-во видов товаров: ");
            massivelength = int.Parse(Console.ReadLine());
            int[] Sum = new int[massivelength];
            int[] sumtwo = new int[massivelength];
            int cycleoperation = massivelength;
            Console.WriteLine("Выберите номер товара: ");
            int[] numberofproduct = new int[massivelength];
            numberofproduct[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во товара (товары на развес указывать в граммах с шагом в 100): ");
            int[] countofproduct = new int[massivelength];
            countofproduct[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Для продолжения введите - 1, для завершения - 0");
            yesno = int.Parse(Console.ReadLine());
            int counter = 0;
            if (yesno == 1)
            {
                Deletor.MainClass.magaz(numberofproduct,yesno,catalog,korzina,counter,cycleoperation, countofproduct, korzinakolvo,price,Sum,sumtwo,korzinaprice);
            }
            else
            {
                Console.WriteLine("Выберите больше товаров");
            }
            Console.WriteLine("Для того чтобы удалить строчку в корзине введите её номер.Чтобы пропустить введите 0");
            int Delet = int.Parse(Console.ReadLine());
            if (Delet > 0) 
            {
                korzina[Delet] = "Товар был удален";
            }
        }
    }
}
