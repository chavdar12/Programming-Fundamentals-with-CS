namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var encrypted = text.Aggregate(string.Empty, (current, c) => current + (char)(c + 3));

        Console.WriteLine(encrypted);
    }
}