using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace game_3._0
{
    class Actions
    {


        public static void Fight(Unit unit, Unit unit2)
        {

            //int arrows = 1;
            //int damagebyarrow = 50;
            Thread.Sleep(1000);

            //if (unit == Archer)
            //    unit2.GetDamage(arrows, damagebyarrow);

            Console.WriteLine($"unit {unit.Name} hited unit {unit2.Name}");
            unit2.GetDamage(unit.InflictDamage());


            if (unit2.Health <= 0)
            {
                unit2.Health = 0;
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine($"unit {unit2.Name} hited unit {unit.Name}");
                unit.GetDamage(unit2.InflictDamage());
            }

            Console.WriteLine($"{unit2.Name} - {unit2.Health}");
            Console.WriteLine($"{unit.Name} - {unit.Health}");

            Console.WriteLine();

        }


        public static void ArcherFight(Archer unit, Unit unit2)
        {

            //int arrows = 1;
                int damagebyarrow = 50;


            if (unit.Arrows > 0)
            {
                Console.WriteLine($"unit {unit.Name} hited unit {unit2.Name} by arrow");
                unit2.GetDamage(damagebyarrow);

                unit.Arrows -= 1;


                if (unit2.Health <= 0)
                {
                    unit2.Health = 0;
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine($"unit {unit2.Name} hited unit {unit.Name}");
                    unit.GetDamage(unit2.InflictDamage());
                }

                Console.WriteLine($"{unit2.Name} - {unit2.Health}");
                Console.WriteLine($"{unit.Name} - {unit.Health}");

                Console.WriteLine();
            }

            else
                Actions.Fight(unit, unit2);

        }







    }


}
