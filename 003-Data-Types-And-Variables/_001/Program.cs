namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var meters = decimal.Parse(Console.ReadLine());
        var kilometers = meters / 1000;
        Console.WriteLine($"{kilometers:f2}");
    }
}