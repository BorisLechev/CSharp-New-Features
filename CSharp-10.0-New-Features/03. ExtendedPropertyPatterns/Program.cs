using System;

namespace _03._ExtendedPropertyPatterns
{
    public static class Program
    {
        public static void Main()
        {
            // Extended property patterns
            var person = new Person();
            person.Address = new Address();
            person.Address.City = new City("Sofia");

            // C# 9: person is Person { Address: { City: { Name: "Sofia" } } }
            if (person is Person { Address.City.Name: "Sofia" })
            {
                Console.WriteLine("person is a Person class with city name of Sofia");
            }
        }
    }
}
