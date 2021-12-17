namespace _06._GetterOnlyAutoProperties
{
    public class ReadOnlyPerson
    {
        public ReadOnlyPerson(string firstName)
        {
            // This line is also valid for read-only property initialization
            this.FirstName = firstName;
        }

        public string FirstName { get; } = "Boris";

        public string LastName { get; } = "Lechev";
    }
}
