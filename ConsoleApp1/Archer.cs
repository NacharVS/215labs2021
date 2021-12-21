using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Archer : Character
    {
        public Archer(double strenght, double dexterity, double intelligence, double constitution, string name) : base(strenght, dexterity, intelligence, constitution, name)

        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
            Name = name;
        }
        public override double Strenght
        {
            get => base.Strenght;
            set
            {
                if (value >= 20 & value <= 55)
                    base.Strenght = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 20)
                        Strenght = 20;
                    if (value > 55)
                        Strenght = 55;
                }
            }
        }
        public override double Dexterity
        {
            get => base.Dexterity;
            set
            {
                if (value >= 30 & value <= 250)
                    base.Dexterity = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 30)
                        Dexterity = 30;
                    if (value > 250)
                        Dexterity = 250;
                }
            }
        }
        public override double Intelligence
        {
            get => base.Intelligence; 
            set
            {
                if (value >= 15 & value <= 70)
                    base.Intelligence = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 15)
                        Intelligence = 15;
                    if (value > 70)
                        Intelligence = 70;
                }
            }
        }
        public override double Constitution
        {
            get => base.Constitution; set
            {
                if (value >= 20 & value <= 70)
                    base.Constitution = value;
                else
                {
                    Console.WriteLine("Error");
                    if (value < 20)
                        Constitution = 20;
                    if (value > 70)
                        Constitution = 70;
                }
            }
        }
    }
}

