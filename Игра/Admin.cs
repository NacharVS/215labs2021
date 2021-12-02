using System;
using System.Collections.Generic;
using System.Text;

namespace Игра
{
    public class Admin
    {
        private string _name;
        private string _surname;
        private int _ID;
        public static int _BallansDollarsMax = 10000;
        public static int _BallansRublesMax = 750000;

        public void PopolnenueClient(Client guest)
        {
            string FlagPopolnenue1 = "Y";
            string FlagPopolnenue2 = "Y";

            while (FlagPopolnenue1 == "Y")
            {
                int VvodSum = 0;
                int Ostatoc = 0;
                Console.WriteLine("Какую валюту хотите использовать(R/D)");
                string VvodBalut = Console.ReadLine();
                if (VvodBalut == "D" | VvodBalut == "R")
                {
                    while (FlagPopolnenue2 == "Y")
                    {
                        try
                        {
                            Console.WriteLine("На какую сумму вы хотите пополнить балланс(число)");
                            VvodSum = int.Parse(Console.ReadLine());
                            if (VvodSum > 0)
                            {
                                if (VvodBalut == "D" & VvodSum + guest.BallansDollars >= _BallansDollarsMax)
                                {
                                    Console.WriteLine("Сумма превышает лимит счёта");
                                    Ostatoc = VvodSum + guest.BallansDollars - _BallansDollarsMax;
                                    guest.BallansDollars += VvodSum - Ostatoc;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - {  guest.BallansDollars } / { _BallansDollarsMax }, Остаток - {Ostatoc}");
                                    Ostatoc = 0;
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }

                                if (VvodBalut == "R" & VvodSum + guest.BallansRubles >= _BallansRublesMax)
                                {
                                    Console.WriteLine("Сумма превышает лимит счёта");
                                    Ostatoc = VvodSum + guest.BallansRubles - _BallansRublesMax;
                                    guest.BallansRubles += VvodSum - Ostatoc;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - {  guest.BallansRubles } / { _BallansRublesMax }, Остаток - {Ostatoc}");
                                    Ostatoc = 0;
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }


                                if (VvodBalut == "D" & VvodSum + guest.BallansDollars < _BallansDollarsMax)
                                {
                                    guest.BallansDollars = VvodSum + guest.BallansRubles;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - {  guest.BallansDollars } / { _BallansDollarsMax }, Остаток - {Ostatoc}");
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }

                                if (VvodBalut == "R" & VvodSum + guest.BallansRubles < _BallansRublesMax)
                                {
                                    guest.BallansRubles = VvodSum + guest.BallansRubles;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - {  guest.BallansRubles } / {  _BallansRublesMax }, Остаток - {Ostatoc}");
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }
                            }
                            if (VvodSum <= 0)
                            {
                                Console.WriteLine("Вы ввели отрицательную значение или 0");
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка - не коректный ввод");
                        }
                    }
                }
                if (VvodBalut != "D" | VvodBalut != "R")
                {
                    Console.WriteLine("Вы ввели не коректную валюту");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    FlagPopolnenue1 = "N";
                }

            }
        }

    }
}
