using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class NewAuto : Auto
    {
        public NewAuto(string brand, string mark, double engineVol, int year, int price)
        {
            Brand = brand;
            Mark = mark;
            EngineVol = engineVol;
            Year = year;
            Price = price;
        }
        public static void Start(List<UsedAuto> listautos, List<NewAuto> listauto)
        {
            Console.WriteLine("1 - Вывести список поддержанных машин;");
            Console.WriteLine("2 - Вывести список новых машин;");
            Console.WriteLine("3 - Вывести список машин по заданной цене;");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    UsedAuto.UsedInfo(listautos);
                    Console.WriteLine();
                    Start(listautos, listauto);
                    break;
                case 2:
                    Console.WriteLine();
                    StartListing(listauto);
                    Console.WriteLine();
                    Start(listautos, listauto);
                    break;
                case 3:
                    Console.WriteLine();
                    InfoByPrice(listautos, listauto);
                    Console.WriteLine();
                    Start(listautos, listauto);
                    break;
                default:
                    Console.WriteLine("Неверная цифра");
                    Start(listautos, listauto);
                    break;


            }
        }
        public  static void StartListing(List<NewAuto> listauto)
        {
            foreach (var item in listauto)
            {
                Console.WriteLine($"Марка {item.Brand} Модель {item.Mark} Объём двигателя {item.EngineVol} Год {item.Year} Цена {item.Price} р.");
            }
        }
        public static void InfoByPrice(List<UsedAuto> listautos, List<NewAuto> listauto)
        {
            Console.WriteLine();
            Console.Write("Введите цену, для просмотра машин по задданой цене: ");
            int answer = int.Parse(Console.ReadLine());
            for (int i = 0; i < listautos.Count;i++)
            {
                if (answer == listautos[i].Price)
                {
                    Console.WriteLine($"Марка {listautos[i].Brand} Модель {listautos[i].Mark} Объём двигателя {listautos[i].EngineVol} Год {listautos[i].Year} Цена {listautos[i].Price} р.");
                }
                else
                {
                    continue;
                }
            
            }
            Console.WriteLine();
            for (int i = 0; i < listauto.Count; i++)
            {
                if (answer == listauto[i].Price)
                {
                    Console.WriteLine($"Марка {listauto[i].Brand} Модель {listauto[i].Mark} Объём двигателя {listauto[i].EngineVol} Год {listauto[i].Year} Цена {listauto[i].Price}  р.");
                }
                else
                {
                    continue;
                }

            }
        }
        

    }
}
