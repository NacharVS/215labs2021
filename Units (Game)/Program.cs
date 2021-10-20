using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    class Program
    {
        static void Main(string[] args)
        {
            fighters warrior = new fighters("Frederich", 40, 60, 100, "Суперспособность: вампиризм. После удара высасывает жизненные силы противника в течение 5 сек по 1 хп. КД: 1 минута.");
            fighters archer = new fighters("Lucky", 60, 75, 40, "Суперспособность: огненные стрелы. Наносят доп. урон по пораженному противнику в течение 5 сек по 0.5 хп. КД: 2 минуты." );
            fighters wizard = new fighters("Beast ", 50, 85, 30, "Суперспособность: исчезать. Может исчезнуть во время боя один раз. КД: 4 минуты.");
            Peaceful bricklayer = new Peaceful("Fred ", 30, 20, 25, "добывает камень", 40);
            Peaceful peasant = new Peaceful("Charlie ", 30, 15, 25, "добывает еду", 60);
            Peaceful lumberjack = new Peaceful("Totoshka ", 30, 20, 35, "добывает дерево", 55);
            Console.WriteLine("Приветствую. Выберите персонажа, за которого будете играть в 'SuperGame'");
            Console.WriteLine("Для игры за мага введите 'Маг'");
            Console.WriteLine("Для игры за лучника введите 'Лучник'");
            Console.WriteLine("Для игры за воина введите 'Воин'");
            string chose = Console.ReadLine(); 
            if (chose == "Маг")
            {
                Console.WriteLine("Поздравляю. Вы - маг. Ваше имя: Beast");
                fighters.Skill(wizard.name, wizard.speed);
            }
            if (chose == "Лучник")
            {
                Console.WriteLine("Поздравляю. Вы - лучник. Ваше имя: Lucky");
                fighters.Skill(archer.name, archer.speed);
            }
            if (chose == "Воин")
            {
                Console.WriteLine("Поздравляю. Вы - воин. Ваше имя: Frederich");
                fighters.Skill(warrior.name, warrior.speed);
            }
 
            //Console.WriteLine(warrior.name + " наносит урон по " + wizard.name + " в размере " + warrior.damage);
            //Console.WriteLine($"у {wizard.name} осталось {wizard.health - warrior.damage} healthpoint");
            //if (wizard.health - warrior.damage <= 0)
            //{
            //    Console.WriteLine("Ваш персоаж мёртв. Сожалеем.");
            //}
            //Console.ReadKey();

            //Peaceful.Skill(peasant.name, peasant.skill, peasant.workspeed);
            //fighters.Skill(wizard.name, wizard.speed);
            Console.ReadKey();
        }
  


    }
}
