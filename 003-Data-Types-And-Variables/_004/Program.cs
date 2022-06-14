namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var centuries = byte.Parse(Console.ReadLine());
        var years = (short) (centuries * 100);
        var days = (int) (years * 365.2422);
        var hours = (uint) (days * 24);
        ulong minutes = hours * 60;
        Console.WriteLine(
            $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}