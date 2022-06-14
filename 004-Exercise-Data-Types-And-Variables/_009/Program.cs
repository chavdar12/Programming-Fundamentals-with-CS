namespace _009;

internal static class Program
{
    private static void Main(string[] args)
    {
        var startingYield = int.Parse(Console.ReadLine());
        var spicesQuantity = 0;
        var counter = 0;

        for (var i = startingYield; i >= 100; i -= 10)
        {
            counter++;
            spicesQuantity += i;
            spicesQuantity -= 26;
        }

        if (spicesQuantity > 26) spicesQuantity -= 26;

        Console.WriteLine(counter);
        Console.WriteLine(spicesQuantity);
    }
}