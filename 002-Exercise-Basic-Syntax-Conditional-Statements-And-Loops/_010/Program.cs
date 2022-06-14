namespace _010;

internal static class Program
{
    private static void Main(string[] args)
    {
        var lostGames = int.Parse(Console.ReadLine());
        var headsetPrice = double.Parse(Console.ReadLine());
        var mousePrice = double.Parse(Console.ReadLine());
        var keyboardPrice = double.Parse(Console.ReadLine());
        var displayPrice = double.Parse(Console.ReadLine());
        double expenses = 0;
        var count = 0;

        for (var game = 1; game <= lostGames; game++)
        {
            if (game % 2 == 0) expenses += headsetPrice;

            if (game % 3 == 0) expenses += mousePrice;

            if (game % 2 != 0 || game % 3 != 0) continue;
            expenses += keyboardPrice;
            count++;
            if (count % 2 == 0) expenses += displayPrice;
        }

        Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
    }
}