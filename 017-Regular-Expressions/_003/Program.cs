using System.Text.RegularExpressions;

namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        const string pattern = @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
            Console.WriteLine(
                $"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
    }
}