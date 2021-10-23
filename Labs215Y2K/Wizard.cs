using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Wizard : Unit
    {
        public int stamina;
        public Wizard(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1, int speed1, int attackspeed1, int stamina1)
        {
            typeUnit = typeUnit1;
            currenthealth = currenthealth1;
            maxhealth = maxhealth1;
            mindamage = mindamage1;
            maxdamage = maxdamage1;
            speed = speed1;
            attackspeed = attackspeed1;
            stamina = stamina1;
        }
        public void Spell()
        {
            if (stamina > 15)
            {
                stamina -= 15;
                int hit = new Random().Next(mindamage, maxdamage) + 100;
                Console.WriteLine($" {typeUnit} cast a strong spell and took down {hit} units of damage");
            }
            else
            {
                if (stamina > 5)
                {
                    stamina -= 5;
                    int hit = new Random().Next(mindamage, maxdamage) - 50;
                    Console.WriteLine($" {typeUnit} cast a weak spell and took down {hit} units of damage");
                }
                else
                {
                    Console.WriteLine(" there is not enough stamina for the Wizard's spell");
                }
            }
        }
    }
}
