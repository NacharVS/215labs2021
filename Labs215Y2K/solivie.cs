using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class MakDak
    {
        static void Main(string[] args)
        {
            MakDaki[] tovars = new MakDaki[6];
            MakDaki salt = new MakDaki();
            salt.nameproduct = "Соль";
            salt.kolvo = 5;
            salt.price = 500;

            MakDaki gun = new MakDaki();
            gun.nameproduct = "Ружье Hatsan Escort";
            gun.kolvo = 2;
            gun.price = 20000;

            MakDaki razor = new MakDaki();
            razor.nameproduct = "Бритва Gilet";
            razor.kolvo = 3;
            razor.price = 2000;

            MakDaki spinner = new MakDaki();
            spinner.nameproduct = "Спинер";
            spinner.kolvo = 10;
            spinner.price = 350;

            MakDaki hemotogen = new MakDaki();
            hemotogen.nameproduct = "Гемотоген";
            hemotogen.kolvo = 20;
            hemotogen.price = 20;

            MakDaki lego = new MakDaki();
            lego.nameproduct = "Конструктор лего";
            lego.kolvo = 3;
            lego.price = 2500;

            tovars[0] = salt;
            tovars[1] = gun;
            tovars[2] = razor;
            tovars[3] = spinner;
            tovars[4] = hemotogen;
            tovars[5] = lego;

            Console.WriteLine("Здравствуйте, добро пожаловать в Solevie, чтобы посмотреть товары, напишите цифру 0!");
            int prosmotr = int.Parse(Console.ReadLine());
            {
                if (prosmotr == 0)
                {
                    Console.WriteLine(salt.nameproduct);
                    Console.WriteLine(gun.nameproduct);
                    Console.WriteLine(spinner.nameproduct);
                    Console.WriteLine(razor.nameproduct);
                    Console.WriteLine(hemotogen.nameproduct);
                    Console.WriteLine(lego.nameproduct);
                }
                else
                    Console.WriteLine("Некорректно");

            }
        }
    }
}
