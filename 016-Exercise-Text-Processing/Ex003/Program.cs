namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

        var file = path[^1];
        var dot = file.LastIndexOf('.');

        var template = file[..dot];
        var extension = file[(dot + 1)..];

        Console.WriteLine($"File name: {template}");
        Console.WriteLine($"File extension: {extension}");
    }
}