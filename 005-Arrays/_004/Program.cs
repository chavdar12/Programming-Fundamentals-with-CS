namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (var i = arr.Length - 1; i >= 0; i--) Console.Write($"{arr[i]} ");
    }
}