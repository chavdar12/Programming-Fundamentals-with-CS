namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();
        var numbers2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        var longerList = Math.Max(numbers1.Count, numbers2.Count);

        var result = new List<int>();

        for (var i = 0; i < longerList; i++)
        {
            if (i < numbers1.Count) result.Add(numbers1[i]);

            if (i < numbers2.Count) result.Add(numbers2[i]);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}