namespace Ex014;

internal class Program
{
    private static void Main(string[] args)
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Abs(a - b) < 0.000001);
    }
}