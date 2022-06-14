namespace _013;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        long sum = 0;

        for (var i = 0; i < n; i++)
        {
            var currArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var biggerNum = currArr[0] > currArr[1] ? currArr[0] : currArr[1];

            while (biggerNum != 0)
            {
                var digit = biggerNum % 10;
                sum += digit;
                biggerNum /= 10;
            }

            Console.WriteLine(Math.Abs(sum));
            sum = 0;
        }
    }
}