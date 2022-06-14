namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var arrOne = new int[n];
        var arrTwo = new int[n];

        for (var i = 0; i < n; i++)
        {
            var currArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            if (i % 2 == 0)
            {
                arrOne[i] = currArray[0];
                arrTwo[i] = currArray[1];
            }
            else
            {
                arrOne[i] = currArray[1];
                arrTwo[i] = currArray[0];
            }
        }

        Console.WriteLine(string.Join(" ", arrOne));
        Console.WriteLine(string.Join(" ", arrTwo));
    }
}