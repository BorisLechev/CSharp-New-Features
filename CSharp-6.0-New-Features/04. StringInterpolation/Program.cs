namespace _04._StringInterpolation
{
    public static class Program
    {
        public static void Main()
        {
            // Combining nameof() with interpolated strings
            var value = 42;
            Console.WriteLine($"{nameof(value)} = {value:F3}"); // value = 42,000

            // Escaping '{' and '}' for JSON strings for example
            Console.WriteLine($"{{ value: {value} }}"); // { value: 42 }

            // Expressions are allowed in interpolated strings
            Console.WriteLine($"Sum of 2+2 = {2 + 2}");

            var cores = Environment.ProcessorCount;
            var versionInformation =
                $"{Environment.OSVersion}; .NET CLR {Environment.Version}; {cores} core{(cores == 1 ? null : "s")}";
            Console.WriteLine(versionInformation);
        }
    }
}
