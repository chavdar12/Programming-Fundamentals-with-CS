namespace _009;

internal static class Program
{
    private static void Main(string[] args)
    {
        var amountOfMoney = double.Parse(Console.ReadLine());
        var students = int.Parse(Console.ReadLine());
        var priceOfLightsaber = double.Parse(Console.ReadLine());
        var priceOfRobe = double.Parse(Console.ReadLine());
        var priceOfBelt = double.Parse(Console.ReadLine());

        var totalMoneyForLightsabers =
            students * priceOfLightsaber + Math.Ceiling(0.1 * students) * priceOfLightsaber;
        var totalMoneyForBelts = (students - Math.Floor((double) students / 6)) * priceOfBelt;
        var totalMoneyForRobe = students * priceOfRobe;
        var total = totalMoneyForLightsabers + totalMoneyForBelts + totalMoneyForRobe;

        Console.WriteLine(amountOfMoney >= total
            ? $"The money is enough - it would cost {total:f2}lv."
            : $" John will need {total - amountOfMoney:f2}lv more.");
    }
}