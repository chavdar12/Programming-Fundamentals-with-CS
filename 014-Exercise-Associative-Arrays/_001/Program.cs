namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var map = new Dictionary<char, int>();

        foreach (var item in words)
        foreach (var t in item)
        {
            if (!map.ContainsKey(t)) map[t] = 0;

            map[t]++;
        }

        foreach (var (key, value) in map) Console.WriteLine($"{key} -> {value}");
    }
}