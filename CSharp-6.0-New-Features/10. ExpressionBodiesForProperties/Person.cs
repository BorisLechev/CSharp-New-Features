namespace _10._ExpressionBodiesForProperties
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Children = new List<Person>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Person> Children { get; set; }

        // Before:
        //// public string Name
        //// {
        ////     get
        ////     {
        ////         return this.FirstName + " " + this.LastName;
        ////     }
        //// }
        // Now:
        public string Name => this.FirstName + " " + this.LastName;

        // Expression for indexer body:
        public Person this[string name] => 
            this.Children.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
    }
}
