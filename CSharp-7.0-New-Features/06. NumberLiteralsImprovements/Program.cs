namespace _06._NumberLiteralsImprovements
{
    public static class Program
    {
        public static void Main()
        {
            int a = 54_123_768;
            int weird = 1_2__3___4____5;

            Console.WriteLine($"{nameof(a)} = {a}"); // 54123768
            Console.WriteLine($"{nameof(weird)} = {weird}"); // 12345
        }
    }
}