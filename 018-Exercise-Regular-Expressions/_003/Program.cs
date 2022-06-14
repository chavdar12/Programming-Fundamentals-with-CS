using System.Text.RegularExpressions;

namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        const string pattern =
            @"\%(?<name>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

        var totalIncome = 0m;
        string input;

        while ((input = Console.ReadLine()) != "end of shift")
        {
            var match = Regex.Match(input, pattern);

            if (!match.Success) continue;
            var name = match.Groups["name"].Value;
            var product = match.Groups["product"].Value;
            var count = int.Parse(match.Groups["count"].Value);
            var price = decimal.Parse(match.Groups["price"].Value);
            var total = count * price;
            totalIncome += total;

            Console.WriteLine($"{name}: {product} - {total:f2}");
        }

        Console.WriteLine($"Total income: {totalIncome:f2}");
    }
}