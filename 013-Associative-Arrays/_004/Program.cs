namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
            if (word.Length % 2 == 0)
                Console.WriteLine(word);
    }
}