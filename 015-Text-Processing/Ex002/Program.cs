using System.Text;

namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var sb = new StringBuilder();

        foreach (var currWord in input) sb.Insert(sb.Length, currWord, currWord.Length);

        Console.WriteLine(sb);
    }
}