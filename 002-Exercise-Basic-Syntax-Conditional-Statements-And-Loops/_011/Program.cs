namespace _011;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var pricePerCapsule = double.Parse(Console.ReadLine());
        var daysInMonth = int.Parse(Console.ReadLine());
        var numOfCapsules = int.Parse(Console.ReadLine());
        double total = 0;

        for (var i = 1; i <= n; i++)
        {
            var price = daysInMonth * numOfCapsules * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            total += price;
            if (i == n) break;

            pricePerCapsule = double.Parse(Console.ReadLine());
            daysInMonth = int.Parse(Console.ReadLine());
            numOfCapsules = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Total: ${total:f2}");
    }
}