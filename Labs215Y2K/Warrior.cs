using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Warrior : Unit
    {
        public Warrior(double strength, double dexterity, double intelligence, double constitution, string name): base(strength, dexterity, intelligence, constitution, name)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
            Name = name;
        }
        public static Warrior operator +(Warrior objectOne, Warrior object2)
        {
            return new Warrior(objectOne.Strength + object2.Strength, objectOne.Dexterity, objectOne.Intelligence, objectOne.Constitution, objectOne.Name);
        }

        public override double Strength { get => base.Strength;
            set
            {
                if (value>=30 & value<=250)
                base.Strength = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 30)
                        Strength = 30;
                    if (value > 250)
                        Strength = 250;
                }
            } 
        }
        public override double Dexterity { get => base.Dexterity; set
            {
                if (value >= 15 & value <= 80)
                    base.Dexterity = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 15)
                        Dexterity = 15;
                    if (value > 80)
                        Dexterity = 80;
                }
            }
        }
        public override double Intelligence { get => base.Intelligence; set
            {
                if (value >= 10 & value <= 50)
                    base.Intelligence = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 10)
                        Intelligence = 10;
                    if (value > 50)
                        Intelligence = 50;
                }
            }
        }
        public override double Constitution { get => base.Constitution; set
            {
                if (value >= 25 & value <= 100)
                    base.Constitution = value;
                else
                {
                    Console.WriteLine("Параметр данного персонажа не может иметь данное значение. Значение было установлено по умолчанию");
                    if (value < 25)
                        Constitution = 25;
                    if (value > 100)
                        Constitution = 100;
                }
            }
        }

    }
}
