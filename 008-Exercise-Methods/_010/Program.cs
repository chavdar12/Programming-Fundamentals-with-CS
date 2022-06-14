namespace _010;

internal static class Program
{
    private static void Main(string[] args)
    {
        var end = int.Parse(Console.ReadLine());

        Console.WriteLine(
            string.Join(Environment.NewLine, NumbersWithAtLeastOneOddDigit(NumbersDivideByEight(end))));
    }

    private static List<int> NumbersDivideByEight(int end)
    {
        var sum = 0;
        var list = new List<int>();

        for (var i = 1; i <= end; i++)
        {
            var num = i;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 8 == 0) list.Add(i);

            sum = 0;
        }

        return list;
    }

    private static List<int> NumbersWithAtLeastOneOddDigit(List<int> list)
    {
        for (var i = 0; i < list.Count; i++)
        {
            var number = list[i];
            var currNum = number;
            var isOdd = false;

            while (currNum > 0)
            {
                var currDigit = currNum % 10;
                if (currDigit % 2 != 0)
                {
                    isOdd = true;
                    break;
                }

                currNum /= 10;
            }

            if (isOdd) continue;
            list.Remove(number);
            i -= 1;
        }

        return list;
    }
}