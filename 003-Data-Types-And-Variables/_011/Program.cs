namespace _011;

internal static class Program
{
    private static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine());
        Console.Write("Length: ");
        var width = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        var height = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        var volume = length * width * height / 3;

        Console.WriteLine($"Pyramid Volume: {volume:f2}");
    }
}