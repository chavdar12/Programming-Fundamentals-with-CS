using System.Text.RegularExpressions;

namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        const string pattern = @"\+359([ |-])2\1[0-9]{3}\1[0-9]{4}\b";
        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern);
        var phoneMatches = matches.Select(a => a.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", phoneMatches));
    }
}