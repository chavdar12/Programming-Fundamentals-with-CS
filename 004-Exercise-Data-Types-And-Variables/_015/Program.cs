namespace _015;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (var i = 2; i <= n; i++)
        {
            var isPrime = true;
            for (var num = 2; num < i; num++)
            {
                if (i % num != 0) continue;
                isPrime = false;
                break;
            }

            Console.WriteLine(isPrime ? $"{i} -> true" : $"{i} -> false");
        }
    }
}