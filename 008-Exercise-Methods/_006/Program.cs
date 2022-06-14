namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var word = Console.ReadLine();

        PrintTheMiddleChars(word);
    }

    private static void PrintTheMiddleChars(string word)
    {
        switch (word.Length % 2)
        {
            case 0:
                Console.Write(word[word.Length / 2 - 1]);
                Console.WriteLine(word[word.Length / 2]);
                break;
            default:
                Console.WriteLine(word[word.Length / 2]);
                break;
        }
    }
}