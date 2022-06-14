namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var sumOdd = 0;
        var sumEven = 0;

        foreach (var i in arr)
            if (i % 2 == 0)
                sumEven += i;
            else
                sumOdd += i;

        Console.WriteLine(sumEven - sumOdd);
    }
}