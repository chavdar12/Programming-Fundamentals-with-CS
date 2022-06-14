namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var grade = double.Parse(Console.ReadLine());

        Console.WriteLine(grade >= 3.00 ? "Passed!" : "Failed!");
    }
}