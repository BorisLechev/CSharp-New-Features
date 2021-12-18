namespace _02._Tuples
{
    public static class Program
    {
        public static void Main()
        {
            // Result from methods as var
            var names = SplitNames("John Smith Amblin");

            Console.WriteLine($"{nameof(names.firstName)} = {names.firstName}");
            Console.WriteLine($"{nameof(names.middleName)} = {names.middleName}");
            Console.WriteLine($"{nameof(names.lastName)} = {names.lastName}");

            // Declare 2 variables and discard middle name
            (string firstName, _, string lastName) = SplitNames("Wen Moon");

            Console.WriteLine($"{firstName} {lastName}");

            // Declare 1 variable with 3 fields
            (string firstName, string middleName, string lastName) name = SplitNames("Kiro Grigorov Kirov");

            Console.WriteLine($"{name.firstName} {name.middleName} {name.lastName}");

            // Declare tuple
            var tupleDeclaration = (42, "String", new object());

            Console.WriteLine(tupleDeclaration.Item1); // 42
            Console.WriteLine(tupleDeclaration.Item2); // String
            Console.WriteLine(tupleDeclaration.Item3); // System.Object

            (int, string str, object) varTuple = (42, "String", new object());
            Console.WriteLine(varTuple.str); // String
        }

        public static (string firstName, string middleName, string lastName) SplitNames(string name)
        {
            var parts = name.Split(new[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            switch (parts.Length)
            {
                case 1: return (parts[0], null, null);
                case 2: return (parts[0], null, parts[1]);
                case 3: return (parts[0], parts[1], parts[2]);
                default: throw new ArgumentException("Invalid string for name.", nameof(name));
            }
        }
    }
}
