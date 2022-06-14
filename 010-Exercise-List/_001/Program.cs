namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        var capacity = int.Parse(Console.ReadLine());
        var command = Console.ReadLine();

        while (command != "end")
        {
            var cmd = command.Split();
            if (cmd[0] == "Add")
                wagons.Add(int.Parse(cmd[1]));
            else
                for (var i = 0; i < wagons.Count; i++)
                {
                    var passengers = int.Parse(cmd[0]);
                    if (passengers > capacity - wagons[i]) continue;
                    wagons[i] += passengers;
                    break;
                }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", wagons));
    }
}