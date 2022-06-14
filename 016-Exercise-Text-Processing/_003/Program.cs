namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var path = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

        var file = path[^1].Split('.');

        var template = file[0];
        var extension = file[1];

        Console.WriteLine($"File name: {template}");
        Console.WriteLine($"File extension: {extension}");
    }
}