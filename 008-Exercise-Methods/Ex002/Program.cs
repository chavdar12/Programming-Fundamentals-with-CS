namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var word = Console.ReadLine();
        Console.WriteLine(VowelsCounter(word));
    }

    private static int VowelsCounter(string? word)
    {
        var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

        return word.Count(letter => vowels.Contains(letter));
    }
}