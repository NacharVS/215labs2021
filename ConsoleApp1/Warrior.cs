using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Warrior: Character
    {
        public Warrior(double strenght, double dexterity, double intelligence, double constitution, string name) : base(strenght, dexterity, intelligence, constitution, name)
        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
            Name = name;
        }

        public static Warrior operator +(Warrior objectOne, Warrior object2)
        {
            return new Warrior(objectOne.Strenght + object2.Strenght, objectOne.Dexterity, objectOne.Intelligence, objectOne.Constitution, objectOne.Name);
        }
        public override double Strenght
        {
            get => base.Strenght;
            set
            {
                if (value >= 30 & value <= 250)
                    base.Strenght = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 30)
                        Strenght = 30;
                    if (value > 250)
                        Strenght = 250;
                }
            }
        }
        public override double Dexterity
        {
            get => base.Dexterity; 
            set
            {
                if (value >= 15 & value <= 80)
                    base.Dexterity = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 15)
                        Dexterity = 15;
                    if (value > 80)
                        Dexterity = 80;
                }
            }
        }
        public override double Intelligence
        {
            get => base.Intelligence; 
            set
            {
                if (value >= 10 & value <= 50)
                    base.Intelligence = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 10)
                        Intelligence = 10;
                    if (value > 50)
                        Intelligence = 50;
                }
            }
        }
        public override double Constitution
        {
            get => base.Constitution; 
            set
            {
                if (value >= 25 & value <= 100)
                    base.Constitution = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 25)
                        Constitution = 25;
                    if (value > 100)
                        Constitution = 100;
                }
            }
        }
    }
}
