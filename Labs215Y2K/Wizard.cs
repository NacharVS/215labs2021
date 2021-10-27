using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Wizard : Unit
    {
        public int stamina;
        public Wizard(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1,  int stamina1)
        {
            TypeUnit = typeUnit1;
            Currenthealth = currenthealth1;
            Maxhealth = maxhealth1;
            Mindamage = mindamage1;
            Maxdamage = maxdamage1;
            stamina = stamina1;
        }
        public void Spell()
        {
            if (stamina > 15)
            {
                stamina -= 15;
                int hit = new Random().Next(Mindamage, Maxdamage) + 100;
                Console.WriteLine($" {TypeUnit} cast a strong spell and took down {hit} units of damage");
            }
            else
            {
                if (stamina > 5)
                {
                    stamina -= 5;
                    int hit = new Random().Next(Mindamage, Maxdamage) - 50;
                    Console.WriteLine($" {TypeUnit} cast a weak spell and took down {hit} units of damage");
                }
                else
                {
                    Console.WriteLine(" there is not enough stamina for the Wizard's spell");
                }
            }
        }
    }
}
