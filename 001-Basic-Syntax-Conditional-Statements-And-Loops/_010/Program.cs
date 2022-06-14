namespace _010;

internal static class Program
{
    private static void Main(string[] args)
    {
        var theInteger = int.Parse(Console.ReadLine());

        for (var times = 1; times <= 10; times++) Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
    }
}