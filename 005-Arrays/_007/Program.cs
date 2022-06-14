namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr1 = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var arr2 = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var sum = 0;
        var isEqual = false;

        for (var i = 0; i < arr1.Length; i++)
        {
            sum += arr1[i];
            if (arr1[i] == arr2[i]) continue;
            Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            isEqual = true;
            break;
        }

        if (!isEqual) Console.WriteLine($"Arrays are identical. Sum: {sum}");
    }
}