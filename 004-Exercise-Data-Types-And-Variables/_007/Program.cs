namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var waterTankCapacity = 255;
        var waterTank = 0;

        for (var i = 0; i < n; i++)
        {
            var litersOfWater = int.Parse(Console.ReadLine());
            if (waterTankCapacity < litersOfWater)
            {
                Console.WriteLine("Insufficient capacity!");
                continue;
            }

            waterTank += litersOfWater;
            waterTankCapacity -= litersOfWater;
        }

        Console.WriteLine(waterTank);
    }
}