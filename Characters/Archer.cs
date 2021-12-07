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
            Manna = manna;
            Pattack = pattack;
            Pdefence = pdefence;
            Mattack = mattack;
            Mdefence = mdefence;
            Criticalchanse = criticalchanse;
            Criticaldamage = criticaldamage;
        }
        public static Archer arch = new Archer(20, 30, 15, 20, 0, 0, 0, 0, 0, 0, 0, 0);
        public static void startarcher()
        {
            Console.WriteLine($"Archer characteristic:");
            Console.WriteLine($"Strength = {arch.Strentgh}");
            Console.WriteLine($"Dexterity = {arch.Dexterity}");
            Console.WriteLine($"Intelligence = {arch.Intelligence}");
            Console.WriteLine($"Constitutions = {arch.Constitutions}");
            Console.WriteLine($"Health = {arch.Health}");
            Console.WriteLine($"Manna = {arch.Manna}");
            Console.WriteLine($"Pattack = {arch.Pattack}");
            Console.WriteLine($"Pdefence = {arch.Pdefence}");
            Console.WriteLine($"Mattack = {arch.Mattack}");
            Console.WriteLine($"Mdefence = {arch.Mdefence}");
            Console.WriteLine($"Criticalchanse = {arch.Criticalchanse}");
            Console.WriteLine($"Criticaldamage = {arch.Criticaldamage}");
        }
    }
}
