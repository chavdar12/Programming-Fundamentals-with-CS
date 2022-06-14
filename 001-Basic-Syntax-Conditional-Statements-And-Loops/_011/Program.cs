namespace _011;

internal class Program
{
    private static void Main(string[] args)
    {
        var theInteger = int.Parse(Console.ReadLine());
        var multiplier = int.Parse(Console.ReadLine());

        if (multiplier is > 0 and <= 10)
            for (var i = multiplier; i <= 10; i++)
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
        else
            Console.WriteLine($"{theInteger} X {multiplier} = {theInteger * multiplier}");
    }
}