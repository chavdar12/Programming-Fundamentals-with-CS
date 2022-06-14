using System.Text.RegularExpressions;

namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        const string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern);

        foreach (Match match in matches) Console.Write($"{match.Value} ");
    }
}