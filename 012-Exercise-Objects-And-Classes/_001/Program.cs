namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        string[] phrases =
        {
            "Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can’t live without this product."
        };

        string[] events =
        {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
        };

        string[] authors =
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        string[] cities =
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        var random = new Random();

        for (var i = 0; i < n; i++)
            Console.WriteLine(
                $"{phrases[random.Next(0, phrases.Length)]} {events[random.Next(0, events.Length)]} {authors[random.Next(0, authors.Length)]} – {cities[random.Next(cities.Length)]}.");
    }
}