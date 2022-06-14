namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());

        for (var i = (char) start; i <= end; i++) Console.Write($"{i} ");
    }
}