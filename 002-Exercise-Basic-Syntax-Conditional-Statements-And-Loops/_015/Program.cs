namespace _015;

internal static class Program
{
    private static void Main(string[] args)
    {
        var word = Console.ReadLine();
        var reverseWord = string.Empty;

        for (var i = word.Length - 1; i >= 0; i--) reverseWord += word[i];

        Console.WriteLine(reverseWord);
    }
}