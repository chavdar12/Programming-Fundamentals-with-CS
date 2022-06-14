namespace _005;

internal static class Program
{
    private static void Main()
    {
        var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        list.RemoveAll(x => x < 0);
        list.Reverse();

        Console.WriteLine(list.Count == 0 ? "empty" : string.Join(" ", list));
    }
}