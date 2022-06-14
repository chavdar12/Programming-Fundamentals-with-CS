namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine();

        text = bannedWords.Aggregate(text, (current, word) => current.Replace(word, new string('*', word.Length)));

        Console.WriteLine(text);
    }
}