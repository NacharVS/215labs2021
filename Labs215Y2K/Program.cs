using System;

namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            OfficeWorker person1 = new OfficeWorker("Клементий", "работник офиса", 40, 20, 80);
            Console.WriteLine($" Имя персонажа - {person1.name}, специальность - {person1.work}, здоровье - {person1.health}, сила - {person1.damage}, стамина - {person1.stamina}");
            person1.Move();
        }
    }
}
