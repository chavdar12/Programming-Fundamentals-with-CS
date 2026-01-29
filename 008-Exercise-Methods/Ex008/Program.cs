namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());

        DivideFirstToSecond(CalculateFactorial(first), CalculateFactorial(second));
    }

    private static void DivideFirstToSecond(int calculateFactorial, int i)
    {
        Console.WriteLine($"{calculateFactorial / i:F2}");
    }

    private static int CalculateFactorial(int first)
    {
        var result = 1;
        for (var i = 1; i <= first; i++) result *= i;

        return result;
    }
}