namespace _016;

internal static class Program
{
    private static void Main(string[] args)
    {
        var key = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        var realChar = string.Empty;
        for (var i = 0; i < n; i++)
        {
            var currChar = char.Parse(Console.ReadLine());
            var charCode = currChar + key;
            realChar += (char) charCode;
        }

        Console.Write(realChar);
    }
}