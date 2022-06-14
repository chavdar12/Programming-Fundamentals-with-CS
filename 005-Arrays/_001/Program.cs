namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var dayNumber = int.Parse(Console.ReadLine());

        string[] day =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        switch (dayNumber)
        {
            case >= 1 when dayNumber <= day.Length:
                Console.WriteLine(day[dayNumber - 1]);
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}