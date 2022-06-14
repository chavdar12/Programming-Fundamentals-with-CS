using System.Text;

namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var bigNumber = Console.ReadLine();
        var number = int.Parse(Console.ReadLine());

        var sb = new StringBuilder();
        var remainder = 0;

        if (number == 0 || bigNumber == "0")
        {
            Console.WriteLine(0);
            return;
        }

        for (var i = bigNumber.Length - 1; i >= 0; i--)
        {
            var result = int.Parse(bigNumber[i].ToString()) * number + remainder;
            remainder = 0;

            if (result > 9)
            {
                remainder = result / 10;
                result %= 10;
            }

            sb.Append(result);
        }

        var finalResult = new StringBuilder();

        if (remainder != 0) finalResult.Append(remainder);

        for (var i = sb.Length - 1; i >= 0; i--) finalResult.Append(sb[i]);

        Console.WriteLine(finalResult.ToString());
    }
}