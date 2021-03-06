namespace _05._OutVariables
{
    public static class Program
    {
        public static void Main()
        {
            // Before C# 7.0
            int a;
            if (int.TryParse("123", out a))
            {
                Console.WriteLine(a);
            }

            // C# 7.0
            if (int.TryParse("123", out int b))
            {
                Console.WriteLine(b);
            }

            // Infer the type of x
            if (int.TryParse("123", out var c))
            {
                Console.WriteLine(c);
            }

            // Infer the type of x
            if (int.TryParse("123", out _))
            {
                Console.WriteLine("Parsed successfully");
            }
        }
    }
}