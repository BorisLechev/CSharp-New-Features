namespace _03._PatternMatchingIsAndSwitch
{
    public static class Program
    {
        public static void Main()
        {
            PrintStars(10); // **********
            object theUltimateAnswer = 42;

            if (theUltimateAnswer is int n || (theUltimateAnswer is string s && int.TryParse(s, out n)))
            {
                Console.WriteLine(n); // 42
            }

            SwitchStatementsWithPatterns(new Rectangle { Width = 2, Height = 2 }); // 2 x 2 square
            SwitchStatementsWithPatterns(new Rectangle { Width = 2, Height = 4 }); // 2 x 4 rectangle
            SwitchStatementsWithPatterns(new Circle { Radius = 5 }); // Circle with radius: 5
            SwitchStatementsWithPatterns("circle"); // circle is string
        }

        private static void SwitchStatementsWithPatterns(object shape)
        {
            switch (shape)
            {
                case Circle circle:
                    Console.WriteLine($"Circle with radius: {circle.Radius}");
                    break;
                case Rectangle square when square.Width == square.Height:
                    Console.WriteLine($"{square.Width} x {square.Height} square");
                    break;
                case Rectangle rectangle:
                    Console.WriteLine($"{rectangle.Width} x {rectangle.Height} rectangle");
                    break;
                case string _: // discarding the variable
                    Console.WriteLine($"{shape} is string");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    Console.WriteLine("<unknown shape>");
                    break;
            }
        }

        private static void PrintStars(object obj)
        {
            if (obj is null) // constant pattern "null"
            {
                return;
            }

            if (obj is string _) // discarding the variable
            {
                Console.WriteLine($"{obj} is string!");
            }

            if ((obj is int i) == false) // type pattern "int i"
            {
                return;
            }

            Console.WriteLine(new string('*', i));
        }
    }
}