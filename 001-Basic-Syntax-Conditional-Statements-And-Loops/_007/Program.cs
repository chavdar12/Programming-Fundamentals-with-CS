namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var typeOfDay = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        double price = 0;

        switch (age)
        {
            case >= 0 and <= 18 when typeOfDay == "Weekday":
                price = 12;
                break;
            case >= 0 and <= 18 when typeOfDay == "Weekend":
                price = 15;
                break;
            case >= 0 and <= 18:
            {
                if (typeOfDay == "Holiday") price = 5;

                break;
            }
            case > 18 and <= 64 when typeOfDay == "Weekday":
                price = 18;
                break;
            case > 18 and <= 64 when typeOfDay == "Weekend":
                price = 20;
                break;
            case > 18 and <= 64:
            {
                if (typeOfDay == "Holiday") price = 12;

                break;
            }
            case > 64 and <= 122 when typeOfDay == "Weekday":
                price = 12;
                break;
            case > 64 and <= 122 when typeOfDay == "Weekend":
                price = 15;
                break;
            case > 64 and <= 122:
            {
                if (typeOfDay == "Holiday") price = 10;

                break;
            }
            default:
                Console.WriteLine("Error!");
                break;
        }

        if (price > 0) Console.WriteLine($"{price}$");
    }
}