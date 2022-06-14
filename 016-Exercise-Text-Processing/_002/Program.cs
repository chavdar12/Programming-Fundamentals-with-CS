namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var first = input[0];
        var second = input[1];

        string longer;
        string shorter;

        if (string.Compare(first, second, StringComparison.Ordinal) > 0)
        {
            longer = second;
            shorter = first;
        }
        else
        {
            longer = first;
            shorter = second;
        }

        var sum = shorter.Select((t, i) => longer[i] * t).Sum();

        for (var j = shorter.Length; j < longer.Length; j++) sum += longer[j];

        Console.WriteLine(sum);
    }
}