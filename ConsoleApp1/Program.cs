namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            Granta firstgranta = new Granta("Гранта", 50, "Белый", "Первого класса");
            Granta secondgranta = new Granta("Гранта2", 50, "Черный", "Второго класса");
           
           
            List<Granta> allgranta = new List<Granta>();
            allgranta.Add(firstgranta);
            allgranta.Add(secondgranta);

            Console.WriteLine("Наши машины в наличие:");
            for (int i = 0; i < allgranta.Count; i++)
            {

                Console.WriteLine($"({i+1}) colour - {allgranta[i].Colour} ");
            }
            Console.WriteLine("Выберите машину, цвет которой хотите просмотреть.");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine(allgranta[choice-1].Colour);


            allgranta.Remove(allgranta[choice - 1]);
            Console.WriteLine("Наши машины в наличие:");
            for (int i = 0; i < allgranta.Count; i++)
            {

                Console.WriteLine($"({i + 1}) colour - {allgranta[i].Colour} ");
            }

            Console.ReadLine();






        }
    }
}