namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();
        var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

        var specialNumber = arr[0];
        var power = arr[1];

        var bombIndex = list.IndexOf(specialNumber);

        while (bombIndex != -1)
        {
            var leftNumbers = bombIndex - power;
            var rightNumbers = bombIndex + power;

            if (leftNumbers < 0) leftNumbers = 0;

            if (rightNumbers > list.Count - 1) rightNumbers = list.Count - 1;

            list.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

            bombIndex = list.IndexOf(specialNumber);
        }

        var sum = list.Sum();

        Console.WriteLine(sum);
    }
}