﻿//using System;

//namespace Units
//{
//    public class Unit
//    {
//        public string name;
//        public int CurrentHealth;
//        public int MaxHealth;
//        public int MinDamage;
//        public int MaxDamage;
//        public int CurrentArrows;
//        public int Healing;
//        public int range;
//        public int armor;
//        public int speed;
//        public int atackspeed;
//        public int workspeed;
//        public int MinRangeDamage;
//        public int MaxRangeDamage;

//    }

//    class BuilderPeacful : Unit
//    {
//        public BuilderPeacful(string namec, int MaxHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
//        {
//            name = namec;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            speed = speedc;
//            workspeed = workspeedc;
//        }
//        public static void Moving(string namec)
//        {
//            Console.WriteLine($"{namec} идёт строить");
//        }

//    }

//    class WoodmanPeacful : Unit
//    {
//        public WoodmanPeacful(string namec, int MaxHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
//        {
//            name = namec;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            speed = speedc;
//            workspeed = workspeedc;
//        }
//        public static void Moving(string namec)
//        {
//            Console.WriteLine($"{namec} идёт добывать дерево");
//        }

//    }

//    class MinerPeacful : Unit
//    {
//        public MinerPeacful(string namec, int MaxHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
//        {
//            name = namec;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            speed = speedc;
//            workspeed = workspeedc;
//        }
//        public static void Moving(string namec)
//        {
//            Console.WriteLine($"{namec} идёт добывать камень");
//        }

//    }

//    class Warrior : Unit
//    {
//        public Warrior(string namec, int MaxHealthc, int CurrentHealthWarrior, int MinDamagec, int MaxDamagec, int armorc, int speedc, int atackspeedc)
//        {
//            name = namec;
//            CurrentHealth = CurrentHealthWarrior;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            speed = speedc;
//            atackspeed = atackspeedc;
//        }
//        public static void Damage(string namec, int MinDamagec, int MaxDamagec)
//        {
//            int damage = new Random().Next(MinDamagec, MaxDamagec);
//            Console.WriteLine($"{namec} нанёс {damage} урона");
//        }

//    }

//    class Healer : Unit
//    {
//        public Healer(string namec, int MaxHealthc, int CurrentHealthMage, int MinDamagec, int MaxDamagec, int MinRangeDamagec, int MaxRangeDamagec, int armorc, int rangec, int speedc, int atackspeedc, int Healingc)
//        {
//            name = namec;
//            CurrentHealth = CurrentHealthMage;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            range = rangec;
//            speed = speedc;
//            atackspeed = atackspeedc;
//            Healing = Healingc;
//            MinRangeDamage = MinRangeDamagec;
//            MaxRangeDamage = MaxRangeDamagec;
//        }
//        public static void MageVSArcherAndHealer(string namec, int MaxHealth, int CurrentHealthMage, int MinDamagec, int MaxDamagec, string MobName,int MinRangeDamagec, int MaxRangeDamagec, int CurrentHealth, int CurrentArrows, int Healingc)
//        {
//            Console.WriteLine($"Бой между {namec} и {MobName}, но здесь ещё присутствует Healer");
//            Console.WriteLine();
//            while (CurrentHealth >= 0 || CurrentHealthMage >= 0)
//            {

//                if (CurrentHealth > 0 && CurrentHealthMage > 0)
//                {
//                    int MageRanageDamage = new Random().Next(MinDamagec, MaxDamagec);
//                    int ArcherDamageMelee = new Random().Next(MinDamagec, MaxDamagec);
//                    int ArcherDamageRanage = new Random().Next(MinRangeDamagec, MaxRangeDamagec);

//                    Console.WriteLine($"{namec} нанёс {MageRanageDamage} урона в дальнем бою {MobName}");
//                    CurrentHealth -= MageRanageDamage;

//                    if (CurrentHealth < 0)
//                    {
//                        CurrentHealth = 0;
//                    }

//                    Console.WriteLine($"У {MobName} осталось {CurrentHealth} xp");

//                    if (CurrentArrows != 0)
//                    {
//                        Console.WriteLine($"{MobName} нанёс {ArcherDamageRanage} урона в дальнем бою {namec}");
//                        CurrentHealthMage -= ArcherDamageRanage;
//                        CurrentArrows--;

//                        if (CurrentHealthMage < 0)
//                        {
//                            CurrentHealthMage = 0;
//                        }

//                        Console.WriteLine($"У {namec} осталось {CurrentHealthMage} xp");
//                        Console.WriteLine($"Оставшиеся стрелы у лучника: {CurrentArrows}");
//                        Console.WriteLine();
//                    }
//                    else
//                    {

//                        Console.WriteLine($"{MobName} нанёс {ArcherDamageMelee} урона в ближнем бою {namec}");
//                        CurrentHealthMage -= ArcherDamageMelee;

//                        if (CurrentHealthMage < 0)
//                        {
//                            CurrentHealthMage = 0;
//                        }

//                        Console.WriteLine($"У {namec} осталось {CurrentHealthMage} xp");
//                    }
//                    Console.WriteLine();
//                    Console.WriteLine("Выберите кого вы хотите отхилить: Маг - 1, Лучник - 2");
//                    int choice = int.Parse(Console.ReadLine());
//                    if (choice == 1)
//                    {
//                        CurrentHealthMage += Healingc;
//                    }
//                    if (choice == 2)
//                    {
//                        CurrentHealth += Healingc;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Надо было ввести 1 или 2");
//                        Console.WriteLine();
//                    }
//                }
//                else
//                {
//                    if (CurrentHealth <= 0)
//                    {
//                        Console.WriteLine($"{MobName} погиб");
//                        Console.WriteLine();
//                    }
//                    else
//                    {
//                        Console.WriteLine($"{namec} погиб");
//                        Console.WriteLine();
//                    }
//                    break;
//                }
//            }
//        }
//    }


//    class ArcherWarrior : Unit
//    {
//        public ArcherWarrior(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int MinRangeDamagec, int MaxRangeDamagec, int armorc, int rangec, int speedc, int atackspeedc, int CurrentArrowsc)
//        {
//            name = namec;
//            CurrentHealth = CurrentHealthc;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            range = rangec;
//            speed = speedc;
//            atackspeed = atackspeedc;
//            MinRangeDamage = MinRangeDamagec;
//            MaxRangeDamage = MaxRangeDamagec;
//            CurrentArrows = CurrentArrowsc;
//        }
//        public static void ArcherDamage(string namec, int MinRangeDamagec, int MaxRangeDamagec, int MinDamagec, int MaxDamagec, string MobName, int MaxHealthc, int CurrentHealthc, int armorc, int CurrentArrows,int CurrentHealthWarrior)
//        {
//            Console.WriteLine($"Бой между {namec} и {MobName}");
//            Console.WriteLine();
//            int CurrentHealthWarriorArmor = CurrentHealthWarrior + armorc;
//            while (CurrentHealthc >= 0 && CurrentHealthWarriorArmor >= 0)
//            {

//                if (CurrentHealthc > 0 && CurrentHealthWarriorArmor > 0)
//                {
//                    int ArcherDamageMelee = new Random().Next(MinDamagec, MaxDamagec);
//                    int ArcherDamageRange = new Random().Next(MinRangeDamagec, MaxRangeDamagec);

//                    if (CurrentArrows != 0)
//                    {
//                        Console.WriteLine($"{namec} нанёс {ArcherDamageRange} урона в дальнем бою {MobName}");
//                        CurrentHealthWarriorArmor -= ArcherDamageRange;
//                        if (CurrentHealthWarriorArmor <= MaxHealthc)
//                        {
//                           Console.WriteLine($"Броня {MobName} разбита");
                                                
//                        }

//                        if (CurrentHealthWarriorArmor < 0)
//                        {
//                            CurrentHealthWarriorArmor = 0;
//                        }

//                        Console.WriteLine($"У {MobName} осталось {CurrentHealthWarriorArmor} xp");
//                        CurrentArrows--;
//                        Console.WriteLine($"Оставшиеся стрелы у лучника: {CurrentArrows}");
//                        Console.WriteLine();
//                    }
//                    else
//                    {
//                        Console.WriteLine($"{namec} нанёс {ArcherDamageMelee} урона в ближнем бою {MobName}");
//                        CurrentHealthWarriorArmor -= ArcherDamageMelee;

//                        if (CurrentHealthWarriorArmor <= MaxHealthc)
//                        {
//                            Console.WriteLine($"Броня {MobName} разбита");
//                        }

//                        if (CurrentHealthWarriorArmor < 0)
//                        {
//                            CurrentHealthWarriorArmor = 0;
//                        }

//                        Console.WriteLine($"У {MobName} осталось {CurrentHealthWarriorArmor} xp");
//                        Console.WriteLine();
//                    }
//                }
//                else 
//                {
//                    Console.WriteLine($"{MobName} погиб");
//                    Console.WriteLine();
//                    Console.WriteLine();
//                    Console.WriteLine();
//                    break;
//                }
//            }
//        }
//    }


//    class MageWarrior : Unit
//    {
//        public MageWarrior(string namec, int MaxHealthc, int CurrentHealthMage, int MinDamagec, int MaxDamagec, int MinRangeDamagec, int MaxRangeDamagec, int armorc, int rangec, int speedc, int atackspeedc)
//        {
//            name = namec;
//            CurrentHealth = CurrentHealthMage;
//            MaxHealth = MaxHealthc;
//            MinDamage = MinDamagec;
//            MaxDamage = MaxDamagec;
//            armor = armorc;
//            range = rangec;
//            speed = speedc;
//            atackspeed = atackspeedc;
//            MinRangeDamage = MinRangeDamagec;
//            MaxRangeDamage = MaxRangeDamagec;
//        }

//        public static void MageVSArcher(string namec, int MaxHealth, int CurrentHealthMage, int MinDamagec, int MaxDamagec,string MobName, int MinRangeDamagec, int MaxRangeDamagec, int CurrentHealth, int CurrentArrows)
//        {
//            Console.WriteLine($"Хотите посмотреть кто сильнее {namec} или {MobName}, только без восстановления xp? 1 - да, 2 - нет");
//            int WhoIsStronger = int.Parse(Console.ReadLine());

//            if (WhoIsStronger == 1)
//            {
//                Console.WriteLine($"Бой между {namec} и {MobName}");
//                Console.WriteLine();
//                while (CurrentHealth >= 0 || CurrentHealthMage >= 0)
//                {

//                    if (CurrentHealth > 0 && CurrentHealthMage > 0)
//                    {
//                        int MageRanageDamage = new Random().Next(MinDamagec, MaxDamagec);
//                        int ArcherDamageMelee = new Random().Next(MinDamagec, MaxDamagec);
//                        int ArcherDamageRanage = new Random().Next(MinRangeDamagec, MaxRangeDamagec);

//                        Console.WriteLine($"{namec} нанёс {MageRanageDamage} урона в дальнем бою {MobName}");
//                        CurrentHealth -= MageRanageDamage;

//                        if (CurrentHealth < 0)
//                        {
//                            CurrentHealth = 0;
//                        }

//                        Console.WriteLine($"У {MobName} осталось {CurrentHealth} xp");

//                        if (CurrentArrows != 0)
//                        {
//                            Console.WriteLine($"{MobName} нанёс {ArcherDamageRanage} урона в дальнем бою {namec}");
//                            CurrentHealthMage -= ArcherDamageRanage;
//                            CurrentArrows--;

//                            if (CurrentHealthMage < 0)
//                            {
//                                CurrentHealthMage = 0;
//                            }

//                            Console.WriteLine($"У {namec} осталось {CurrentHealthMage} xp");
//                            Console.WriteLine($"Оставшиеся стрелы у лучника: {CurrentArrows}");
//                            Console.WriteLine();
//                        }
//                        else
//                        {

//                            Console.WriteLine($"{MobName} нанёс {ArcherDamageMelee} урона в ближнем бою {namec}");
//                            CurrentHealthMage -= ArcherDamageMelee;

//                            if (CurrentHealthMage < 0)
//                            {
//                                CurrentHealthMage = 0;
//                            }

//                            Console.WriteLine($"У {namec} осталось {CurrentHealthMage} xp");
//                        }
//                        Console.WriteLine();
//                    }
//                    else
//                    {
//                        if (CurrentHealth < 0)
//                        {
//                            Console.WriteLine($"{MobName} погиб");
//                            Console.WriteLine();
//                        }
//                        else
//                        {
//                            Console.WriteLine($"{namec} погиб");
//                            Console.WriteLine();
//                        }
//                        break;
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine();
//                Console.WriteLine("Ну как хотите");
//                Console.WriteLine();
//            }
//        }
//    }
//}
