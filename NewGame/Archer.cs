using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Archer:Unit
    {
        public Archer(double strength, double dexterity, double intelligence, double constitution, string name): base(strength, dexterity, intelligence, constitution, name)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
            Name = name;
        }

        public override double Strength
        {
            get => base.Strength;
            set
            {
                if (value >= 20 & value <= 55)
                    base.Strength = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 20)
                        Strength = 20;
                    if (value > 55)
                        Strength = 55;
                }
            }
        }
        public override double Dexterity
        {
            get => base.Dexterity; set
            {
                if (value >= 30 & value <= 250)
                    base.Dexterity = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 30)
                        Dexterity = 30;
                    if (value > 250)
                        Dexterity = 250;
                }
            }
        }
        public override double Intelligence
        {
            get => base.Intelligence; set
            {
                if (value >= 15 & value <= 70)
                    base.Intelligence = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
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
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 20)
                        Constitution = 20;
                    if (value > 70)
                        Constitution = 70;
                }
            }
        }
    }
}
