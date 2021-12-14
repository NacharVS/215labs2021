using System;
using System.Collections.Generic;

namespace New_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Work();
            Console.ReadKey(); 
            
        }

       

        public static void Work()
        {

            Unit dualunit = new Unit(0, 0, 0, 0, "");
            Warrior war = new Warrior(30, 15, 10, 85, "воин1");
            Warrior war2 = new Warrior(50, 35, 30, 45, "воин2");
            war.testevent += Unit.DeBuff;

            List<Unit> Chaptres = new List<Unit>();

            Chaptres.Add(war);
            Chaptres.Add(war2);

            //Расчёт характеристик

            for (int i = 0; i < Chaptres.Count; i++)
            {
                Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth;
                Chaptres[i].CurrencyMana = Chaptres[i].MaxMana;



                //Chaptres[i].M_Attack = Chaptres[i].Intelligence * 4;
                //Chaptres[i].M_CritChance = 20 + Chaptres[i].Intelligence * 0.1;
                //Chaptres[i].M_CritDamage = Chaptres[i].M_Attack * (2 + Chaptres[i].Intelligence * 0.15);
                Console.WriteLine($"Магический Урон - {Chaptres[i].M_Attack} - Шанс магического крит. Урона-  {Chaptres[i].M_CritChance} % Крит. урон магический - {Chaptres[i].M_CritDamage}");


                
                //Chaptres[i].CurrencyMana = Chaptres[i].MaxMana = Chaptres[i].Intelligence * 3;


                //Chaptres[i].P_Attack = Chaptres[i].Strength * 3 + Chaptres[i].Dexterity * 0.5;
                //Chaptres[i].P_Defense = Chaptres[i].Constitution * 0.5 + Chaptres[i].Dexterity * 3;
                //Chaptres[i].M_Defense = Chaptres[i].Intelligence * 2;
                //Chaptres[i].P_CritChance = 20 + Chaptres[i].Dexterity * 0.3;
                //Chaptres[i].P_CritDamage = Chaptres[i].P_Attack * (2 + Chaptres[i].Dexterity * 0.05);



                Console.WriteLine($"Характеристика вашего персонажа: ХП- {Chaptres[i].CurrencyHealth} Мана- {Chaptres[i].CurrencyMana} Физ.Дамаг- {Chaptres[i].P_Attack} Физ.Защита - {Chaptres[i].P_Defense} Шанс Крита {Chaptres[i].P_CritChance} % Крит Урон - {Chaptres[i].P_CritDamage}");
                Console.WriteLine($"Маг.Защита - {Chaptres[i].M_Defense}");
                

                if (Chaptres[i] is Warrior)
                {
                    Console.WriteLine("Ваш персонаж - ВОИН. Дитя войны");
                }
                if (Chaptres[i] is Mage)
                {
                    Console.WriteLine("Вы - Маг-оступник, сошедший с пути становления архимагом, и отправились в дальний путь");
                }
                if (Chaptres[i] is Archer)
                {
                    Console.WriteLine("Охотник, проживший в лесу немало времени, открывает для себя дорогу авантюриста.");
                }
                Unit.PAttack(war, Chaptres);
                Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth = 120;
                Unit.PAttack(war, Chaptres);
                Console.WriteLine(war.P_Defense); 



            }
        
             
            // Расчёт окончен
 
  
        }


    }
}
