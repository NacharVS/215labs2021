using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class GamePlay
    {
        public static void start()
        {
            Warrior warrior =  new  Warrior("Warrior", 1000, 3600, 125, 450, 30, 45);
            Archer archer = new Archer("Archer", 1500, 3000, 50, 500, 40, 75, 300, 12);
            Healer healer = new Healer("Healer", 3000, 5000, 20, 150, 20, 30, 300);
            Wizard wizard = new Wizard("Wizard", 2000, 3700, 300, 700, 60, 50);
            Guardian guardian = new Guardian("Guardian", 4000, 6000, 300, 600, 20, 30);
            Killer killer = new Killer("Killer", 1700, 3700, 100, 600, 40, 45);
            warrior.Move();
            wizard.Attack();
            archer.ArcherAttack();
            killer.murder();
            healer.selfhill();
            guardian.Attack();
        }

        public void viewlist()
        {
            
            Console.WriteLine($" Type ");
        
        }
    }
}
