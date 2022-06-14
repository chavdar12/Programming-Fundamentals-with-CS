namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var pound = decimal.Parse(Console.ReadLine());
        var usd = pound * 1.31m;
        Console.WriteLine($"{usd:f3}");
    }
}