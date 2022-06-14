namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var keyValuePairs = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!keyValuePairs.ContainsKey(word.ToLower())) keyValuePairs[word.ToLower()] = 0;

            keyValuePairs[word.ToLower()]++;
        }

        var result = (from item in keyValuePairs where item.Value % 2 != 0 select item.Key).ToList();


        Console.WriteLine(string.Join(" ", result));
    }
}