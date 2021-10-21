using System;

namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Warrior", 1000, 3600, 40, 450, 30, 45);
            Archer archer = new Archer("Archer", 1500, 3000, 50, 500, 40, 75, 300, 12);
            Healer healer = new Healer("Healer", 3000, 5000, 20, 150, 20, 30);
            Wizard wizard = new Wizard("Wizard", 2000, 3700, 100, 700, 60, 50);
            Guardian guardian = new Guardian("Guardian", 4000, 6000, 50, 600, 20, 30);
            warrior.Move();
            wizard.Attack();
            archer.ArcherAttack(); 
        }
    }
}
