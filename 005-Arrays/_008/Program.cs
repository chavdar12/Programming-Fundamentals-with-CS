namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var firstLength = array.Length;

        for (var i = 0; i < firstLength - 1; i++)
        {
            var condensed = new int[array.Length - 1];

            for (var j = 0; j < array.Length - 1; j++) condensed[j] = array[j] + array[j + 1];

            array = condensed;
        }

        Console.WriteLine(array[0]);
    }
}