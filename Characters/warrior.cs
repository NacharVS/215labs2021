using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Warrior : Characteristics
    {
        public Warrior(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int pattack, int pdefence, int mattack, int mdefence, int criticalchanse, int criticaldamage)
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
        public static Warrior war = new Warrior(30, 15, 10, 25, 0, 0, 0, 0, 0, 0, 0, 0);
        public static void startwarrior()
        {
            Console.WriteLine($"Warrior characteristic:");
            Console.WriteLine($"Strength = {war.Strentgh}");
            Console.WriteLine($"Dexterity = {war.Dexterity}");
            Console.WriteLine($"Intelligence = {war.Intelligence}");
            Console.WriteLine($"Constitutions = {war.Constitutions}");
            Console.WriteLine($"Health = {war.Health}");
            Console.WriteLine($"Manna = {war.Manna}");
            Console.WriteLine($"Pattack = {war.Pattack}");
            Console.WriteLine($"Pdefence = {war.Pdefence}");
            Console.WriteLine($"Mattack = {war.Mattack}");
            Console.WriteLine($"Mdefence = {war.Mdefence}");
            Console.WriteLine($"Criticalchanse = {war.Criticalchanse}");
            Console.WriteLine($"Criticaldamage = {war.Criticaldamage}");
        }
    }
}
