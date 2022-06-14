namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());


        for (var i = 1; i <= n; i++)
        {
            var currentNum = i;
            var currentNumberSum = 0;

            while (currentNum != 0)
            {
                currentNumberSum += currentNum % 10;
                currentNum /= 10;
            }

            var isSpecial = currentNumberSum is 5 or 7 or 11;
            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }
}