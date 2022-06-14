namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 3.00) Console.WriteLine("Passed!");
    }
}