namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var age = int.Parse(Console.ReadLine());

        switch (age)
        {
            case >= 0 and <= 2:
                Console.WriteLine("baby");
                break;
            case > 2 and <= 13:
                Console.WriteLine("child");
                break;
            case > 13 and <= 19:
                Console.WriteLine("teenager");
                break;
            case > 19 and <= 65:
                Console.WriteLine("adult");
                break;
            case > 65:
                Console.WriteLine("elder");
                break;
        }
    }
}