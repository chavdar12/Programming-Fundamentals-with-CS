using System.Numerics;

namespace _011;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        BigInteger maxSnowballValue = 0;
        var maxSnowballSnow = 0;
        var maxSnowballTime = 0;
        var maxSnowballQuality = 0;


        for (var i = 1; i <= n; i++)
        {
            var snowballSnow = int.Parse(Console.ReadLine());
            var snowballTime = int.Parse(Console.ReadLine());
            var snowballQuality = int.Parse(Console.ReadLine());
            var snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
            if (snowballValue <= maxSnowballValue) continue;
            maxSnowballValue = snowballValue;
            maxSnowballSnow = snowballSnow;
            maxSnowballTime = snowballTime;
            maxSnowballQuality = snowballQuality;
        }

        Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
    }
}