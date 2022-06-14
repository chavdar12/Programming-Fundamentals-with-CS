namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<string>();

        for (var i = 0; i < n; i++)
        {
            var item = Console.ReadLine();

            list.Add(item);
        }

        list.Sort();

        for (var j = 1; j <= n; j++) Console.WriteLine($"{j}.{list[j - 1]}");
    }
}