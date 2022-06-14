namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var country = Console.ReadLine();
        switch (country)
        {
            case "Argentina":
            case "Spain":
            case "Mexico":
                Console.WriteLine("Spanish");
                break;
            case "USA":
            case "England":
                Console.WriteLine("English");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}