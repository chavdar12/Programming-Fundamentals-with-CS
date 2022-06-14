namespace _009;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        for (var i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 0) continue;
            Console.WriteLine(i);
            sum += i;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}