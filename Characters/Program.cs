using System;
using System.Collections.Generic;
using Characters.Новая_папка;

namespace Characters
{
    class Program : Characteristics
    {
        
        static void Main(string[] args)
        {

            //List<Mage> mag = new List<Mage>();
            //List<Warrior> warrior = new List<Warrior>();
            //List<Archer> archer = new List<Archer>();
            //warrior.Add(new Warrior(30, 15, 10, 25, 0, 0, 0, 0, 0, 0));
            //mag.Add(new Mage(15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0));
            //archer.Add(new Archer(20, 30, 15, 20, 0, 0, 0, 0, 0, 0));
            //Info.Startredactor(archer, warrior, mag);
            Class1.ex5();
        }

        public static void Archerlist(List<Archer> archer)
        {
            Console.WriteLine($"Характеристки лучника:");
            Console.WriteLine($"Сила = {archer[0].Strentgh}");
            Console.WriteLine($"Ловкость = {archer[0].Dexterity}");
            Console.WriteLine($"Интелект = {archer[0].Intelligence}");
            Console.WriteLine($"Телосложение = {archer[0].Constitutions}");
            Console.WriteLine($"Здоровье = {archer[0].Health}");
            Console.WriteLine($"Физ. атака = {archer[0].Pattack}");
            Console.WriteLine($"Физ. защита = {archer[0].Pdefence}");
            Console.WriteLine($"Критический шанс = {archer[0].PCriticalchanse}");
            Console.WriteLine($"Критический урон = {archer[0].PCriticaldamage}");
        }
        public static void Listing(List<Mage> mag)
        {

            Console.WriteLine();
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
        public static void Warriorlist(List<Warrior> warrior)
        {
            
            Console.WriteLine($"Характеристики воина:");
            Console.WriteLine($"Сила = {warrior[0].Strentgh}");
            Console.WriteLine($"Ловкость = {warrior[0].Dexterity}");
            Console.WriteLine($"Интеллект = {warrior[0].Intelligence}");
            Console.WriteLine($"Телосложение = {warrior[0].Constitutions}");
            Console.WriteLine($"Здоровье = {warrior[0].Health}");
            Console.WriteLine($"Физ. атака = {warrior[0].Pattack}");
            Console.WriteLine($"Физ. защита = {warrior[0].Pdefence}");
            Console.WriteLine($"Критический шанс = {warrior[0].PCriticalchanse}");
            Console.WriteLine($"Критический урон = {warrior[0].PCriticaldamage}");
        }
    }
}

