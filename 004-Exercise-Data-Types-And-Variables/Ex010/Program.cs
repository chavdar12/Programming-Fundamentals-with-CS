namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var power = n;
        var counter = 0;

        while (power >= m)
        {
            power -= m;
            counter++;

            if (power * 2 == n && y != 0) power /= y;
        }

        Console.WriteLine(power);
        Console.WriteLine(counter);
    }
}