using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class solivie
    {
        static void Main(string[] args)
        {
            solevie[] tovars = new solevie[6];
            solevie bear = new solevie();
            bear.nameprodyct = "Плюшевый мишка";
            bear.kolvo = 1;
            bear.price = 500;

            solevie gun = new solevie();
            gun.nameprodyct = "Пистолетик";
            gun.kolvo = 2;
            gun.price = 200;

            solevie car = new solevie();
            car.nameprodyct = "Машинка с пультом управления";
            car.kolvo = 3;
            car.price = 2000;

            solevie popit = new solevie();
            popit.nameprodyct = "Попыт";
            popit.kolvo = 4;
            popit.price = 350;

            solevie skvish = new solevie();
            skvish.nameprodyct = "антистресс для рук - Сквиш";
            skvish.kolvo = 5;
            skvish.price = 250;

            solevie lego = new solevie();
            lego.nameprodyct = "Конструктор лего";
            lego.kolvo = 6;
            lego.price = 2500;

            tovars[0] = bear;
            tovars[1] = gun;
            tovars[2] = car;
            tovars[3] = popit;
            tovars[4] = skvish;
            tovars[5] = lego;

            Console.WriteLine("Здравствуйте, добро пожаловать в Solevie, чтобы посмотреть товары, напишите цифру 1!");
            int prosmotr = int.Parse(Console.ReadLine());
            {
                if (prosmotr == 1)
                {
                    Console.WriteLine(bear.nameprodyct);
                    Console.WriteLine(gun.nameprodyct);
                    Console.WriteLine(popit.nameprodyct);
                    Console.WriteLine(car.nameprodyct);
                    Console.WriteLine(skvish.nameprodyct);
                    Console.WriteLine(lego.nameprodyct);
                }
                else
                    Console.WriteLine("Некорректно");

            }
        }
    }
}
