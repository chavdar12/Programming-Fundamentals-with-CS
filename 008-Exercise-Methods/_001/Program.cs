namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var third = int.Parse(Console.ReadLine());

        PrintSmallestNumber(first, second, third);
    }

    private static void PrintSmallestNumber(int a, int b, int c)
    {
        var minNumber = Math.Min(Math.Min(a, b), c);
        Console.WriteLine(minNumber);
    }
}