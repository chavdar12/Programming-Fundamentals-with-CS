namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var maxValue = double.MinValue;
        var maxModel = string.Empty;

        for (var i = 1; i <= n; i++)
        {
            var model = Console.ReadLine();
            var radius = double.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var volume = Math.PI * Math.Pow(radius, 2) * height;
            if (!(volume > maxValue)) continue;
            maxValue = volume;
            maxModel = model;
        }

        Console.WriteLine(maxModel);
    }
}