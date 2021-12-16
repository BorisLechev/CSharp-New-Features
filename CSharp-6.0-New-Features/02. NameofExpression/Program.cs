
namespace _02._NameofExpression
{
    public class Program
    {
        public static void Main()
        {
            // Name of static method
            Console.WriteLine(nameof(Main));  // Main

            try
            {
                var person = new Person(null, null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message); // Value cannot be null. (Parameter 'firstName')
            }

            // Name of instance property
            new Program().NonStaticMethod(); // NonStaticProperty

            // Name of methods
            Console.WriteLine(nameof(string.Empty.Normalize)); // Normalize
        }

        public int NonStaticProperty { get; set; }

        public void NonStaticMethod()
        {
            Console.WriteLine(nameof(this.NonStaticProperty));
        }
    }
}
