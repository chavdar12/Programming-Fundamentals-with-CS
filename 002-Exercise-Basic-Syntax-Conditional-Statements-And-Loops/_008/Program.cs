namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (var row = 1; row <= n; row++)
        {
            for (var column = 1; column <= row; column++) Console.Write($"{row} ");

            Console.WriteLine();
        }
    }
}