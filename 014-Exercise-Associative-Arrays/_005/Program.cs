namespace _005;

internal static class Program
{
    private static void Main(string[] args)
    {
        var data = new Dictionary<string, string>();

        var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var input = Console.ReadLine();

            var cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var command = cmdArg[0];
            var username = cmdArg[1];

            switch (command)
            {
                case "register":
                {
                    var plateNumber = cmdArg[2];

                    if (!data.ContainsKey(username))
                    {
                        data[username] = plateNumber;
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {data[username]}");
                    }

                    break;
                }
                case "unregister" when !data.ContainsKey(username):
                    Console.WriteLine($"ERROR: user {username} not found");
                    break;
                case "unregister":
                    data.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                    break;
            }
        }

        foreach (var (key, value) in data) Console.WriteLine($"{key} => {value}");
    }
}