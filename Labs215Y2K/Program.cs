using System;


namespace ALL_Homework
{
    class Program
    {


        public static void Main()
        {
            string i = "1";
            int[,] num = new int[5, 3] {
                { 1, 1200, 0,},
                { 2, 3400, 0 },
                { 3, 2300, 0 },
                { 4, 1000, 0 },
                { 5, 1500, 0 } };
            while (i == "1")
            {
                Console.WriteLine("Онлайн Магазин книг");
                Console.WriteLine("___________________________________________________________");
                Console.Write("Каталог");
                Console.Write("        Товары со Скидкой");
                Console.Write("        Возврат");
                Console.WriteLine("        Корзина");
                Console.WriteLine("Инструкции");
                Console.WriteLine("Чтобы зайти в каталог нажмите цифру 1 ");
                Console.WriteLine("Чтобы посмотреть товары со скидкой нажмите цифру 2");
                Console.WriteLine("Чтобы произвести возврат товара нажмите цифру 3 ");
                Console.WriteLine("Чтобы зайти в корзину нажмите цифру 4 ");
                Console.WriteLine("Чтобы закрыть приложение нажмите цифру 0 ");

                string Vvod = Console.ReadLine();


                while (Vvod == "1")
                {
                    Console.Clear();
                    Console.Write("Каталог");
                    Console.WriteLine("_____________________________________________________________________");


                    Console.WriteLine("");
                    Console.WriteLine("Чтобы добавить товар в корзину введите номер книги");
                    Console.WriteLine("Чтобы выйти из католога - 9");
                    Console.WriteLine("");

                    Console.Write("Название книг");
                    Console.Write("         Цена");
                    Console.Write("         Краткое описание");
                    Console.WriteLine("   Акции и Скидки");



                    Console.Write("1.Психология и Этика");
                    Console.Write("  1200р.");
                    Console.Write("  В.Н.Лавриненко, 2003г.");
                    Console.WriteLine("   Скидка 15%");


                    Console.Write("2.Психология влияния");
                    Console.Write("  3400р.");
                    Console.Write("  Роберт Чалдини, 2021г.");
                    Console.WriteLine("   Скидка 10% при покупке второй");


                    Console.Write("3.Менеджмент");
                    Console.Write("          2300р.");
                    Console.WriteLine("  О.С. Виханский, 2004г.");


                    Console.Write("4.Этика        ");
                    Console.Write("       1000р.");
                    Console.WriteLine("  Аристотель,     2002г.");


                    Console.Write("5.Искуство монолога");
                    Console.Write("   1500р.");
                    Console.WriteLine("  Ташевцев,       2002г.");




                    int Vvod1 = int.Parse(Console.ReadLine()) - 1;
                    if (Vvod1 == 8)
                    {
                        Vvod = "0";
                        continue;
                    }
                    Console.WriteLine("Количество");
                    int k = int.Parse(Console.ReadLine());

                    if (Vvod1 == 0)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 1)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 2)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 3)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 4)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 7)
                    {
                        Vvod = "0";
                    }
                    Console.WriteLine("Товар добавлен в корзину");
                    Console.WriteLine($"Всего  книг № { Vvod1 + 1} В количестве { num[Vvod1, 2]}  книг");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();

                }
                while (Vvod == "2")
                {

                    Console.Write("Корзина ");
                    Console.WriteLine("________________________________________________");
                    string Vvod1 = Console.ReadLine();
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    if (Vvod1 == "0")
                    {
                        Vvod = "0";
                    }


                }
                while (Vvod == "3")
                {

                    Console.Write("Каталог");
                    Console.WriteLine("_______________________________________________________________");


                    if (num[0, 2] >= 0)
                    {
                        Console.Write($"Колво { num[0, 2]}");
                        Console.Write("  1.Психология и Этика");
                        Console.Write(" 1200р.");
                        Console.WriteLine("  В.Н.Лавриненко, 2003г.");

                    }

                    if (num[2, 1] >= 0)
                    {
                        Console.Write($"Колво { num[1, 2]}");
                        Console.Write(" 2.Психология влияния");
                        Console.Write("  3400р.");
                        Console.WriteLine("  Роберт Чалдини, 2021г.");


                    }
                    if (num[2, 2] >= 0)
                    {
                        Console.Write($"Колво { num[2, 2]}");
                        Console.Write(" 3.Менеджмент");
                        Console.Write("          2300р.");
                        Console.WriteLine("  О.С. Виханский, 2004г.");



                    }
                    if (num[3, 2] >= 0)
                    {
                        Console.Write($"Колво { num[3, 2]}");
                        Console.Write(" 4.Этика        ");
                        Console.Write("       1000р.");
                        Console.WriteLine("  Аристотель,     2002г.");

                    }

                    if (num[4, 2] >= 0)
                    {
                        Console.Write($"Колво { num[4, 2]}");
                        Console.Write(" 5.Искуство монолога");
                        Console.Write("   1500р.");
                        Console.WriteLine("  Ташевцев,       2002г.");

                    }

                    System.Threading.Thread.Sleep(500);
                    Console.Clear();

                }
                while (Vvod == "4")
                {

                    Console.Write("Корзина");
                    Console.WriteLine("____________________________________________________________________________");
                    Console.Write("Список покупок");


                    string Vvod1 = Console.ReadLine();
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();

                    if (Vvod1 == "0")
                    {
                        Vvod = "0";
                    }


                }


                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Vvod = "0";

            }
        }
    }
}

