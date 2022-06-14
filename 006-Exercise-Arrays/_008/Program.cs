namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        var number = int.Parse(Console.ReadLine());

        for (var i = 0; i < arr.Length - 1; i++)
        for (var j = i + 1; j < arr.Length; j++)
        {
            if (i == j) continue;

            if (arr[i] + arr[j] != number) continue;
            int[] uniquePair = {arr[i], arr[j]};
            Console.WriteLine(string.Join(" ", uniquePair));
        }
    }
}