using System.Text;

namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var sb = new StringBuilder();

        foreach (var currWord in input)
        foreach (var i in currWord)
            sb.Append(i);

        Console.WriteLine(sb);
    }
}