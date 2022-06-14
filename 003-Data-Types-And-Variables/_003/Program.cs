namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        decimal sum = 0;

        for (var i = 1; i <= n; i++)
        {
            var currentNum = decimal.Parse(Console.ReadLine());
            sum += currentNum;
        }

        Console.WriteLine(sum);
    }
}