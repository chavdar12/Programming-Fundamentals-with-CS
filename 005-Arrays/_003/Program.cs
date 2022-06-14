namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        for (var i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0) numbers[i] = 0;

            Console.WriteLine(
                $"{(decimal) numbers[i]} => {Math.Round((decimal) numbers[i], MidpointRounding.AwayFromZero)}");
        }
    }
}