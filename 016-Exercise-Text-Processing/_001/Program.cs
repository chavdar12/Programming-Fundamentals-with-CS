namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
        var validUsernames = new List<string>();

        foreach (var user in usernames)
        {
            var isValid = true;

            if (user.Length is < 3 or > 16) continue;

            foreach (var i in user.Where(i => !(char.IsLetterOrDigit(i) || i is '-' or '_'))) isValid = false;

            if (isValid) validUsernames.Add(user);
        }

        Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
    }
}