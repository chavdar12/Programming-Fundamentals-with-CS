namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var third = int.Parse(Console.ReadLine());

        Console.WriteLine(SubtractThirdFromSumOfFirstAndSecond(SumOfFistAndSecond(first, second), third));
    }

    private static int SumOfFistAndSecond(int first, int second)
    {
        return first + second;
    }

    private static bool SubtractThirdFromSumOfFirstAndSecond(int sumOfFistAndSecond, int third)
    {
        return sumOfFistAndSecond - third >= 0;
    }
}