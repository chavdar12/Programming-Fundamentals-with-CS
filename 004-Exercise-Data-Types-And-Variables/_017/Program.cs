namespace _017;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var count = 0;
        for (var i = 1; i <= n; i++)
        {
            var bracket = Console.ReadLine();

            switch (bracket)
            {
                case "(":
                    count++;
                    break;
                case ")":
                    count--;
                    break;
            }

            switch (count)
            {
                case < 0:
                    Console.WriteLine("UNBALANCED");
                    return;
                case 2 or -2:
                    Console.WriteLine("UNBALANCED");
                    return;
            }
        }

        Console.WriteLine(count == 0 ? "BALANCED" : "UNBALANCED");
    }
}