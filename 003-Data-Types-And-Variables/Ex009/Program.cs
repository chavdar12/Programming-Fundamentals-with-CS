namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var first = char.Parse(Console.ReadLine());
        var second = char.Parse(Console.ReadLine());
        var third = char.Parse(Console.ReadLine());
        Console.WriteLine($"{first}{second}{third}");
    }
}