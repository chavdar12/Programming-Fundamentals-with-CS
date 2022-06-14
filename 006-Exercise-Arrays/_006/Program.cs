namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

        for (var i = 0; i < array.Length; i++)
        {
            if (array.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            var leftSum = 0;
            for (var left = i; left > 0; left--) leftSum += array[left - 1];

            var rightSum = 0;
            for (var right = i; right < array.Length - 1; right++) rightSum += array[right + 1];

            if (rightSum != leftSum) continue;
            Console.WriteLine(i);
            return;
        }

        Console.WriteLine("no");
    }
}