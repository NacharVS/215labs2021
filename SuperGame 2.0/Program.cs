using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Announcement
            string typeunit = "Archer";
            int maxhealth = 30;
            int health = 30;
            int speed = 40;
            int attackspeed = 10;
            int mindamage = 15;
            int maxdamage = 20;
            int arrows = 1;
            int rangedamage = 40;
            Archer archer1 = new Archer(typeunit, maxhealth, health, speed, attackspeed, mindamage, maxdamage, arrows, rangedamage);

            string typeunit2 = "Healer";
            int maxhealth2 = 100;
            int health2 = 96;
            int speed2 = 40;
            int attackspeed2 = 10;
            int mindamage2 = 15;
            int maxdamage2 = 20;
            int countheal2 = 5;
            Healer healer1 = new Healer(typeunit2, maxhealth2, health2, speed2, attackspeed2, mindamage2, maxdamage2, countheal2);

            string typeunit3 = "Peasant";
            int maxhealth3 = 30;
            int health3 = 30;
            int speed3 = 15;
            int attackspeed3 = 5;
            int mindamage3 = 7;
            int maxdamage3 = 10;
            int workspeed = 20;
            string skill3 = " добывает еду";
            Peasant peasant1 = new Peasant(typeunit3, workspeed, maxhealth3, health3, speed3, attackspeed3, mindamage3, maxdamage3, skill3);

            string typeunit4 = "Warrior";
            int maxhealth4 = 150;
            int health4 = 147;
            int speed4 = 20;
            int attackspeed4 = 8;
            int mindamage4 = 30;
            int maxdamage4 = 45;
            Warrior warrior1 = new Warrior(typeunit4, maxhealth4, health4, speed4, attackspeed4, mindamage4, maxdamage4);

            // Heal

            Console.WriteLine("Введите название юнита, которого хотите вылечить.");
            string chose2 = Console.ReadLine();
            if (chose2 == typeunit4)
            {
                Healer.Heal(typeunit4, maxhealth4, ref health4, countheal2, typeunit2);
            }
            if (chose2 == typeunit3)
            {
                Healer.Heal(typeunit3, maxhealth3, ref health3, countheal2, typeunit2);
            }
            if (chose2 == typeunit2)
            {
                Healer.Heal(typeunit2, maxhealth2, ref health2, countheal2, typeunit2);
            }
            if (chose2 == typeunit)
            {
                Healer.Heal(typeunit, maxhealth, ref health, countheal2, typeunit2);
            }


            // Attack
            Console.WriteLine("Введите количество атак, которое Вы будете совершать. Например, 3.");
            int count = int.Parse(Console.ReadLine());
            while (count > 0)
            {
                count--;
                Console.WriteLine("Введите юнита, за которого хотите начать атаку.");
                string chose3 = Console.ReadLine();
                Console.WriteLine("Введите название юнита, которого хотите атаковать.");
                string chose4 = Console.ReadLine();
                if (chose3 == typeunit4)
                {
                    if (chose4 == typeunit3)
                        Unit.Attack(typeunit4, typeunit3, mindamage4, maxdamage4, ref health3);

                    if (chose4 == typeunit2)
                        Unit.Attack(typeunit4, typeunit2, mindamage4, maxdamage4, ref health2);

                    if (chose4 == typeunit)
                        Unit.Attack(typeunit4, typeunit, mindamage4, maxdamage4, ref health);

                    if (chose4 == typeunit4)
                    {
                        Console.WriteLine("В нашей прекрасной игре нельзя наносить урон по себе. Одумайтесь!");
                    }
                }

                if (chose3 == typeunit3)
                {
                    if (chose4 == typeunit4)
                        Unit.Attack(typeunit3, typeunit4, mindamage3, maxdamage3, ref health4);

                    if (chose4 == typeunit2)
                        Unit.Attack(typeunit3, typeunit2, mindamage3, maxdamage3, ref health2);

                    if (chose4 == typeunit)
                        Unit.Attack(typeunit3, typeunit, mindamage3, maxdamage3, ref health);

                    if (chose4 == typeunit3)
                    {
                        Console.WriteLine("В нашей прекрасной игре нельзя наносить урон по себе. Одумайтесь!");
                    }
                }

                if (chose3 == typeunit2)
                {
                    if (chose4 == typeunit4)
                        Unit.Attack(typeunit2, typeunit4, mindamage2, maxdamage2, ref health4);

                    if (chose4 == typeunit3)
                        Unit.Attack(typeunit2, typeunit3, mindamage2, maxdamage2, ref health3);

                    if (chose4 == typeunit)
                        Unit.Attack(typeunit2, typeunit, mindamage2, maxdamage2, ref health);

                    if (chose4 == typeunit2)
                    {
                        Console.WriteLine("В нашей прекрасной игре нельзя наносить урон по себе. Одумайтесь!");
                    }
                }


                if (chose3 == typeunit)
                {
                    if (chose4 == typeunit4)
                    {
                        if (arrows > 0)
                        {
                            Archer.ArcherShoot(typeunit, typeunit4, ref health4, ref arrows, rangedamage);
                        }
                        else
                            Unit.Attack(typeunit, typeunit4, mindamage, maxdamage, ref health4);
                    }

                    if (chose4 == typeunit3)
                    {
                        if (arrows > 0)
                        {
                            Archer.ArcherShoot(typeunit, typeunit3, ref health3, ref arrows, rangedamage);
                        }
                        else
                            Unit.Attack(typeunit, typeunit3, mindamage, maxdamage, ref health3);
                    }

                    if (chose4 == typeunit2)
                    {
                        if (arrows > 0)
                        {
                            Archer.ArcherShoot(typeunit, typeunit2, ref health2, ref arrows, rangedamage);
                        }
                        else
                            Unit.Attack(typeunit, typeunit2, mindamage, maxdamage, ref health2);
                    }

                    if (chose4 == typeunit)
                    {
                        Console.WriteLine("В нашей прекрасной игре нельзя стрелять по себе. Одумайтесь!");
                    }
                }
            }

            //Console.WriteLine(health3);
            //Console.WriteLine(arrows);





            Console.ReadKey();
        }
    }
}
    

