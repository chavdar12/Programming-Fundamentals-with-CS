namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        var result = new SortedDictionary<double, int>();

        foreach (var item in numbers)
        {
            if (!result.ContainsKey(item)) result[item] = 0;

            result[item]++;
        }

        foreach (var (key, value) in result) Console.WriteLine($"{key} -> {value}");
    }
}