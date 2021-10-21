using System;
using Labs215Y2K;

namespace Units
{
    public class Unit
    {
        public string name;
        public int CurrentHealth;
        public int MaxHealth;
        public int MinDamage;
        public int MaxDamage;
        public int CurrentArrows;
        public int Healing;
        public int range;
        public int armor;
        public int speed;
        public int atackspeed;
        public int workspeed;
        public int MinRangeDamage;
        public int MaxRangeDamage;

    }
    class BuilderPeacful : Unit
    {
        public BuilderPeacful(string namec, int MaxHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
        {
            name = namec;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            workspeed = workspeedc;
        }
        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт строить");
        }

    }

    class WoodmanPeacful : Unit
    {
        public WoodmanPeacful(string namec, int MaxHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
        {
            name = namec;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            workspeed = workspeedc;
        }
        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт добывать дерево");
        }

    }
    class MinerPeacful : Unit
    {
        public MinerPeacful(string namec, int MaxHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
        {
            name = namec;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            workspeed = workspeedc;
        }
        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт добывать камень");
        }

    }

    class Warrior : Unit
    {
        public Warrior(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public static void Damage(string namec, int MinDamagec, int MaxDamagec)
        {
            int damage = new Random().Next(MinDamagec, MaxDamagec);
            Console.WriteLine($"{namec} нанёс {damage} урона");
        }

    }
    class Healer : Unit
    {
        public Healer(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int atackspeedc, int Healingc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
            Healing = Healingc;
        }

        //public static void HealerRestoresHealth(string namec, int Healingc, string MobName, int CurrentHealthc, int MaxHealthc)
        //{
        //    while (CurrentHealthc < MaxHealthc)
        //    {
        //        if (CurrentHealthc < MaxHealthc)
        //        {
        //            Console.WriteLine($"{namec} восстановил здоровье {MobName}");
        //            CurrentHealthc += Healingc;
        //            Console.WriteLine($"У {MobName} теперь {CurrentHealthc} xp");
        //            Console.WriteLine();
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Здоровье {MobName} восстановлено");
        //            break;
        //        }
        //    }
        //}

    }


    class ArcherWarrior : Unit
    {
        public ArcherWarrior(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int MinRangeDamagec, int MaxRangeDamagec, int armorc, int rangec, int speedc, int atackspeedc, int CurrentArrowsc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            range = rangec;
            speed = speedc;
            atackspeed = atackspeedc;
            MinRangeDamage = MinRangeDamagec;
            MaxRangeDamage = MaxRangeDamagec;
            CurrentArrows = CurrentArrowsc;
        }

        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт");
        }
        public static void ArcherDamage(string namec, int MinRanageDamagec, int MaxRangeDamagec, int MinDamagec, int MaxDamagec, string MobName, int CurrentHealth, int CurrentArrows)
        {
            while (CurrentHealth != 0)
            {

                if (CurrentHealth > 0)
                {

                    if (CurrentArrows != 0)
                    {
                        int ArcerRanageDamage = new Random().Next(MinRanageDamagec, MaxRangeDamagec);
                        Console.WriteLine($"{namec} нанёс {ArcerRanageDamage} урона в дальнем бою {MobName}");
                        CurrentHealth -= ArcerRanageDamage;
                        Console.WriteLine($"У {MobName} осталось {CurrentHealth} xp");
                        CurrentArrows--;
                        Console.WriteLine($"Оставшиеся стрелы у лучника: {CurrentArrows}");
                        Console.WriteLine();
                    }
                    else
                    {
                        int ArcherDamageMelee = new Random().Next(MinDamagec, MaxDamagec);
                        Console.WriteLine($"{namec} нанёс {ArcherDamageMelee} урона в ближнем бою {MobName}");
                        CurrentHealth -= ArcherDamageMelee;
                        Console.WriteLine($"У {MobName} осталось {CurrentHealth} xp");
                    }
                }
                else 
                {
                    Console.WriteLine($"{MobName} погиб");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }


    class MageWarrior : Unit
    {
        public MageWarrior(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int MinRangeDamagec, int MaxRangeDamagec, int armorc, int rangec, int speedc, int atackspeedc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            range = rangec;
            speed = speedc;
            atackspeed = atackspeedc;
            MinRangeDamage = MinRangeDamagec;
            MaxRangeDamage = MaxRangeDamagec;
        }
        public static void MageVSArcher(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec,string MobName, int MinRangeDamagec, int MaxRangeDamagec, int CurrentHealth, int CurrentArrows)
        {
            while (CurrentHealth != 0)
            {

                if (CurrentHealth > 0)
                {

                        int MageRanageDamage = new Random().Next(MinDamagec, MaxDamagec);
                        Console.WriteLine($"{namec} нанёс {MageRanageDamage} урона в дальнем бою {MobName}");
                        CurrentHealth -= MageRanageDamage;
                        Console.WriteLine($"У {MobName} осталось {CurrentHealth} xp");
                        Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{MobName} погиб");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
