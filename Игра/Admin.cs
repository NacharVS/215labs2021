using System;
using System.Collections.Generic;
using System.Text;

namespace Игра
{
    public class Client2
    {
        private string _name;
        private string _surname;
        private int _ID;
        private int _BallansDollars; public static int _BallansDollarsMax = 10000;
        private int _BallansRubles; public static int _BallansRublesMax = 750000;

        public int BallansDollars { get => _BallansDollars; set => _BallansDollars = value; }
        public int BallansRubles { get => _BallansRubles; set => _BallansRubles = value; }
        public void Popolnenue(int BallansDollars, int BallansRubles)
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
                                if (VvodBalut == "D" & VvodSum + BallansDollars >= _BallansDollarsMax)
                                {
                                    Console.WriteLine("Сумма превышает лимит счёта");
                                    Ostatoc = VvodSum + BallansDollars - _BallansDollarsMax;
                                    BallansDollars += VvodSum - Ostatoc;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - { BallansDollars } / { _BallansDollarsMax }, Остаток - {Ostatoc}");
                                    Ostatoc = 0;
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }

                                if (VvodBalut == "R" & VvodSum + BallansRubles >= _BallansRublesMax)
                                {
                                    Console.WriteLine("Сумма превышает лимит счёта");
                                    Ostatoc = VvodSum + BallansRubles - _BallansRublesMax;
                                    BallansRubles += VvodSum - Ostatoc;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - { BallansRubles } / { _BallansRublesMax }, Остаток - {Ostatoc}");
                                    Ostatoc = 0;
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }


                                if (VvodBalut == "D" & VvodSum + BallansDollars < _BallansDollarsMax)
                                {
                                    BallansDollars = VvodSum + BallansRubles;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - { BallansDollars } / { _BallansDollarsMax }, Остаток - {Ostatoc}");
                                    Console.WriteLine("Будет ли повторная операция(Y/Любая кнопка)");
                                    string Vvod = Console.ReadLine();
                                    if (Vvod != "Y")
                                    {
                                        FlagPopolnenue2 = "N";
                                    }
                                }

                                if (VvodBalut == "R" & VvodSum + BallansRubles < _BallansRublesMax)
                                {
                                    BallansRubles = VvodSum + BallansRubles;
                                    Console.WriteLine($"Зачисление успешно, ваш балланс - { BallansRubles } / {  _BallansRublesMax }, Остаток - {Ostatoc}");
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
                }

            }
        }

        public void PopolnenueClient(Client2 guest, int BallansDollars, int BallansRubles)
        {

        }
    }

}
