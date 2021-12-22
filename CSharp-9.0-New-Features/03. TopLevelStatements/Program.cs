using System;
using System.Threading.Tasks;

Console.WriteLine("Hello World!");
Console.WriteLine(Math.Pow(2, 10));

// args is available with the command-line arguments
Console.WriteLine($"I've got {args.Length} argument(s)."); // I've got 0 argument(s).

// Tasks can also be used
await Task.CompletedTask;

// Return statement is also allowed
return 0;
