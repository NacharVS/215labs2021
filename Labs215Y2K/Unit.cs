namespace Labs215Y2K
{
    class Unit
    {
        public string name;
        public int health;
        public int speed;
        public int damage;

        public void Move()
        {
            System.Console.WriteLine($"{name} moving");
        }
    }
}
