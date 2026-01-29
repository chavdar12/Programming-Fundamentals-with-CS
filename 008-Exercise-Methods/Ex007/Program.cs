namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        PrintMatrix(n);
    }

    private static void PrintMatrix(int i)
    {
        for (var j = 0; j < i; j++)
        {
            for (var k = 0; k < i; k++) Console.Write(i + " ");

            Console.WriteLine();
        }
    }
}