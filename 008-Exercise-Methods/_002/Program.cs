namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var word = Console.ReadLine();
        Console.WriteLine(VowelsCounter(word));
    }

    private static int VowelsCounter(string word)
    {
        word = word.ToLower();
        char[] vowels = {'a', 'o', 'u', 'i', 'e'};

        return word.Count(i => vowels.Contains(i));
    }
}