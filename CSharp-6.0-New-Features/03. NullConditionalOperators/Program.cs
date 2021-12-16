namespace _03._NullConditionalOperators
{
    public static class Program
    {
        public static void Main()
        {
            var customers = GetCustomers();

            // Before:
            //// int? lengthOrNull = customers != null ? customers.Length : (int?)null;
            // After:
            int? lengthOrNull = customers?.Length;

            Console.WriteLine($"lengthOrNull.HasValue: {lengthOrNull.HasValue}"); // False

            // Indexer access:
            var first = customers?[0]; // null if customers is null

            // Used together with the null coalescing operator ??:
            int lengthOrZero = customers?.Length ?? 0; // 0 if customers null

            Console.WriteLine($"lengthOrZero: {lengthOrZero}");

            // Chaining of null checks before
            ////int? firstOrdersCount2 = (customers != null) ? (customers[0].Orders != null ? customers[0].Orders.Count() : (int?)null) : null;
            // Chaining of null checks after:
            int? firstOrdersCount3 = customers?[0].Orders?.Count();
        }

        private static Customer[] GetCustomers()
        {
            //return new Customer[1] { new Customer() { Orders = new List<string> { "order1", "order2" } } };
            return null;
        }
    }
}
