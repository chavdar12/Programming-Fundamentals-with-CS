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
        if (first < second && first < third)
            Console.WriteLine(first);
        else if (second < first && second < third)
            Console.WriteLine(second);
        else
            Console.WriteLine(third);
    }
}