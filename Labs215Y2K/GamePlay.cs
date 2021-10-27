using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class GamePlay
    {
        public static void start()
        {
            Warrior warrior =  new  Warrior("Warrior", 1000, 3600, 125, 450);
            Archer archer = new Archer("Archer", 1500, 3000, 50, 500, 300, 12);
            Healer healer = new Healer("Healer", 3000, 5000, 20, 150, 300);
            Wizard wizard = new Wizard("Wizard", 2000, 3700, 300, 700, 150);
            Guardian guardian = new Guardian("Guardian", 4000, 6000, 300, 600);
            Killer killer = new Killer("Killer", 1700, 3700, 100, 600);
           
            warrior.Move();
            wizard.Spell();
            archer.Shoot();
            killer.murder();
            healer.selfhill();
            guardian.GuardianAttack();
            killer.murder();
        }
        public static double OverallTeamHealth = (Warrior.Currenthealth + Archer.Currenthealth + Healer.Currenthealth + Wizard.Currenthealth + Guardian.Currenthealth + Killer.Currenthealth) / 6;
    }
}
