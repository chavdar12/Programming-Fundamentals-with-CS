namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var num = Console.ReadLine();
        var sum = 0;
        var currentNum = 0;

        for (var i = 0; i <= num.Length - 1; i++)
        {
            if (i == 0) currentNum = int.Parse(num);

            sum += currentNum % 10;
            currentNum /= 10;
        }

        Console.WriteLine(sum);
    }
}