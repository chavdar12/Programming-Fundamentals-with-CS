namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var hour = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        minutes += 30;
        if (minutes > 59)
        {
            hour += 1;
            minutes -= 60;
        }

        if (hour > 23) hour = 0;

        Console.WriteLine($"{hour}:{minutes:d2}");
    }
}