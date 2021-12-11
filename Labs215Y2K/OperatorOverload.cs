namespace Labs215Y2K
{
    class OperatorOverload
    {
        public OperatorOverload(string name, int counter)
        {
            Name = name;
            Counter = counter;
        }

        public string Name { get; set; }
        public int Counter { get; set; }

        public static OperatorOverload operator +(OperatorOverload objectOne, OperatorOverload object2)
        {
            return new OperatorOverload("newObj", objectOne.Counter + object2.Counter);
        }
        public static bool operator > (OperatorOverload objectOne, OperatorOverload object2)
        {
            return objectOne.Counter > object2.Counter;
        }
        public static bool operator < (OperatorOverload objectOne, OperatorOverload object2)
        {
            return objectOne.Counter < object2.Counter;
        }


    }
}
