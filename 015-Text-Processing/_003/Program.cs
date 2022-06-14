namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var wordToRemove = Console.ReadLine();
        var text = Console.ReadLine();

        while (text.Contains(wordToRemove))
        {
            var index = text.IndexOf(wordToRemove, StringComparison.Ordinal);
            text = text.Remove(index, wordToRemove.Length);
        }

        Console.WriteLine(text);
    }
}