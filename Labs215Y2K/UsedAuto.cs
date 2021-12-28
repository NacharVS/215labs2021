using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class UsedAuto : Auto
    {
        public UsedAuto(string brand, string mark, double engineVol, int year, int price)
        {
            Brand = brand;
            Mark = mark;
            EngineVol = engineVol;
            Year = year;
            Price = price;
        }
        
        
        
        public static void UsedInfo(List<UsedAuto> listautos)
        {

            foreach (var item in listautos)
            {
                Console.WriteLine($"Марка {item.Brand} Модель {item.Mark} Объём двигателя {item.EngineVol} Год {item.Year} Цена {item.Price} р.");
            }
        }
    }
}
