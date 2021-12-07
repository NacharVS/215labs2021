using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Mage : Characteristics
    {
        public Mage(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int pattack, int pdefence, int mattack, int mdefence, int criticalchanse, int criticaldamage)
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
        public static Mage mag = new Mage(15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0, 0);
        public static void startmage()
        {
            Console.WriteLine($"Mage characteristic:");
            Console.WriteLine($"Strength = {mag.Strentgh}");
            Console.WriteLine($"Dexterity = {mag.Dexterity}");
            Console.WriteLine($"Intelligence = {mag.Intelligence}");
            Console.WriteLine($"Constitutions = {mag.Constitutions}");
            Console.WriteLine($"Health = {mag.Health}");
            Console.WriteLine($"Manna = {mag.Manna}");
            Console.WriteLine($"Pattack = {mag.Pattack}");
            Console.WriteLine($"Pdefence = {mag.Pdefence}");
            Console.WriteLine($"Mattack = {mag.Mattack}");
            Console.WriteLine($"Mdefence = {mag.Mdefence}");
            Console.WriteLine($"Criticalchanse = {mag.Criticalchanse}");
            Console.WriteLine($"Criticaldamage = {mag.Criticaldamage}");
        }
    }
}
