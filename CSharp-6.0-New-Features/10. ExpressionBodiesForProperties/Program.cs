namespace _10._ExpressionBodiesForProperties
{
    public static class Program
    {
        public static void Main()
        {
            var person = new Person("Boris", "Lechev");

            person.Children.Add(new Person("Ivan", "Ivanov"));

            Console.WriteLine(person.Name); // Boris Lechev
            Console.WriteLine(person["Ivan Ivanov"].Name); // Ivan Ivanov
        }
    }
}
