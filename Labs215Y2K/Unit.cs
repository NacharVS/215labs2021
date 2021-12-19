using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Unit
    {
        private bool _test = true;
        public bool Test { get => _test; set => _test = value; }


        private double _strength;
        private double _dexterity;
        private double _intelligence;
        private double _constitution;

        private string _name;

        private double _maxHealth;
        private double _maxMana;

        private double _p_Defense;
        private double _p_Attack;
        private double _m_Defense;
        private double _p_CrtitChanse;
        private double _p_CritDamage;
        private double _m_Attack;
        private double _m_CritChanse;
        private double _m_CritDamage;

        private double _currencyHealth;
        private double _currencyMana;

        public Unit(double strength, double dexterity, double intelligence, double constitution, string name)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
            Name = name;
        }

        public virtual double Strength { get => _strength; set => _strength = value; }
        public virtual double Dexterity { get => _dexterity; set => _dexterity = value; }
        public virtual double Intelligence { get => _intelligence; set => _intelligence = value; }
        public virtual double Constitution { get => _constitution; set => _constitution = value; }
        public double MaxHealth
        {
            get
            {
                 
                return 0.5 * Strength + 2 * Constitution; 
            }
            set
            {
                if (value > 0)
                    _maxHealth = value;
                else
                    Console.WriteLine("Невозможно вписать отрицательное значение для максимального HP.");

            }
        }
        public double MaxMana
        {
            get
            {
                _maxMana = Intelligence * 3;
                return _maxMana;
            }

        }
        public double P_Defense 
        {   get  
            {
                return Constitution * 0.5 + Dexterity * 3;
            }

                
            
        }
        public double P_Attack
        { 
            get
            {
                return Strength * 3 + Dexterity * 0.5;
            }
            private set
            {
                _p_Attack = value;
            }
        }
        public double M_Defense 
        
        { 
            get
            {
                return Intelligence * 2;
            }
        }
        public double P_CritChance 
        { 
            get
            {
                return 20 + Dexterity * 0.3;
            }
            private set
            {
                _p_CrtitChanse = value;
            }
        }
        public double P_CritDamage
        { 
            get
            {
                return P_Attack * (2 + Dexterity * 0.05);
            }
            private set
            {
                _p_CritDamage = value;
            }
        }
        public double M_Attack 
        {
            get
            {
             return Intelligence * 4;
            }
        }
        public double M_CritChance 
        {
            get
            {
                return 20 + Intelligence * 0.1;
            }
        }
        public double M_CritDamage 
        {
            get
            {
                return M_Attack * (2 + Intelligence * 0.15);
            }
        }
        public double CurrencyHealth
        {
            get => _currencyHealth; set
            {
                if (value <= MaxHealth)
                {
                    if (value > 0)
                    {
                        _currencyHealth = value;
                        if (value <= MaxHealth * 0.5 & value > 0 && Test == true)
                        {
                            Test = false;
                            Strength -= Strength * 0.1;
                            Dexterity -= Dexterity * 0.1;
                            Intelligence -= Intelligence * 0.1;
                            Constitution -= Constitution * 0.1;

                            testevent?.Invoke("Так как ваши показатели хп/мана достигли критической отметки, все ваши характеристики снижены на 10 %:");
                            Console.WriteLine($"Сила: {Strength}");
                            Console.WriteLine($"Ловкость:  {Dexterity}");
                            Console.WriteLine($"Интеллект: {Intelligence}");
                            Console.WriteLine($"Телосложение: {Constitution}");
                        }
                    }
                    if (value <= 0)
                    {
                        _currencyHealth = 0;
                        Console.WriteLine($"{Name} мёртв.");

                    }
                }
                else
                    _currencyHealth = MaxHealth;

            }
        }
        public double CurrencyMana
        {
            get => _currencyMana; set
            {
                if (value <= MaxMana)
                {

                    if (value >= 0)
                        _currencyMana = value;
                    if (value <= MaxMana * 0.2)
                    {
                        MaxHealth -= MaxHealth * 0.2;
                        _currencyMana = value;
                    }
                    if (value < 0)
                    {
                        _currencyMana = 0;
                        Console.WriteLine("У вас не хватает маны для совершения действия.");
                    }
                }

            }
        }
        public string Name { get => _name; set => _name = value; }

        public delegate void CritValueHealth(string message);
        public event CritValueHealth testevent;
        public static void Buff(Unit unit)
        {
            Console.WriteLine("С вероятностью 50/50 произойдёт бафф героя.");
            Random z = new Random();
            if (z.Next(0, 1) == 1)
            {
                unit.Constitution += z.Next(10, 30);
                unit.Strength += z.Next(10, 30);
                unit.Intelligence += z.Next(10, 30);
                unit.Dexterity += z.Next(10, 30);
                Console.WriteLine("Все характеристики были улучшены");
                Console.WriteLine(unit.Constitution + " - Constitution");
                Console.WriteLine(unit.Strength + " - Strength");
                Console.WriteLine(unit.Intelligence + " - Intelligence");
                Console.WriteLine(unit.Dexterity + " - Dexterity");
            }
            else
                Console.WriteLine("Баффа не произошло. Характеристики остаются прежними.");
        }
        public static void MAttack(Unit attunit, List<Unit> Chaptres)
        {
            Random z = new Random();
            Console.WriteLine("Выберите персонажа, которого хотите атаковать МАГИЧЕСКОЙ атакой");
            for (int i = 0; i < Chaptres.Count; i++)
            {
                Console.WriteLine($"({i + 1}) {Chaptres[i].Name}");
            }
            int choice = int.Parse(Console.ReadLine());
            if (Chaptres[choice - 1].CurrencyMana - Chaptres[choice - 1].MaxMana * 0.2 >= 0)
            {
                if (attunit.M_CritChance >= z.Next(0, 100))
                {
                    Chaptres[choice - 1].CurrencyHealth -= attunit.M_CritDamage * (attunit.M_CritDamage / Chaptres[choice - 1].M_Defense);
                    Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrencyHealth} hp после КРИТИЧЕСКОЙ атаки {attunit.Name} в размере {attunit.M_CritDamage * (attunit.M_CritDamage / Chaptres[choice - 1].M_Defense)} урона ");
                    attunit.CurrencyMana -= attunit.MaxMana * 0.2;
                    Console.WriteLine($"Было израсходовано 20% от максимальной маны, сейчас осталось: {attunit.CurrencyMana} маны ");

                    if (Chaptres[choice-1].CurrencyHealth <= 0)
                    {
                        Chaptres.Remove(Chaptres[choice-1]);
                    }

                    
                }
                else
                {
                    Chaptres[choice - 1].CurrencyHealth -= attunit.M_Attack * (attunit.M_Attack / Chaptres[choice - 1].M_Defense);
                    Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrencyHealth} hp после атаки {attunit.Name} в размере {attunit.M_Attack * (attunit.M_Attack / Chaptres[choice - 1].M_Defense)} урона");
                    attunit.CurrencyMana -= attunit.MaxMana * 0.2;
                    Console.WriteLine($"Было израсходовано 20% от максимальной маны, сейчас осталось: {attunit.CurrencyMana} маны ");

                    if (Chaptres[choice - 1].CurrencyHealth <= 0)
                    {
                        Chaptres.Remove(Chaptres[choice - 1]);
                    }

                }
            }
        }
        public static void PAttack(Unit attunit, List<Unit> Chaptres)
        {
            Random z = new Random();
            Console.WriteLine("Выберите персонажа, которого хотите атаковать.");
            for (int i = 0; i < Chaptres.Count; i++)
            {
                Console.WriteLine($"({i + 1}) {Chaptres[i].Name}");
            }
            int choice = int.Parse(Console.ReadLine());
            if (attunit.P_CritChance >= z.Next(0, 100))
            {
                Chaptres[choice - 1].CurrencyHealth -= attunit.P_CritDamage * (attunit.P_CritDamage / Chaptres[choice - 1].P_Defense);
                Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrencyHealth} hp после КРИТИЧЕСКОЙ атаки {attunit.Name} в размере {attunit.P_CritDamage * (attunit.P_CritDamage / Chaptres[choice - 1].P_Defense)} урона");
                if (Chaptres[choice - 1].CurrencyHealth <= 0)
                {
                    Chaptres.Remove(Chaptres[choice - 1]);
                }
            }
            else
            {
                Chaptres[choice - 1].CurrencyHealth -= attunit.P_Attack * (attunit.P_Attack / Chaptres[choice - 1].P_Defense);
                Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrencyHealth} hp после атаки {attunit.Name} в размере урона {attunit.P_Attack * (attunit.P_Attack / Chaptres[choice - 1].P_Defense)}");
                if (Chaptres[choice - 1].CurrencyHealth <= 0)
                {
                    Chaptres.Remove(Chaptres[choice - 1]);
                }
            }

        }
        public static void DeBuff(string message)
        {
            Console.WriteLine(message);

        }

        public static Unit operator +(Unit objectOne, Unit object2)
        {
            return new Unit(objectOne.Strength + object2.Strength, objectOne.Dexterity + object2.Dexterity, objectOne.Intelligence + object2.Intelligence, objectOne.Constitution + object2.Constitution, "Парный юнит (ПАРНАЯ АТАКА)");

        }
        public static void DualAttack(List<Unit> Chaptres)
        {
            Console.WriteLine("Выберите юнитов, которыми хотите совершить ПАРНУЮ атаку (в таком случае их характеристики сложатся.");
            for (int i = 0; i < Chaptres.Count; i++)
            {
                Console.WriteLine($"({i + 1}) {Chaptres[i].Name}");
            }
            int choice1 = int.Parse(Console.ReadLine());
            int choice2 = int.Parse(Console.ReadLine());
            Unit DualAttack = new Unit(0, 0, 0, 0, "парный");
            DualAttack = Chaptres[choice1 - 1] + Chaptres[choice2 - 1];

            DualAttack.P_Attack = (DualAttack.Strength * 3 + DualAttack.Dexterity * 0.5)/2;
            DualAttack.P_CritChance = (20 + DualAttack.Dexterity * 0.3) / 1.5;
            Console.WriteLine(DualAttack.P_CritChance);
            DualAttack.P_CritDamage = DualAttack.P_Attack * (2 + (DualAttack.Dexterity/200) * 0.05);

            Unit.PAttack(DualAttack, Chaptres);

        }
    }
    
}
