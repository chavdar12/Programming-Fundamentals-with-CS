namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var data = new Dictionary<string, List<double>>();

        for (var i = 0; i < n; i++)
        {
            var name = Console.ReadLine();
            var grade = double.Parse(Console.ReadLine());

            if (!data.ContainsKey(name)) data[name] = new List<double>();

            data[name].Add(grade);
        }

        foreach (var (key, value) in data)
            if (value.Average() >= 4.5)
                Console.WriteLine($"{key} -> {value.Average():f2}");
    }
}