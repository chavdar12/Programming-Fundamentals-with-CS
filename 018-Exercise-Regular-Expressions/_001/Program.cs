using System.Text.RegularExpressions;

namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        const string pattern = @">{2}(?<item>[A-Za-z]+)<{2}(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

        var items = new List<string>();
        decimal total = 0;
        string input;

        while ((input = Console.ReadLine()) != "Purchase")
        {
            var match = Regex.Match(input, pattern);

            if (!match.Success) continue;
            var item = match.Groups["item"].Value;
            var price = decimal.Parse(match.Groups["price"].Value);
            var quantity = int.Parse(match.Groups["quantity"].Value);

            items.Add(item);
            total += price * quantity;
        }

        Console.WriteLine("Bought furniture:");
        foreach (var item in items) Console.WriteLine(item);

        Console.WriteLine($"Total money spend: {total:f2}");
    }
}