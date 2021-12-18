namespace _01._Deconstruction
{
    public static class Program
    {
        public static void Main()
        {
            // Deconstruct with Deconstruct() method
            var person = new Person("John", "Smith", "Smith");

            (string firstName, _, string lastName) = person;

            Console.WriteLine($"{firstName} {lastName}");

            // Deconstruct with extension method
            (int year, int month, int day) = DateTime.Now;
            Console.WriteLine($"{day}.{month}.{year}");
        }

        private static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
        }
    }
}

