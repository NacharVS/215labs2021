using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Killer : Unit
    {
        public Killer(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1)
        {
            TypeUnit = typeUnit1;
            Currenthealth = currenthealth1;
            Maxhealth = maxhealth1;
            Mindamage = mindamage1;
            Maxdamage = maxdamage1;
           
        }
        public void murder()
        {
            if (GamePlay.OverallTeamHealth < 1500)
            {
                Console.WriteLine($" {TypeUnit} made murder");
            }
            else
            {
                int hit = new Random().Next(Mindamage, Maxdamage) + 200;
                Console.WriteLine($" {TypeUnit} has dealt {hit} units of damage ");
            }
        }
    }
}
