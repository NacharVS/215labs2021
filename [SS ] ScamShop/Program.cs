using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop7._0
{
    class Program
    {
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

            Console.WriteLine(storage[0].name);
           

            Buy(storage);
            Console.ReadKey();


        }

        public static void Buy(Storage [] storage)
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




        public static void TRASH()
        {

        }
    }
}
