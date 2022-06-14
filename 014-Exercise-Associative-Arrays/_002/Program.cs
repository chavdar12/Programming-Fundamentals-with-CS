namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var map = new Dictionary<string, long>();
        string input;

        while ((input = Console.ReadLine()) != "stop")
        {
            var quantity = int.Parse(Console.ReadLine());

            if (!map.ContainsKey(input)) map[input] = 0;

            map[input] += quantity;
        }

        foreach (var (key, value) in map) Console.WriteLine($"{key} -> {value}");
    }
}