using System;
using System.Collections.Generic;

namespace Characters
{
    class Program : Characteristics
    {

        static void Main(string[] args)
        {
            List<Mage> mag = new List<Mage>();
            mag.Add(new Mage(15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0, 0));
            mag[0].Health = 2 * mag[0].Constitutions + 0.5 * mag[0].Strentgh;
            mag[0].Manna =  mag[0].Intelligence * 3;
            mag[0].Mattack = mag[0].Intelligence * 4;
            mag[0].Mdefence = mag[0].Intelligence * 2;
            mag[0].MCriticalchanse = 20 + mag[0].Intelligence * 0.3;
            mag[0].MCriticaldamage = mag[0].Mattack * (2 + mag[0].Intelligence * 0.15);
            Info.startredactor(mag);
        }
        public static void listing(List<Mage> mag)
        {
            mag[0].Health = 2 * mag[0].Constitutions + 0.5 * mag[0].Strentgh;
            mag[0].Manna = mag[0].Intelligence * 3;
            mag[0].Mattack = mag[0].Intelligence * 4;
            mag[0].Mdefence = mag[0].Intelligence * 2;
            mag[0].MCriticalchanse = 20 + mag[0].Intelligence * 0.3;
            mag[0].MCriticaldamage = mag[0].Mattack * (2 + mag[0].Intelligence * 0.15);
            Console.WriteLine($"Характеристики мага:");
            Console.WriteLine($"Сила = {mag[0].Strentgh}");
            Console.WriteLine($"Ловкость = {mag[0].Dexterity}");
            Console.WriteLine($"Интелект = {mag[0].Intelligence}");
            Console.WriteLine($"Телосложение = {mag[0].Constitutions}");
            Console.WriteLine($"Здоровье = {mag[0].Health}");
            Console.WriteLine($"Мана = {mag[0].Manna}");
            Console.WriteLine($"Маг. атака = {mag[0].Mattack}");
            Console.WriteLine($"Маг. защита = {mag[0].Mdefence}");
            Console.WriteLine($"Критический шанс = {mag[0].MCriticalchanse}");
            Console.WriteLine($"Критический урон = {mag[0].MCriticaldamage}");
        }
    }
}

