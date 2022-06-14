namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        var rotation = int.Parse(Console.ReadLine());

        for (var i = 0; i < rotation; i++)
        {
            var temp = arr[0];
            for (var j = 0; j < arr.Length - 1; j++) arr[j] = arr[j + 1];

            arr[^1] = temp;
        }

        Console.WriteLine(string.Join(" ", arr));
    }
}