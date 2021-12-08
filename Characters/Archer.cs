using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Archer : Characteristics
    {
        public Archer(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int pattack, int pdefence, int mattack, int mdefence, int criticalchanse, int criticaldamage)
        {
            Strentgh = strentgh;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitutions = constitutions;
            Health = health;
            Pattack = pattack;
            Pdefence = pdefence;
            PCriticalchanse = criticalchanse;
            PCriticaldamage = criticaldamage;
        }
        public static Archer arch = new Archer(20, 30, 15, 20, 0, 0, 0, 0, 0, 0, 0, 0);
        public static void startarcher()
        {
            Console.WriteLine($"Характеристки лучника:");
            Console.WriteLine($"Сила = {arch.Strentgh}");
            Console.WriteLine($"Ловкость = {arch.Dexterity}");
            Console.WriteLine($"Интелект = {arch.Intelligence}");
            Console.WriteLine($"Телосложение = {arch.Constitutions}");
            Console.WriteLine($"Здоровье = {arch.Health}");
            Console.WriteLine($"Физ. атака = {arch.Pattack}");
            Console.WriteLine($"Физ. защита = {arch.Pdefence}");
            Console.WriteLine($"Критический шанс = {arch.PCriticalchanse}");
            Console.WriteLine($"Критический урон = {arch.PCriticaldamage}");
        }
    }
}
