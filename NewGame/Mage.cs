using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Mage:Unit
    {
        public Mage(double strength, double dexterity, double intelligence, double constitution, string name)
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
                if (value >= 15 & value <= 45)
                    base.Strength = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 15)
                        Strength = 15;
                    if (value > 45)
                        Strength = 45;
                }
            }
        }
        public override double Dexterity
        {
            get => base.Dexterity; set
            {
                if (value >= 20 & value <= 70)
                    base.Dexterity = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 20)
                        Dexterity = 20;
                    if (value > 70)
                        Dexterity = 70;
                }
            }
        }
        public override double Intelligence
        {
            get => base.Intelligence; set
            {
                if (value >= 30 & value <= 250)
                    base.Intelligence = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 30)
                        Intelligence = 30;
                    if (value > 250)
                        Intelligence = 250;
                }
            }
        }
        public override double Constitution
        {
            get => base.Constitution; set
            {
                if (value >= 15 & value <= 65)
                    base.Constitution = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 15)
                        Constitution = 15;
                    if (value > 65)
                        Constitution = 65;
                }
            }
        }

        
    }
}
