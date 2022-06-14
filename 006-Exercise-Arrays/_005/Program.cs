namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

        for (var i = 0; i < arr.Length; i++)
        {
            var currentIterationIsBigger = true;
            for (var j = i + 1; j < arr.Length; j++)
                if (arr[i] <= arr[j])
                    currentIterationIsBigger = false;

            if (currentIterationIsBigger) Console.Write(arr[i] + " ");
        }
    }
}