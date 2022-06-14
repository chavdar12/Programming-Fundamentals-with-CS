namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var persons = double.Parse(Console.ReadLine());
        var capacity = double.Parse(Console.ReadLine());
        var courses = (int) persons / (int) capacity;

        if (persons % capacity == 0)
            Console.WriteLine(courses);
        else
            Console.WriteLine(courses + 1);
    }
}