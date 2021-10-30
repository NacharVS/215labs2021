using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Игра
{
      class Action
      {
        public static void Figth(Peaceful unit1,Peaceful unit2)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"В бой вступили{unit1.Change_Name} и {unit2.Change_Name}");
            Random  r = new Random();
            int value = r.Next(0, 2);
            if (value == 1)
            {
                unit1.GetDamage(unit2.SetDamage());
                Console.WriteLine($" {unit2.Change_Name} атакует {unit1.Change_Name},его здоровье {unit1.Change_New_hp}");
            }
            if (value == 0)
            {
                unit2.GetDamage(unit1.SetDamage());
                Console.WriteLine($" {unit1.Change_Name} атакует {unit2.Change_Name},его здоровье {unit2.Change_New_hp}");
            }
        }
      }

}

