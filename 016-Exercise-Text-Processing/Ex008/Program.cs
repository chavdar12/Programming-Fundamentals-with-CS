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
        var number = double.Parse(arg.Substring(1, arg.Length - 2));

        var firstLetterPosition = char.IsUpper(firstLetter) ? firstLetter - 64 : firstLetter - 96;

        return char.IsUpper(firstLetter) ? number / firstLetterPosition : number * firstLetterPosition;
    }
}