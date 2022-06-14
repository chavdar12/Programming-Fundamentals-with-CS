namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var number = Console.ReadLine();
        var sumFactorial = 0;

        for (var i = 0; i <= number.Length - 1; i++)
        {
            var currentChar = number[i];
            var currentDigit = currentChar - 48;
            var currentDigitFactorial = 1;
            for (var r = currentDigit; r > 1; r--) currentDigitFactorial *= r;

            sumFactorial += currentDigitFactorial;
        }

        Console.WriteLine(sumFactorial == int.Parse(number) ? "yes" : "no");
    }
}