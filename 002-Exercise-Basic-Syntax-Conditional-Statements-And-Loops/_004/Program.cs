namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var start = int.Parse(Console.ReadLine());
        var stop = int.Parse(Console.ReadLine());
        var sum = 0;

        for (var i = start; i <= stop; i++)
        {
            Console.Write($"{i} ");
            sum += i;
        }

        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");
    }
}