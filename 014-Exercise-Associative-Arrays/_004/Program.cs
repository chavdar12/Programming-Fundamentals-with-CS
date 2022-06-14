namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var data = new Dictionary<string, List<double>>();
        var total = new Dictionary<string, double>();

        string input;

        while ((input = Console.ReadLine()) != "buy")
        {
            var cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var name = cmdArg[0];
            var price = double.Parse(cmdArg[1]);
            var quantity = double.Parse(cmdArg[2]);

            if (data.ContainsKey(name))
            {
                data[name][0] = price;
                data[name][1] += quantity;
            }
            else
            {
                data.Add(name, new List<double> {price, quantity});
            }
        }

        foreach (var (key, value) in data) total[key] = value[0] * value[1];

        foreach (var (key, value) in total) Console.WriteLine($"{key} -> {value:f2}");
    }
}