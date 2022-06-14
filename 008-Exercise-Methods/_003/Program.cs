namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var start = char.Parse(Console.ReadLine());
        var end = char.Parse(Console.ReadLine());

        PrintCharInRange(start, end);
    }

    private static void PrintCharInRange(char start, char end)
    {
        if (start < end)
            for (var i = start + 1; i < end; i++)
                Console.Write($"{(char) i} ");
        else
            for (var i = end + 1; i < start; i++)
                Console.Write($"{(char) i} ");
    }
}