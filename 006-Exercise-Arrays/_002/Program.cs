namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var firstArray = Console.ReadLine().Split(' ');
        var secondArray = Console.ReadLine().Split(' ');

        foreach (var elementTwo in secondArray)
        foreach (var elementOne in firstArray)
        {
            if (elementOne != elementTwo) continue;
            Console.Write(elementOne + " ");
            break;
        }
    }
}