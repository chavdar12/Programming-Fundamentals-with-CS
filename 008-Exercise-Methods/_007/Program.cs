namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        PrintMatrix(n);
    }

    private static void PrintMatrix(int n)
    {
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++) Console.Write($"{n} ");

            Console.WriteLine();
        }
    }
}