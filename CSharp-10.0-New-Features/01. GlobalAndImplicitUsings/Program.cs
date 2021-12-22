// System is included by default because of <ImplicitUsings>enable</ImplicitUsings> in project file
Console.WriteLine(Math.Cos(Math.PI)); // -1

// System.Text.RegularExpressions is included in the project file
Console.WriteLine(Regex.Match("Hello, 2022!", @"\d{4}").Value); // 2022

// System.Net.Http is disabled in the project file
System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

Console.WriteLine(new Matrix3x2(1, 2, 3, 4, 5, 6).GetDeterminant()); // -2