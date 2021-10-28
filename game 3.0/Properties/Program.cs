using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_3._0
{
    class Program
    {

        static void Main(string[] args)
        {
            Peasant p1 = new Peasant();
            Peasant p2 = new Peasant();
            p1.Name = "Valera"; p2.Name = "Danila";
            p1.MinDamage = 15;
            p1.MaxDamage = 20;
            p2.MinDamage = 15;
            p2.MaxDamage = 20;
            p1.Health = 50;
            p2.Health = 500;

            Warrior w1 = new Warrior();
            w1.Name = "qqnya";
            w1.MinDamage = 40;
            w1.MaxDamage = 50;
            w1.Health = 150;

            Archer a1 = new Archer();
            a1.Name = "ar4i";
            a1.Health = 1000;
            a1.MinDamage = 20;
            a1.MaxDamage = 30;
            a1.Arrows = 1;

            Healer h1 = new Healer();
            h1.Name = "ar4i";
            h1.Health = 1000;
            h1.MinDamage = 20;
            h1.MaxDamage = 30;
            h1.Countheal = 10;




            Actions.ArcherFight(a1, p2);
            

            ////Actions.ArcherFight(a1, p2);


            //Actions.Fight(a1, p2);


            Console.WriteLine(a1.Arrows);
            //Actions.Fight(a1, p2);
            //Actions.Fight(a1, p2);
            Console.ReadKey();
        }
    }
}
