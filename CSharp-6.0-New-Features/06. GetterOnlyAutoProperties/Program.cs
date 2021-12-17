namespace _06._GetterOnlyAutoProperties
{
    public static class Program
    {
        public static void Main()
        {
            var person = new ReadOnlyPerson("Boris");

            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}
