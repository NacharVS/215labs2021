using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Start : Mage
    {
        string oldname;
        string newname;
        public delegate void NameChange(string oldname, string newname);
        public event NameChange NameChangeInfo { add { NameChangeEvent(oldname,newname); } remove { } }
        public Start(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }

        
        public static void StartProgramm()
        {
            
            List<Start> listpersons = new List<Start>();
            NextProgramm(listpersons);
            
            
            
        }
        static void NameChangeEvent(string oldname, string newname)
        {
            Console.WriteLine($"Успешно, старое имя {oldname} новое имя {newname}");
        }
        public static void NextProgramm(List<Start> listpersons)
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("0 - Добавить людей в базу данных");
            Console.WriteLine("1 - Просмотреть информацию о людях");
            Console.WriteLine("2 - Изменить данные;");
            Console.WriteLine("3 - Удалить людей из базы данных");
            int answer = int.Parse(Console.ReadLine());
            int answerchoose;
            switch (answer)
            {
                case 0:
                    AddPerson(listpersons);
                    NextProgramm(listpersons);
                    break;
                case 1:
                    Info(listpersons);
                    NextProgramm(listpersons);
                    break;
                case 2:
                    Info(listpersons);
                    Console.Write("Введите id, которому желаете поменять имя: ");
                    answerchoose = int.Parse(Console.ReadLine());
                    listpersons[answerchoose].ChangeInfo(listpersons, answerchoose);
                    NextProgramm(listpersons);
                    break;



            }
        }
        public static void Info(List<Start> listpersons)
        {
            foreach (var item in listpersons)
            {
                Console.WriteLine($"id : {listpersons.IndexOf(item)} Имя {item.Name} Пол {item.Gender} Возраст {item.Age}");
            }
        }
        public static void AddPerson(List<Start> listpersons)
        {
            Console.WriteLine("Введите поочередно имя , пол через enter");
            listpersons.Add(new Start(0, Console.ReadLine(), Console.ReadLine()));
        }
        public void ChangeInfo(List<Start> listpersons, int answer)
        {
            string Oldname;
            string Newname;
            for (int i = answer;;)
            {
                Oldname = listpersons[i].Name;
                Console.WriteLine($"Введите новое имя {listpersons[i].Name}");
                listpersons[i].Name = Console.ReadLine();
                Newname = listpersons[i].Name;
                Console.WriteLine($"Успешно! Старое имя {Oldname} новое имя {Newname}");
                break;
            }




            
        }

    }
}
