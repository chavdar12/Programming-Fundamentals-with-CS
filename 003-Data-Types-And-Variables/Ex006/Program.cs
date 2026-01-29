namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var word1 = char.Parse(Console.ReadLine());
        var word2 = char.Parse(Console.ReadLine());
        var word3 = char.Parse(Console.ReadLine());

        Console.WriteLine($"{word3} {word2} {word1}");
    }
}