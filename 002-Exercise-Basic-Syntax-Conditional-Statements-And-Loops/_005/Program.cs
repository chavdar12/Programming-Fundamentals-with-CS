namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var username = Console.ReadLine();
        var password = string.Empty;

        for (var i = username.Length - 1; i >= 0; i--) password += username[i];

        var trying = Console.ReadLine();
        if (trying != password)
            for (var i = 1; i <= 4; i++)
            {
                if (trying == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                trying = Console.ReadLine();
            }
        else
            Console.WriteLine($"User {username} logged in.");
    }
}