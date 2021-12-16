namespace _02._NameofExpression
{
    public class Person
    {
        private readonly string firstName;

        private readonly string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }

        public string Name => string.Format("{0} {1}", this.firstName, this.lastName);
    }
}
