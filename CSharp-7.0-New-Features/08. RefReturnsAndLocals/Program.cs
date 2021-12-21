namespace _08._RefReturnsAndLocals
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("======== Ref return and local ref");

            var books = new[] { "Tragedy and Hope 101", "Animal Farm", "The Madness Of Crowds" };

            Console.WriteLine($"Original value of {nameof(books)}[0]: {books[0]}");

            ref string result = ref FindString(0, books);

            Console.WriteLine($"Return value of result: {result}"); // Return value of result: Animal Farm

            result = "CHANGED";

            Console.WriteLine($"New value of result: {result}"); // New value of result: CHANGED
            Console.WriteLine($"We've changed the value of {nameof(books)}[0]: {books[0]}"); // ... CHANGED
            Console.WriteLine();

            Console.WriteLine("======== Local ref");
            var oldVariable = "OLD VALUE";
            ref var newVariable = ref oldVariable; // newVariable is now pointing to oldVariable
            newVariable = "NEW VALUE";

            Console.WriteLine($"Value of {nameof(newVariable)}: {newVariable}"); // Value of newVariable: NEW VALUE
            Console.WriteLine($"Value of {nameof(oldVariable)}: {oldVariable}"); // Value of oldVariable: NEW VALUE
        }

        private static ref string FindString(int index, string[] books)
        {
            if (books.Length > 0)
            {
                return ref books[index]; // return the storage location, not the value
            }

            throw new IndexOutOfRangeException($"{nameof(index)} {index} not found.");
        }
    }
}