namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var end = int.Parse(Console.ReadLine());

        Console.WriteLine(
            string.Join(Environment.NewLine, NumbersWithAtLeastOneOddDigit(NumbersWithDigitSumDivisibleByEight(end))));
    }

    private static int[] NumbersWithDigitSumDivisibleByEight(int end)
    {
        return Enumerable.Range(1, end).Where(n => n.ToString().Sum(c => c - '0') % 8 == 0).ToArray();
    }

    private static IEnumerable<string?> NumbersWithAtLeastOneOddDigit(int[] numbers)
    {
        foreach (var number in numbers)
        {
            var currentNumber = number;
            while (currentNumber > 0)
            {
                if (currentNumber % 2 != 0)
                {
                    yield return number.ToString();
                    break;
                }

                currentNumber /= 10;
            }
        }
    }
}