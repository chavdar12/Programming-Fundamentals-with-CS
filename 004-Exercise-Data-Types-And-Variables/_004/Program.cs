namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            var currentChar = char.Parse(Console.ReadLine());
            int currentCharCode = currentChar;
            sum += currentCharCode;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}