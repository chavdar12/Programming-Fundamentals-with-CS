namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var end = int.Parse(Console.ReadLine());

        Console.WriteLine(
            string.Join(Environment.NewLine, NumbersWithAtLeastOneOddDigit(NumbersDivideByEight(end))));
    }

    private static int[] NumbersDivideByEight(int end)
    {
        var result = new int[end];
        for (var i = 1; i <= end; i++) result[i - 1] = i;

        return result;
    }

    private static IEnumerable<string?> NumbersWithAtLeastOneOddDigit(object numbersDivideByEight)
    {
        foreach (var number in (int[])numbersDivideByEight)
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