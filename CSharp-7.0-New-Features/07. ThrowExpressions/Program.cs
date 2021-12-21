namespace _07._ThrowExpressions
{
    public static class Program
    {
        public static void Main()
        {
            PrintName("Boris"); // Boris
            PrintName(null); // Exception
        }

        private static void PrintName(string name)
        {
            Console.WriteLine(name ?? throw new ArgumentNullException());
        }
    }
}
