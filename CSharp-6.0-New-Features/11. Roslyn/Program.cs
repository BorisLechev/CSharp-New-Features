using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace _11._Roslyn
{
    public static class Program
    {
        public static void Main()
        {
            const string CodeFileName = "CodeFile.cs";

            // Read code contents into a string
            var code = File.ReadAllText(CodeFileName);

            // Parse the syntax tree from the string
            var syntaxTree = CSharpSyntaxTree.ParseText(code);

            // Run removal to visit all regions in CodeFile.cs and clean them
            var removal = new RegionsRemoval();
            var result = removal.Visit(syntaxTree.GetRoot());

            // Normalize whitespaces (removing regions produce ugly formatting)
            result = result.NormalizeWhitespace();

            // Write back the result into the code file
            File.WriteAllText(CodeFileName, result.ToFullString());
        }
    }
}

