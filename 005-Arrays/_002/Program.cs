namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var num = new int[n];
        for (var j = 0; j < num.Length; j++) num[j] = int.Parse(Console.ReadLine());

        for (var i = num.Length - 1; i >= 0; i--) Console.Write($"{num[i]} ");
    }
}