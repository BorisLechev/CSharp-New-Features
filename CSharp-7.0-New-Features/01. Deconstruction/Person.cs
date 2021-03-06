namespace _01._Deconstruction
{
    public class Person
    {
        public Person(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
        {
            firstName = this.FirstName;
            middleName = this.MiddleName;
            lastName = this.LastName;
        }
    }
}
