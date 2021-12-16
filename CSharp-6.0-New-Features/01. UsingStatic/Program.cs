using static System.Console;
using static System.Math;
using static System.Linq.Enumerable;

namespace _01._UsingStatic
{
    public static class Program
    {
        public static void Main()
        {
            WriteLine(Pow(2, 10)); // Instead of Console.WriteLine(Math.Pow(2, 10))

            Range(1, 10).ToList().ForEach(WriteLine); // Using static in combination with extension methods
        }
    }
}
