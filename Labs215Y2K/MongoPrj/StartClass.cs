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
            Console.WriteLine("4 - Поменять данные студента");
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
                case 4:
                    Console.Write("Введите курс для просмотра списка: ");
                    int coursechoose1 = int.Parse(Console.ReadLine());
                    if (coursechoose1 < 1 || coursechoose1 > 4)
                    {
                        while (coursechoose1 < 1 || coursechoose1 > 4)
                        {
                            Console.Write("Неверный курс! Введите курс заново: ");
                            coursechoose1 = int.Parse(Console.ReadLine());
                            if (coursechoose1 > 1 | coursechoose1 < 4)
                            {
                                if (coursechoose1 == 1)
                                {
                                    Examples.StudentsFirstCourse();
                                    ChooseFind(coursechoose1);
                                    break;
                                }
                                else if (coursechoose1 == 2)
                                {
                                    Examples.StudentsSecondCourse();
                                    ChooseFind(coursechoose1);
                                    break;
                                }
                                else if (coursechoose1 == 3)
                                {
                                    Examples.StudentsThirdCourse();
                                    ChooseFind(coursechoose1);
                                    break;
                                }
                                else if (coursechoose1 == 4)
                                {
                                    Examples.StudentsFourCourse();
                                    ChooseFind(coursechoose1);
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
                    else if (coursechoose1 > 1 | coursechoose1 < 4)
                    {
                        if (coursechoose1 == 1)
                        {
                            Examples.StudentsFirstCourse();
                            ChooseFind(coursechoose1);
                            break;
                        }
                        else if (coursechoose1 == 2)
                        {
                            Examples.StudentsSecondCourse();
                            ChooseFind(coursechoose1);
                            break;
                        }
                        else if (coursechoose1 == 3)
                        {
                            Examples.StudentsThirdCourse();
                            ChooseFind(coursechoose1);
                            break;
                        }
                        else if (coursechoose1 == 4)
                        {
                            Examples.StudentsFourCourse();
                            ChooseFind(coursechoose1);
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
        public static void ChooseFind(int coursechoose)
        {
            Console.Write("Вы хотите найти студента по имени или выйти? 1 - имя; 2 - выйти: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write("Напишите имя студента: ");
                    string namesearch = Console.ReadLine();
                    if (coursechoose == 1)
                    {
                        Examples.NameSearchFirstCourse(namesearch);
                        Console.Write("Введите имя для замены: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию для замены: ");
                        string surname = Console.ReadLine();
                        Console.Write("Введите отчество для замены (Если отчества нет, нажмите Enter): ");
                        string lastname = Console.ReadLine();
                        if (lastname == "")
                        {
                            lastname = null;
                        }
              
                        Console.Write("Введите возраст для замены (Если его нет , введите 0): ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Введите пол для замены (Если пола нет, нажмите Enter): ");
                        string gender = Console.ReadLine();
                        if (gender == "")
                        {
                            gender = null;
                        }
                        Console.Write("Введите год поступления (Если года нет, введите 0): ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Введите успеваемость для замены (Если ее нет, нажмите Enter): ");
                        string progress = Console.ReadLine();
                        if (progress == "")
                        {
                            progress = null;
                        }
                        Console.Write("Введите курс для замены (Если его нет, введите 0) : ");
                        int course = int.Parse(Console.ReadLine());
                        Console.Write("Введите группу для замены (Если ее нет, введите 0): ");
                        int group = int.Parse(Console.ReadLine());
                        Console.Write("Введите специальность для замены (Если нет, введите Enter): ");
                        string special = Console.ReadLine();
                        if (special == "")
                        {
                            special = null;
                        }

                        Examples.NameFirstCourseRebase(namesearch, new Student(name, surname, lastname, age, gender, year, progress, course, group, special));
                        StartClass.Start();
                    }
                    else if (coursechoose == 2)
                    {
                        Examples.NameSearchSecondCourse(namesearch);
                        
                        Console.Write("Введите имя для замены: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию для замены: ");
                        string surname = Console.ReadLine();
                        Console.Write("Введите отчество для замены (Если отчества нет, нажмите Enter): ");
                        string lastname = Console.ReadLine();
                        if (lastname == "")
                        {
                            lastname = null;
                        }

                        Console.Write("Введите возраст для замены (Если его нет , введите 0): ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Введите пол для замены (Если пола нет, нажмите Enter): ");
                        string gender = Console.ReadLine();
                        if (gender == "")
                        {
                            gender = null;
                        }
                        Console.Write("Введите год поступления (Если года нет, введите 0): ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Введите успеваемость для замены (Если ее нет, нажмите Enter): ");
                        string progress = Console.ReadLine();
                        if (progress == "")
                        {
                            progress = null;
                        }
                        Console.Write("Введите курс для замены (Если его нет, введите 0) : ");
                        int course = int.Parse(Console.ReadLine());
                        Console.Write("Введите группу для замены (Если ее нет, введите 0): ");
                        int group = int.Parse(Console.ReadLine());
                        Console.Write("Введите специальность для замены (Если нет, введите Enter): ");
                        string special = Console.ReadLine();
                        if (special == "")
                        {
                            special = null;
                        }

                        Examples.NameSecondCourseRebase(namesearch, new Student(name, surname, lastname, age, gender, year, progress, course, group, special));
                        StartClass.Start();
                    }
                    else if (coursechoose == 3)
                    {
                        Examples.NameSearchThirdCourse(namesearch);
                        
                        Console.Write("Введите имя для замены: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию для замены: ");
                        string surname = Console.ReadLine();
                        Console.Write("Введите отчество для замены (Если отчества нет, нажмите Enter): ");
                        string lastname = Console.ReadLine();
                        if (lastname == "")
                        {
                            lastname = null;
                        }

                        Console.Write("Введите возраст для замены (Если его нет , введите 0): ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Введите пол для замены (Если пола нет, нажмите Enter): ");
                        string gender = Console.ReadLine();
                        if (gender == "")
                        {
                            gender = null;
                        }
                        Console.Write("Введите год поступления (Если года нет, введите 0): ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Введите успеваемость для замены (Если ее нет, нажмите Enter): ");
                        string progress = Console.ReadLine();
                        if (progress == "")
                        {
                            progress = null;
                        }
                        Console.Write("Введите курс для замены (Если его нет, введите 0) : ");
                        int course = int.Parse(Console.ReadLine());
                        Console.Write("Введите группу для замены (Если ее нет, введите 0): ");
                        int group = int.Parse(Console.ReadLine());
                        Console.Write("Введите специальность для замены (Если нет, введите Enter): ");
                        string special = Console.ReadLine();
                        if (special == "")
                        {
                            special = null;
                        }

                        Examples.NameThirdCourseRebase(namesearch, new Student(name, surname, lastname, age, gender, year, progress, course, group, special));
                        StartClass.Start();
                    }
                    else if (coursechoose == 4)
                    {
                        Examples.NameSearchFourCourse(namesearch);
                        
                        Console.Write("Введите имя для замены: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию для замены: ");
                        string surname = Console.ReadLine();
                        Console.Write("Введите отчество для замены (Если отчества нет, нажмите Enter): ");
                        string lastname = Console.ReadLine();
                        if (lastname == "")
                        {
                            lastname = null;
                        }

                        Console.Write("Введите возраст для замены (Если его нет , введите 0): ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Введите пол для замены (Если пола нет, нажмите Enter): ");
                        string gender = Console.ReadLine();
                        if (gender == "")
                        {
                            gender = null;
                        }
                        Console.Write("Введите год поступления (Если года нет, введите 0): ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Введите успеваемость для замены (Если ее нет, нажмите Enter): ");
                        string progress = Console.ReadLine();
                        if (progress == "")
                        {
                            progress = null;
                        }
                        Console.Write("Введите курс для замены (Если его нет, введите 0) : ");
                        int course = int.Parse(Console.ReadLine());
                        Console.Write("Введите группу для замены (Если ее нет, введите 0): ");
                        int group = int.Parse(Console.ReadLine());
                        Console.Write("Введите специальность для замены (Если нет, введите Enter): ");
                        string special = Console.ReadLine();
                        if (special == "")
                        {
                            special = null;
                        }

                        Examples.NameFourCourseRebase(namesearch, new Student(name, surname, lastname, age, gender, year, progress, course, group, special));
                        StartClass.Start();
                    }
                    break;
                case 2:
                    StartClass.Start();
                    break;
                default:
                    Console.WriteLine("Неверная цифра!");
                    StartClass.Start();
                    break;
                


            }
            
        }
    }
}
