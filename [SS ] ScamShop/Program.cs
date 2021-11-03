using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shop7._0
{
    class Program
    {
       


        public static void realbasket(Storage[] storage, int numb, int trash, int[] trasharray, int totalsum, int [] trasharrayforcount)
        {

            Console.WriteLine("Ваша корзина:");
            int test = 0;
            for (int i = 0; i < numb; i++)
            {
                test = trasharray[i + 1];
                Console.WriteLine(storage[test].name + " = " + storage[test].prices * trasharrayforcount[i] + "\t"  + " руб " + $"х {trasharrayforcount[i]}");

            }

            
            Console.WriteLine("Итого к оплате: " + totalsum + " руб");

        }
        static void Main(string[] args)
        {
            Storage[] storage = new Storage[10];
            Storage product1 = new Storage();
            product1.name = " Зубная паста";
            product1.prices = 110;
            product1.number = 50;

            Storage product2 = new Storage();
            product2.name = " Конфеты 'коровка' (на развес)";
            product2.prices = 25;
            product2.numbergramm = 20000;

            Storage product3 = new Storage();
            product3.name = " Туалетная бумага";
            product3.prices = 15;
            product3.number = 100;

            Storage product4 = new Storage();
            product4.name = " Гречневая крупа (на развес)";
            product4.prices = 6;
            product4.number = 100000;

            Storage product5 = new Storage();
            product5.name = " Зубная щётка";
            product5.prices = 65;
            product5.number = 250;

            Storage product6 = new Storage();
            product6.name = " Рисовая крупа(на развес)";
            product6.prices = 7;
            product6.number = 100000;

            Storage product7 = new Storage();
            product7.name = " Буханка хлеба";
            product7.prices = 30;
            product7.number = 100;

            Storage product8 = new Storage();
            product8.name = " Сахар (на развес)";
            product8.prices = 3;
            product8.number = 100000;

            Storage product9 = new Storage();
            product9.name = " Жевательная резинка 'Dirol'";
            product9.prices = 30;
            product9.number = 250;

            Storage product10 = new Storage();
            product10.name = " Соль (на развес)";
            product10.prices = 4;
            product10.number = 250000;

            storage[0] = product1;
            storage[1] = product2;
            storage[2] = product3;
            storage[3] = product4;
            storage[4] = product5;
            storage[5] = product6;
            storage[6] = product7;
            storage[7] = product8;
            storage[8] = product9;
            storage[9] = product10;

            int numb = 0;


            Basket(storage, numb);
            //realbasket(storage, numb, ref selection);
            //Buy(storage);
            Console.ReadKey();


        }

        public static void Buy(Storage[] storage)
        {

            int z = 1;
            for (int i = 0; i < storage.Length; i++)
            {

                Console.WriteLine(z + "." + storage[i].name);
                if (i % 2 != 0)
                    Console.WriteLine(storage[i].prices + " руб за 100г");
                else
                    Console.WriteLine(storage[i].prices + " руб");
                z++;
            }
            Console.WriteLine("WARNING: Числа перед наименованием товара - номер товара.");
        }




        public static void Basket(Storage[] storage, int numb)
        {
            int totalsum = 0;
            int localsum = 0;
            int grammcount = 0;
            Console.WriteLine("Приветствуем в нашем онлайн-магазине 'ScamShop'");
            Console.WriteLine("На данный момент Ваша корзина пуста. Давайте перейдём к покупкам!");

            string o;
            int besk = 1;
            int[] trasharray = new int[10];
            int[] trasharrayforcount = new int[5];
            int trash = 0;
            int trash2 = -1;

            while (besk == 1)
            {
                trash++;
                numb++;
                trash2++;

                Console.WriteLine("Введите номер товара, который хотите приобрести");
                int a = int.Parse(Console.ReadLine());
                a -= 1;
                trasharray[trash] = a;
                //Program sel1 = new Program();
                //sel1.name2 = storage[a].name;
                //Program sel2 = new Program();
                //sel2.name2 = storage[a].name 

                if (a >= 0 && a < 10)
                {

                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Введите количество приобретаемого товара. Цена указана за штуку.");
                        int count = int.Parse(Console.ReadLine());


                        trasharrayforcount[trash2] = count; // test



                        localsum += storage[a].prices* count;
                        totalsum += localsum;
                        Console.WriteLine("Вы добавили в корзину:" + storage[a].name + "\t" + "х" + count + " = " + localsum + " руб");
                        localsum = 0;


                    }
                    if (a % 2 != 0)
                    {

                        Console.WriteLine("Введите количество грамм, кратное 100.");
                        grammcount = int.Parse(Console.ReadLine());


                      

                        if (grammcount % 100 == 0)
                        {
                            trasharrayforcount[trash2] = grammcount/100; // test
                            localsum += storage[a].prices * grammcount / 100;

                            totalsum += localsum;
                            Console.WriteLine("Вы добавили в корзину:" + storage[a].name + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                            localsum = 0;

                        }

                        else
                        {
                            Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число. Количество грамм ДОЛЖНО быть кратно сотне.");
                            Console.WriteLine("Введите количество грамм, кратное 100.");
                            grammcount = int.Parse(Console.ReadLine());
                            trasharrayforcount[trash2] = grammcount / 100; // test
                            if (grammcount % 100 == 0)
                            {
                                localsum += storage[a].prices * grammcount / 100;
                                totalsum += localsum;

                                Console.WriteLine("Вы добавили в корзину:" + storage[a].name + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                localsum = 0;


                            }
                            if (grammcount % 100 != 0)
                            {
                                Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.Количество грамм ДОЛЖНО быть кратно сотне.");
                                Console.WriteLine("Введите количество грамм, кратное 100.");
                                grammcount = int.Parse(Console.ReadLine());
                                trasharrayforcount[trash2] = grammcount / 100; // test
                                if (grammcount % 100 == 0)
                                {
                                    localsum += storage[a].prices * grammcount / 100;
                                    totalsum += localsum;

                                    Console.WriteLine("Вы добавили в корзину:" + storage[a].name + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                    localsum = 0;
                                }
                            }
                        }
                    }


                }
                else
                    Console.WriteLine("Ошибка! Введите число от 1 до 10, предварительно перезапустив программу. У нас нет столько ассортимента!");

                Console.WriteLine("Введите 'Да', если хотите продолжить покупки");
                Console.WriteLine("Введите 'Нет', если хотите прекратить покупки.");


                o = Console.ReadLine();
                if (o == "Да")
                    continue;

                if (o == "Нет")
                {
                    Console.WriteLine($"Итого к оплате: {totalsum} рублей");

                    break;
                }

            }

            realbasket(storage, numb, trash, trasharray, totalsum, trasharrayforcount);
        }
    }
}

