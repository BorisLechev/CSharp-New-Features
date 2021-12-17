namespace _05._AutoPropertyInitialization
{
    public static class Program
    {
        public static void Main()
        {
            // Initializers for auto-properties
            var person = new Person();

            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}
