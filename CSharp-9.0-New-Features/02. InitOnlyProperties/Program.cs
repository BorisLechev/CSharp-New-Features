using System;

namespace _02._InitOnlyProperties
{
    public static class Program
    {
        public static void Main()
        {
            var personWithConstructor = new Person("Mimi", 5);
            Console.WriteLine(personWithConstructor); // Mimi is 5 years old.

            var personWithInitialization = new Person { Name = "Mimi", Age = 15 };
            Console.WriteLine(personWithInitialization); // Mimi is 15 years old.

            var point = new Point(1, 2);
            var mutatedPoint = point with { X = 2, Y = 3 };
            Console.WriteLine(mutatedPoint.ToString()); // Point { X = 2, Y = 3 }
        }
    }
}
