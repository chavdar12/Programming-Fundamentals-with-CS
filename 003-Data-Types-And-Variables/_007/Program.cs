namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var delimiter = Console.ReadLine();
        Console.WriteLine(firstName + delimiter + lastName);
    }
}