namespace _03._NullConditionalOperators
{
    public class Customer
    {
        public Customer()
        {
            this.Orders = new List<string>();
        }

        public IEnumerable<string> Orders { get; set; }
    }
}
