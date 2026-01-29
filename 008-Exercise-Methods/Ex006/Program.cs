namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var word = Console.ReadLine();

        PrintTheMiddleChars(word);
    }

    private static void PrintTheMiddleChars(string? word)
    {
        if (word.Length % 2 == 0)
            Console.WriteLine(word[word.Length / 2 - 1] + word[word.Length / 2].ToString());
        else
            Console.WriteLine(word[word.Length / 2]);
    }
}