using System;
using System.Collections.Generic;

namespace RPG
{
	public class character
	{
		public int Damage_Enemy;
		public string Name;
		public int HP;
		public int Armor;
		public int Damage;
		public int Magic_Resist;
		public int Magic_Damage;
		public int HP_Enemy;
		public int Armor_Enemy;
		public int b;
		public int a;
		public character(string name, int hp, int armor, int damage)
		{
			Name = name;
			HP = hp;
			Armor = armor;
			Damage = damage;
			Magic_Damage = damage;
		}
		public character(string name, int hp, int armor)
		{
			Name = name;
			Armor = armor;
		}
		public character(string name, int hp, int armor, int damage, int magic_resist)
		{
			Name = name;
			HP = hp;
			Armor = armor;
			Damage = damage;
			Magic_Resist = magic_resist;
		}
		public virtual void Attack(int s, int t, double HP_Enemy, int Armor_Enemy, string Name, string name)
		{
			while (HP > 0 && HP_Enemy > 0)
			{
				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 1:
						HP += Armor - s;
						if (HP <= 0)
						{
							HP = 0;
						}
						Console.WriteLine(HP + " Здоровье " + name + "а");
						HP_Enemy += Armor_Enemy - t;
						if (HP_Enemy <= 0)
						{
							HP_Enemy = 0;
						}
						break;
					case 2:
						HP += Armor - 2 - s;
						if (HP <= 0)
						{
							HP = 0;
						}
						Console.WriteLine(HP + " Здоровье " + name + "а");
						HP_Enemy += Armor_Enemy - 2 * t;
						if (HP_Enemy <= 0)
						{
							HP_Enemy = 0;
						}
						break;
				}
				Console.WriteLine(HP_Enemy + " Здоровье " + Name + "а");
				if (HP_Enemy == 0)
					Console.WriteLine(Name + "\r\n" + " ПОВЕРЖЕН");
				if (HP == 0)
					Console.WriteLine(name + "\r\n" + "ПОВЕРЖЕН");
				if (HP == 0 && HP_Enemy == 0)
					Console.WriteLine("Тьма поглотила всех");
			}
		}
	}
	public class Warrior : character
	{
		public Warrior(string name, int hp, int armor, int damage) : base(name, hp, armor, damage) { }
		public override void Attack(int s, int t, double HP_Enemy, int Armor_Enemy, string Name, string name)
		{
			base.Attack(s, t, HP_Enemy, Armor_Enemy, Name, name);
		}
	}
	public class Archer : character
	{
		public Archer(string name, int hp, int armor, int damage, int magic_resist) : base(name, hp, armor, damage, magic_resist) { }
		public override void Attack(int s, int t, double HP_Enemy, int Armor_Enemy, string Name, string name)
		{
			base.Attack(s, t, HP_Enemy, Armor_Enemy, Name, name);
		}
	}
	public class Mage : character
	{
		public Mage(string name, int hp, int armor, int damage) : base(name, hp, armor, damage)
		{ }
		public override void Attack(int s, int t, double HP_Enemy, int Armor_Enemy, string Name, string name)
		{
			base.Attack(s, t, HP_Enemy, Armor_Enemy, Name, name);
		}
	}
	public class programm
	{
        private const string V = "Mage";

        public static void Main(string[] args)
		{
			int a;
			int b;
			int c = 0;
			int d = 0;
			double e = 0;
			int f = 0;
			string g = "a";
			string h = "b";
			Archer Archer1 = new Archer("Archer", 45, 5, 7, 20);
			Mage Mage1 = new Mage(V, 45, 0, 25);
			Warrior Warrior1 = new Warrior("Warrior", 50, 4, 10);
			Archer Enemy1 = new Archer("Strangers", 20, 2, 10, 7);
			while (true)
			{
				Console.WriteLine("Режим игры: " + "\r\n" + "1.Арена");
				try
				{
					switch (Convert.ToInt32(Console.ReadLine()))
					{
						case 1:
							{
								while (true)
								{
									try
									{
										//Выбираем персонажа
										Console.WriteLine("Выбор воина:" + "\r\n" + "1.Warrior" + "\r\n" + "2.Archer" + "\r\n" + "3.Mage" + "\r\n");
										a = Convert.ToInt32(Console.ReadLine());
										//Выбираем противника
										Console.WriteLine("Выберите противника:" + "\r\n" + "1.Warrior" + "\r\n" + "2.Archer" + "\r\n" + "3.Mage" + "\r\n");
										b = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine("\r\nНачать бой? (Y - начать, N - Выход)");
										if (Console.ReadKey(true).Key == ConsoleKey.N) Environment.Exit(0);
										Console.WriteLine("Тип атаки :" + "\r\n" + "Клавиша 1-Обычный удар" + "\r\n" + "-Повышает урон 2x" + "\r\n" + "Клавиша 2 - Мощный удар " + "\r\n" + "-Снижает класс брони на -2");
										if (b == 1)
										{
											g = Warrior1.Name;
											c = Warrior1.Damage;
											f = Warrior1.Armor;
											e = 50;
										}
										else if (b == 2)
										{
											g = Archer1.Name;
											c = Archer1.Damage;
											f = Archer1.Armor;
											if (a == 3)
												f = Archer1.Magic_Resist;
											e = 45;
										}
										else if (b == 3)
										{
											g = Mage1.Name;
											Enemy1.Armor = Enemy1.Magic_Resist;
											Archer1.Armor = Archer1.Magic_Resist;
											c = Mage1.Magic_Damage;
											f = Mage1.Armor;
											e = 40;
										}
										if (a == 1)
										{
											h = "Warrior";
											d = Warrior1.Damage;
											Warrior1.Attack(c, d, e, f, g, h);
										}
										if (a == 2)
										{
											h = "Archer";
											d = Archer1.Damage;
											Archer1.Attack(c, d, e, f, g, h);
										}
										if (a == 3)
										{
											h = "Mage";
											d = Mage1.Magic_Damage;
											Enemy1.Armor = Enemy1.Magic_Resist;
											Archer1.Armor = Archer1.Magic_Resist;
											Mage1.Attack(c, d, e, f, g, h);
										}
									}
									catch (Exception)
									{
										Console.WriteLine();
									}
								}
							}
					}
				}
				catch (Exception)
				{
					Console.WriteLine();
				}
			}
		}
	}
}
