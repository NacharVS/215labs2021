using System;
using System.Collections.Generic;
using System.Text;
using Labs215Y2K;
using System;
using System.Collections.Generic;
using System.Text;


namespace Labs215Y2K

{
    class Program
    {





        public static void Main()
        {

            //    Account acc = new Account("Данил", 10000000, 1);



            //    Account acc1 = new Account("Ivan", 5000, new Random().Next(1234, 9876));
            //    Account acc2 = new Account("Fedor", 6000, new Random().Next(1234, 9876));
            //    Account acc3 = new Account("Elena", 3000, new Random().Next(1234, 9876));
            //    Console.WriteLine("Введите новое имя ");
            //    acc1.NameChangeEvent += Show;
            //    string Vvod = Console.ReadLine();
            //    acc1.Name = Vvod;
            //    Console.WriteLine("Введите новое ID (ID Должно состоять из четырех цифр)");
            //    acc1.IDChangeEvent += ShoWID;
            //    int VvodId = int.Parse(Console.ReadLine());
            //    acc1.Id = VvodId;



            //    acc1.ShowInfo(acc1);
            //    acc2.ShowInfo(acc2);
            //    acc3.ShowInfo(acc3);
            //    Console.WriteLine();
            //    Account.rate = 0.06;
            //    Console.WriteLine();
            //    Console.WriteLine("Введите количество месяцев");
            //    int mouth = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Через {mouth} меся(ц/ца/цев) Ваш баланс с коэффицентом {Account.rate} будет составлять:");
            //    acc1.ShowProfit(acc1, mouth);
            //    acc2.ShowProfit(acc2, mouth);
            //    acc3.ShowProfit(acc3, mouth);
            //    acc1.ShowInfo(acc1);
            //    acc2.ShowInfo(acc2);
            //    acc3.ShowInfo(acc3);
            //    acc3.Withdraw(acc3);
            //    acc3.ShowInfo(acc3);
            //    acc1.Deposit(acc1);
            //    acc1.ShowInfo(acc1);
            //    acc2.Transaction(acc1, acc2);
            //    acc2.ShowInfo(acc2);
            //    acc3.ShowInfo(acc3);


            //}

            //public static void Show(string a, string b)
            //{

            //    Console.WriteLine($"Новое имя {a}, старое {b}");
            //} 
            //public static void ShoWID(int a, int b)
            //{

            //    Console.WriteLine($"Новое id {a},и старое id {b}");
            //}



            List<Characters> CharactersP = new List<Characters>();
            CharactersP.Add(new Characters("Warrior", 30, 15, 10, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            CharactersP.Add(new Characters("Mage", 15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            CharactersP.Add(new Characters("Archer", 20, 30, 15, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            
            CharactersP[0].Health = 2 * CharactersP[0].Consitution + (5 / 10 * CharactersP[0].Strenght);
            CharactersP[1].Health = 2 * CharactersP[1].Consitution + (5 / 10 * CharactersP[1].Strenght);
            CharactersP[2].Health = 2 * CharactersP[2].Consitution + (5 / 10 * CharactersP[2].Strenght);

            CharactersP[0].Mana = CharactersP[0].Intelgence * 3;
            CharactersP[1].Mana = CharactersP[1].Intelgence * 3;
            CharactersP[2].Mana = CharactersP[2].Intelgence * 3;

            CharactersP[0].Pattack = CharactersP[0].Strenght * 3 + (5 / 10 * CharactersP[0].Dexterity);
            CharactersP[1].Pattack = CharactersP[1].Strenght * 3 + (5 / 10 * CharactersP[1].Dexterity);
            CharactersP[2].Pattack = CharactersP[2].Strenght * 3 + (5 / 10 * CharactersP[2].Dexterity);

            CharactersP[0].Pdefense = CharactersP[0].Consitution * (5 / 10) + CharactersP[0].Dexterity * 3;
            CharactersP[1].Pdefense = CharactersP[1].Consitution * (5 / 10) + CharactersP[1].Dexterity * 3;
            CharactersP[2].Pdefense = CharactersP[2].Consitution * (5 / 10) + CharactersP[2].Dexterity * 3;

            CharactersP[0].Mattack = CharactersP[0].Intelgence * 4;
            CharactersP[1].Mattack = CharactersP[1].Intelgence * 4;
            CharactersP[2].Mattack = CharactersP[2].Intelgence * 4;

            CharactersP[0].Mdefense = CharactersP[0].Intelgence * 2;
            CharactersP[1].Mdefense = CharactersP[1].Intelgence * 2;
            CharactersP[2].Mdefense = CharactersP[2].Intelgence * 2;

            CharactersP[0].Pcchanse = 20 + CharactersP[0].Dexterity * 3;
            CharactersP[1].Pcchanse = 20 + CharactersP[1].Dexterity * 3;
            CharactersP[2].Pcchanse = 20 + CharactersP[2].Dexterity * 3;

            CharactersP[0].Mcchanse = 20 + CharactersP[0].Intelgence * (1 / 10);
            CharactersP[1].Mcchanse = 20 + CharactersP[1].Intelgence * (1 / 10);
            CharactersP[2].Mcchanse = 20 + CharactersP[2].Intelgence * (1 / 10);

            CharactersP[0].Pcdamage = CharactersP[0].Pattack * (2 + CharactersP[0].Dexterity * (5 / 100));
            CharactersP[1].Pcdamage = CharactersP[1].Pattack * (2 + CharactersP[1].Dexterity * (5 / 100));
            CharactersP[2].Pcdamage = CharactersP[2].Pattack * (2 + CharactersP[2].Dexterity * (5 / 100));

            CharactersP[0].Mcdamage = CharactersP[0].Mattack * (2 + CharactersP[0].Intelgence * (15 / 100));
            CharactersP[1].Mcdamage = CharactersP[1].Mattack * (2 + CharactersP[1].Intelgence * (15 / 100));
            CharactersP[2].Mcdamage = CharactersP[2].Mattack * (2 + CharactersP[2].Intelgence * (15 / 100));

            foreach (var item in CharactersP)
            {
                Console.WriteLine($"Класс - {item.Name}, сила - {item.Strenght}, ловкость - {item.Dexterity}, интелект - {item.Intelgence}, тело сложение - {item.Consitution}, хп - {item.Health}, мана - {item.Mana}, атака - {item.Pattack}, защита - {item.Pdefense}, маг.атака - {item.Mattack}, маг.защита - {item.Mdefense}, физ.шанс - {item.Pcchanse}, физ.крит - {item.Pcdamage}, маг.шанс - {item.Mcchanse}, маг.крит - {item.Mcdamage}");
            }

            Console.WriteLine();
            Console.WriteLine("Выберите персонажа 1 - Войн 2 - Маг 3 - Лучник") ;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Вы выбрали песонажа Воин");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали песонажа Маг");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали песонажа Лучник");
                    break;
                   
            }
            Console.WriteLine();
            Console.WriteLine("1.Посмотреть характеристики персонажей 2.Вернуться к выбору персонажа 3.начать игру");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    foreach (var item in CharactersP)
                    {
                        Console.WriteLine($"Имя - {item.Name}, сила - {item.Strenght}, ловкость - {item.Dexterity}, интелект - {item.Intelgence}, тело сложение - {item.Consitution}, хп - {item.Health}, мана - {item.Mana}, атака - {item.Pattack}, защита - {item.Pdefense}, маг.атака - {item.Mattack}, маг.защита - {item.Mdefense}, физ.шанс - {item.Pcchanse}, физ.крит - {item.Pcdamage}, маг.шанс - {item.Mcchanse}, маг.крит - {item.Mcdamage}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Выберите персонажа 1 - Войн 2 - Маг 3 - Лучник");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Вы выбрали песонажа Воин");
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали песонажа Маг");
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали песонажа Лучник");
                            break;

                    }
                    break;
                case 3:
              
                    break;

            }

















        }




    } 
    

    
}
