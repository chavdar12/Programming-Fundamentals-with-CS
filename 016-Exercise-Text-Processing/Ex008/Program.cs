namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var sum = input.Sum(CalculateItemSum);

        Console.WriteLine($"{sum:f2}");
    }

    private static double CalculateItemSum(string arg)
    {
        var firstLetter = arg[0];
        var lastLetter = arg[^1];
        var number = double.Parse(arg.Substring(1, arg.Length - 2));

        var firstLetterPosition = char.ToUpper(firstLetter) - 64;
        var lastLetterPosition = char.ToUpper(lastLetter) - 64;

        number = char.IsUpper(firstLetter) ? number / firstLetterPosition : number * firstLetterPosition;

        return char.IsUpper(lastLetter) ? number - lastLetterPosition : number + lastLetterPosition;
    }
}