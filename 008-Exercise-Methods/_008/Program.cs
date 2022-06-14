using System.Numerics;

namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());

        DivideFirstToSecond(CalculateFactorial(first), CalculateFactorial(second));
    }

    private static BigInteger CalculateFactorial(int n)
    {
        BigInteger result = 1;
        for (var i = 2; i <= n; i++) result *= i;

        return result;
    }

    private static void DivideFirstToSecond(BigInteger first, BigInteger second)
    {
        var result = (decimal) first / (decimal) second;
        Console.WriteLine($"{result:f2}");
    }
}