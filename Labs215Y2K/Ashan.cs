using System;

namespace Magazin
{
    class Ashan
    {
        public static void catalog()
        {
            string[] catalog = new string[] { "1. Гречка ", "2. Макароны ", "3. Молоко ", "4. Хлеб ", "5. Батон ", "6. Конфеты ", "7. Чипсы ", "8. Сухари ", "9. Солёный попкорн ", "10. Семечки Белочка " };
            int[] price = new int[] { 130, 250, 50, 30, 30, 150, 100, 50, 150, 200 };
            string priceteg = "руб.";
            //int quantity = new Random().Next(0,11);

            for (int i = 0; i < catalog.Length; i++)
            {
                Console.Write($"{catalog[i]}");
                if (i > 4)
                {
                    Console.Write($" (Развес) ");
                }
                Console.Write($" => {price[i]} " + priceteg);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Выберите номер товара: ");
            int numberofproduct = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numberofproduct > 5)
            {
                Console.WriteLine("Кол-во товара (товары на развес указывать в граммах с шагом в 100): ");
                int countofproduct = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


        }
    }
}