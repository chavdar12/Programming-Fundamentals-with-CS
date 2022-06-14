namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine().ToCharArray();

        var digits = string.Empty;
        var letters = string.Empty;
        var chars = string.Empty;

        foreach (var symbol in text)
            if (char.IsDigit(symbol))
                digits += symbol;
            else if (char.IsLetter(symbol))
                letters += symbol;
            else
                chars += symbol;

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(chars);
    }
}