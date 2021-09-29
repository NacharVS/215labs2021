using System;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Как тебя зовут?");
            string a = Console.ReadLine();

            Console.WriteLine("Привет " + a + "! Меня зовут Finder) Я помогу тебе подбрать технику Apple@");
            Console.WriteLine("Скажи пожалуйста, что ты бы хотел купить: iMac, iPhone или MacBook?");

            string i = Console.ReadLine();

            string b = "iMac";
            string c = "iPhone";
            string d = "MacBook";

            if(i == b)
            {
                Console.WriteLine("Новый iMac 24 в магазине стоит от 129 000 рублей (версия на 256гб)");
            }

            if (i == c)
            {
                Console.WriteLine("Новый MacBook air 13 можно приобрести от 89 000 рублей (версия на 256гб)");
                Console.WriteLine("MacBook Pro 13 от 99 000 рублей");
                Console.WriteLine("MacBook Pro 16 от 239 000 рублей");
            }

            if (i == d)
            {
                Console.WriteLine("Цена на новые устройства: ");
                Console.WriteLine("-iPhone 13 mini - от 69 000 рублей");
                Console.WriteLine("-iPhone 13 - от 79 000 рублей");
                Console.WriteLine("-iPhone 13 Pro - от 89 000 рублей");
                Console.WriteLine("-iPhone 13 Pro Max - от99 000 рублей (Версия на 1ТБ стоит 159 000 рублей)");
            }
            else
            {
                Console.WriteLine("Другие устройства пока не поддерживаются( Но вы их можете посмотреть в магазине Re.Store или на сайте Apple");Console.WriteLine("Другие устройства пока не поддерживаются( Но вы их можете посмотреть в магазине Re.Store или на сайте Apple");
                Console.WriteLine("Вам предоставть ссылку на сайт или предоставить адрес магазина?");

                string y = Console.ReadLine();

                if (y == "ссылку" || y == "ссылка" y == "ссылку на сайт");
                {
                    Console.WriteLine("https://www.apple.com/ru/");
                }
                else
                {
                    Console.WriteLine ("ул.Баумана 51 ТК ГУМ");


                }
            }
        }

        }       
    }

