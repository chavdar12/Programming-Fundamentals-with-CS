namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var sum = arr.Where(i => i % 2 == 0).Sum();

        Console.WriteLine(sum);
    }
}