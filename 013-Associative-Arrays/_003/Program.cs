namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var map = new Dictionary<string, List<string>>();

        for (var i = 0; i < n; i++)
        {
            var word = Console.ReadLine();
            var synonym = Console.ReadLine();

            if (!map.ContainsKey(word)) map.Add(word, new List<string>());

            map[word].Add(synonym);
        }

        foreach (var (key, value) in map) Console.WriteLine($"{key} - {string.Join(", ", value)}");
    }
}