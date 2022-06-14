namespace _010;

internal static class Program
{
    private static void Main(string[] args)
    {
        var letter = char.Parse(Console.ReadLine());
        if (letter >= 65 && letter <= 90)
            Console.WriteLine("upper-case");
        else if (letter >= 97 && letter <= 122) Console.WriteLine("lower-case");
    }
}