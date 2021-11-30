# 
namespace ConsoleApp2
{
class Program
{
static void Main(string[] args)
{



Console.WriteLine(" Данные первого счёта");

Account acc1 = new Account();
acc1.Name = "Егор";
Console.WriteLine(acc1.Name);

acc1.Balance = 1000;
Console.WriteLine(acc1.Balance + " рублей");

acc1.Age = 16;
Console.WriteLine(acc1.Age);

acc1.Id = "AdDwdw23";
Console.WriteLine(acc1.Id);

acc1.YearOfBirth = 2004;
Console.WriteLine(acc1.YearOfBirth);


Console.WriteLine(" Данные второго счёта");


Account acc2 = new Account();

acc2.Name = "egor";
Console.WriteLine(acc2.Name);

acc2.Balance = 0;
Console.WriteLine(acc2.Balance + " долларов");

acc2.Age = 18;
Console.WriteLine(acc2.Age);

acc2.Id = "A1DD2D/UTG";
Console.WriteLine(acc2.Id);

acc2.YearOfBirth = 2006;

Console.WriteLine(acc2.YearOfBirth);


Console.WriteLine(acc1.Balance + " " + acc2.Balance);


Console.WriteLine("Выберите действие:");
Console.WriteLine("Перевод на второй счёт - нажмите 1");
Console.WriteLine(" Пополнение счёта - нажмите 2");

int action = int.Parse(Console.ReadLine());

if (action == 1)
{
Perevod(acc1, acc2);
}
else
{
Popolnenie(acc1, acc2);
}

Console.WriteLine(acc2.Balance + " долларов");
Console.WriteLine(acc1.Balance + " рублей");

}





public static void Perevod(Account acc1, Account acc2)
{
Console.WriteLine("Введите сумму");
int summaperevoda = int.Parse(Console.ReadLine());

Console.WriteLine("Выберите действие");

Console.WriteLine("Конвертация рублей в доллары - нажмите 1");

Console.WriteLine("Конвертация долларов в рубли- нажмите 2");


int action = int.Parse(Console.ReadLine());
if (action == 1)
{
int cash = summaperevoda % 74;
acc1.Balance -= summaperevoda + cash;
summaperevoda = summaperevoda/ 74;
acc2.Balance += summaperevoda;
}
else
{
summaperevoda = summaperevoda * 74;
acc1.Balance += summaperevoda;
acc2.Balance -= summaperevoda;
}

Console.WriteLine(acc2.Balance + " долларов");
Console.WriteLine(acc1.Balance + " рублей");

Console.WriteLine("Выберите действие:");
Console.WriteLine("Перевод на второй счёт - нажмите 1");
Console.WriteLine(" Пополнение счёта - нажмите 2");


int action2 = int.Parse(Console.ReadLine());

if (action2 == 1)
{
Perevod(acc1, acc2);
}
else
{
Popolnenie(acc1, acc2);
}

}






public static void Popolnenie(Account acc1, Account acc2)
{

Console.WriteLine("Выберите действие");

Console.WriteLine("Пополнение первого счёта в рублях - нажмите 1");

Console.WriteLine(" Пополнение второго счёта в долларах - нажмите 2");

int action = int.Parse(Console.ReadLine());


Console.WriteLine("Введите сумму");

int summapopolneniya = int.Parse(Console.ReadLine());

if (action == 1)
{
acc1.Balance += summapopolneniya;
}
else
{
acc2.Balance += summapopolneniya;

}


}

}

}
