namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
        var result = new List<string>();

        for (var i = list.Count - 1; i >= 0; i--)
        {
            var currList = list[i].Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            result.AddRange(currList);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}