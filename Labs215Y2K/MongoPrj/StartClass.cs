using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoPrj
{
    class StartClass
    {
        public static void Start()
        {
            Console.WriteLine("Добро пожаловать в базу данных студентов!");
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Добавить студентов в базу данных");
            Console.WriteLine("2 - Искать студента по параметру");
            Console.WriteLine("3 - Просмотреть списки студентов");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Examples.Start();
                    StartClass.Start();
                    break;
                case 2:
                    FindClass.Start();
                    break;
                case 3:
                    Console.Write("Введите курс для просмотра списка: ");
                    int coursechoose = int.Parse(Console.ReadLine());
                    if (coursechoose < 1 || coursechoose > 4)
                    {
                        while (coursechoose < 1 || coursechoose > 4)
                        {
                            Console.Write("Неверный курс! Введите курс заново: ");
                            coursechoose = int.Parse(Console.ReadLine());
                            if (coursechoose > 1 | coursechoose < 4)
                            {
                                if (coursechoose == 1)
                                {
                                    Examples.StudentsFirstCourse();
                                    StartClass.Start();
                                    break;
                                }
                                else if (coursechoose == 2)
                                {
                                    Examples.StudentsSecondCourse();
                                    StartClass.Start();
                                    break;
                                }
                                else if (coursechoose == 3)
                                {
                                    Examples.StudentsThirdCourse();
                                    StartClass.Start();
                                    break;
                                }
                                else if (coursechoose == 4)
                                {
                                    Examples.StudentsFourCourse();
                                    StartClass.Start();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (coursechoose > 1 | coursechoose < 4)
                    {
                        if (coursechoose == 1)
                        {
                            Examples.StudentsFirstCourse();
                            StartClass.Start();
                            break;
                        }
                        else if (coursechoose == 2)
                        {
                            Examples.StudentsSecondCourse();
                            StartClass.Start();
                            break;
                        }
                        else if (coursechoose == 3)
                        {
                            Examples.StudentsThirdCourse();
                            StartClass.Start();
                            break;
                        }
                        else if (coursechoose == 4)
                        {
                            Examples.StudentsFourCourse();
                            StartClass.Start();
                            break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    StartClass.Start();
                    break;
            }
        }
    }
}
