namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var sum = input.Sum(CalculateItemSum);

        Console.WriteLine($"{sum:f2}");
    }

    private static decimal CalculateItemSum(string item)
    {
        decimal sum = 0;

        var firstLetter = item[0];
        var lastLetter = item[^1];
        var num = int.Parse(item.Substring(1, item.Length - 2));

        var firstLetterPosition = AlphabetPosition(firstLetter);
        var lastLetterPosition = AlphabetPosition(lastLetter);

        if (char.IsUpper(firstLetter))
            sum = (decimal) num / firstLetterPosition;
        else if (char.IsLower(firstLetter)) sum = (decimal) num * firstLetterPosition;

        if (char.IsUpper(lastLetter))
            sum -= lastLetterPosition;
        else if (char.IsLower(lastLetter)) sum += lastLetterPosition;

        return sum;
    }

    private static int AlphabetPosition(char ch)
    {
        ch = char.ToLower(ch);
        return ch - 96;
    }
}