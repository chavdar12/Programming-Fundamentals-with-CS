namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var result = new List<int>();

        for (var i = 0; i < numbers.Count / 2; i++)
        {
            var newElement = numbers[i] + numbers[numbers.Count - 1 - i];
            result.Add(newElement);
        }

        if (numbers.Count % 2 != 0) result.Add(numbers[numbers.Count / 2]);

        Console.WriteLine(string.Join(" ", result));
    }
}