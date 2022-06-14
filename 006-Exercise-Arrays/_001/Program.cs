namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var arr = new int[n];
        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(sum);
    }
}