namespace _07._IndexInitializers
{
    public static class Program
    {
        public static void Main()
        {
            // C# 5.0
            var numbersOldWay = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
            };

            // C# 6.0
            var numbersNewWay = new Dictionary<int, string>
            {
                [1] = "one",
                [2] = "two",
                [3] = "three",
            };

            var dictionary = new Dictionary<string, string>
            {
                ["C#"] = "A programming language",
                [".NET"] = "A development platform",
                ["CIL"] = "Lowest-level programming language used by the .NET Framework",
            };
        }
    }
}
