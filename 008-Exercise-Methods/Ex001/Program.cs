namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var third = int.Parse(Console.ReadLine());

        PrintSmallestNumber(first, second, third);
    }

    private static void PrintSmallestNumber(int first, int second, int third)
    {
        Console.WriteLine(Math.Min(first, Math.Min(second, third)));
    }
}