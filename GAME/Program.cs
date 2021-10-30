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
            p1.Maxhealth = 1005;
            p2.Maxhealth = 1005;
            p1.Skill = " добывает еду";
            p2.Skill = " добывает еду";

            Warrior w1 = new Warrior();
            w1.Name = "qqnya";
            w1.MinDamage = 40;
            w1.MaxDamage = 50;
            w1.Health = 150;
            w1.Maxhealth = 1005;

            Archer a1 = new Archer();
            a1.Name = "ar4i";
            a1.Health = 1000;
            a1.MinDamage = 20;
            a1.MaxDamage = 30;
            a1.Arrows = 1;
            a1.Maxhealth = 1005;

            Healer h1 = new Healer();
            h1.Name = "Mr. Healer";
            h1.Health = 1000;
            h1.MinDamage = 20;
            h1.MaxDamage = 30;
            h1.Countheal = 10;
            h1.Maxhealth = 1005;

            LamberJack l1 = new LamberJack();
            l1.Name = "Mr. LamberJack";
            l1.Health = 1000;
            l1.MinDamage = 20;
            l1.MaxDamage = 30;
            l1.Skill = " добывает дерево";

            Miner m1 = new Miner();
            m1.Name = "Mr. LamberJack";
            m1.Health = 1000;
            m1.MinDamage = 20;
            m1.MaxDamage = 30;
            m1.Skill = " добывает КАМЕНЬ";


            Actions.Fight(p2, a1);
            Healer.Heal(h1, a1);

            ////Actions.ArcherFight(a1, p2);


            //Actions.Fight(a1, p2);



            //Actions.Fight(a1, p2);
            //Actions.Fight(a1, p2);
            Console.ReadKey();
        }
    }
}
