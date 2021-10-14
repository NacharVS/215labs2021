using System;

namespace ALL_Homework
{
    class Program
    {


        public static void Main()
        {
            string i = "1";
            int[,] num = new int[5, 4] {
                { 1, 1200, 0,  15},
                { 2, 3400, 0,  0},
                { 3, 2300, 0,  0},
                { 4, 1000, 0,  0},
                { 5, 1500, 0,  0} };
            float[] CKIDKA = new float[5] { 0.15f, 0.3f, 0.0f, 0.0f, 0.0f };


            while (i == "1")
            {

                // ТЕКСТ МЕНЮ
                Console.WriteLine("Онлайн Магазин книг");
                Console.WriteLine("___________________________________________________________");
                Console.Write("Каталог");
                Console.WriteLine("        Корзина");
                Console.WriteLine("Инструкции");
                Console.WriteLine("ИСОЛЬЗУЙТЕ ТОЛЬКО ЦИФРЫ");
                Console.WriteLine("Чтобы зайти в каталог нажмите цифру 1 ");
                Console.WriteLine("Чтобы зайти в корзину нажмите цифру 2 ");
                Console.WriteLine("Чтобы закрыть приложение нажмите цифру 0 ");

                string Vvod = Console.ReadLine();


                while (Vvod == "1")
                {

                    // ТЕКСТ КАТАЛОГА


                    Console.Clear();
                    Console.Write("Каталог");
                    Console.WriteLine("_____________________________________________________________________");


                    Console.WriteLine("");
                    Console.Write("Инструкции");
                    Console.WriteLine("Чтобы добавить товар в корзину введите номер книги");
                    Console.WriteLine("Чтобы выйти из католога - 9");
                    Console.WriteLine("После заказа подождите пару секуд для его оформления");
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
                    Console.WriteLine("   Скидка 30%");



                    Console.Write("3.Менеджмент");
                    Console.Write("          2300р.");
                    Console.WriteLine("  О.С. Виханский, 2004г.");


                    Console.Write("4.Этика        ");
                    Console.Write("       1000р.");
                    Console.WriteLine("  Аристотель,     2002г.");


                    Console.Write("5.Искуство монолога");
                    Console.Write("   1500р.");
                    Console.WriteLine("  Ташевцев,       2002г.");



                    // МОЗГИ КАТОЛОГА


                    int Vvod1 = int.Parse(Console.ReadLine()) - 1;


                    if (Vvod1 == 8)
                    {
                        Vvod = "0";
                        continue;
                    }
                    Console.WriteLine("Количество");
                    int k = int.Parse(Console.ReadLine());

                    if (Vvod1 == 0 && num[Vvod1, 2] + k >= 0 && k > 0)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 1 && num[Vvod1, 2] + k >= 0 && k > 0)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 2 && num[Vvod1, 2] + k >= 0 && k > 0)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 3 && num[Vvod1, 2] + k >= 0 && k > 0)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 4 && num[Vvod1, 2] + k >= 0 && k > 0)
                    {
                        num[Vvod1, 2] = num[Vvod1, 2] + k;
                    }
                    if (Vvod1 == 7 && num[Vvod1, 2] + k >= 0 && k > 0)
                    {
                        Vvod = "0";
                    }

                    if (Vvod1 <= 4 && Vvod1 >= 0)
                    {
                        Console.WriteLine("Товар добавлен в корзину");
                        Console.WriteLine($"Всего  книг № { Vvod1 + 1} В количестве { num[Vvod1, 2]}  книг");
                        System.Threading.Thread.Sleep(1500);
                    }

                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();

                }

                while (Vvod == "2")
                {

                    Console.Clear();
                    // ТЕКСТ КОРЗИНЫ


                    Console.Write("Корзина");
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Инструкции");
                    Console.WriteLine("ИСОЛЬЗУЙТЕ ТОЛЬКО ЦИФРЫ");
                    Console.WriteLine("Чтобы выйти из корзины нажимите 9");
                    Console.WriteLine("Чтобы удалить товар нажмите 1 и потом его номер");


                    if (num[0, 2] > 0)
                    {
                        Console.Write($"Колво { num[0, 2]}");
                        Console.Write(" 1.Психология и Этика");
                        Console.Write("  1200р.");
                        Console.WriteLine("  В.Н.Лавриненко, 2003г.");

                    }

                    if (num[1, 2] > 0)
                    {
                        Console.Write($"Колво { num[1, 2]}");
                        Console.Write(" 2.Психология влияния");
                        Console.Write("  3400р.");
                        Console.WriteLine("  Роберт Чалдини, 2021г.");


                    }
                    if (num[2, 2] > 0)
                    {
                        Console.Write($"Колво { num[2, 2]}");
                        Console.Write(" 3.Менеджмент");
                        Console.Write("          2300р.");
                        Console.WriteLine("  О.С. Виханский, 2004г.");



                    }
                    if (num[3, 2] > 0)
                    {
                        Console.Write($"Колво { num[3, 2]}");
                        Console.Write(" 4.Этика        ");
                        Console.Write("       1000р.");
                        Console.WriteLine("  Аристотель,     2002г.");

                    }

                    if (num[4, 2] > 0)
                    {
                        Console.Write($"Колво { num[4, 2]}");
                        Console.Write(" 5.Искуство монолога");
                        Console.Write("   1500р.");
                        Console.WriteLine("  Ташевцев,       2002г.");

                    }

                    //МОЗГИ КОРЗИНЫ


                    int Summ = 0;
                    float Ckidka = 0f;

                    for (int i1 = 0; i1 < num.GetLength(0); i1++)
                    {
                        Summ = Summ + num[i1, 2] * num[i1, 1];
                        Ckidka = Ckidka + num[i1, 2] * num[i1, 1] * CKIDKA[i1];
                    }

                    Console.WriteLine($"Общая сумма {Summ}р. ");
                    Console.WriteLine($"Скидка {(Ckidka)}р. ");
                    Console.WriteLine($"Общая сумма {Summ - Ckidka}р. ");


                    string Vvod3 = Console.ReadLine();
                    Type t1 = typeof(string);
                    Type t2 = typeof(int);




                    if (t1 == Vvod3.GetType())
                    {

                        if (Vvod3 == "9")
                        {
                            Vvod = "0";
                        }
                        if (Vvod3 == "1" )
                        {
                            int Vvod2 = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine($"Количество на которое надо уменшить");
                            int k = int.Parse(Console.ReadLine());
                            if (Vvod2 == 0 && num[Vvod2, 2] - k >= 0 && k > 0)
                            {
                                num[Vvod2, 2] = num[Vvod2, 2] - k;
                            }
                            if (Vvod2 == 1 && num[Vvod2, 2] - k >= 0 && k > 0)
                            {
                                num[Vvod2, 2] = num[Vvod2, 2] - k;
                            }
                            if (Vvod2 == 2 && num[Vvod2, 2] - k >= 0 && k > 0)
                            {
                                num[Vvod2, 2] = num[Vvod2, 2] - k;
                            }
                            if (Vvod2 == 3 && num[Vvod2, 2] - k >= 0 && k > 0)
                            {
                                num[Vvod2, 2] = num[Vvod2, 2] - k;
                            }
                            if (Vvod2 == 4 && num[Vvod2, 2] - k >= 0 && k > 0)
                            {
                                num[Vvod2, 2] = num[Vvod2, 2] - k;
                            }

                        }

                    }

                    System.Threading.Thread.Sleep(500);
                    Console.Clear();

                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Vvod = "0";

            }
        }
    }
}







