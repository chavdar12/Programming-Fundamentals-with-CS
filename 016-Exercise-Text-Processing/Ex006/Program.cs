namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();

        for (var i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1]) continue;
            text = text.Remove(i, 1);
            i -= 1;
        }

        Console.WriteLine(text);
    }
}