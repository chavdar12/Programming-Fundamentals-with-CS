namespace _010;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var counter = 0;

        for (var i = n - m; i >= 0; i -= m)
        {
            counter++;
            if (i == n * 0.5 && y != 0) i /= y;

            if (i >= m) continue;
            Console.WriteLine(i);
            Console.WriteLine(counter);
            break;
        }
    }
}