namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var rnd = new Random();

        for (var i = 0; i < words.Length; i++)
        {
            var index = rnd.Next(0, words.Length);
            (words[i], words[index]) = (words[index], words[i]);
        }

        foreach (var item in words) Console.WriteLine(item);
    }
}