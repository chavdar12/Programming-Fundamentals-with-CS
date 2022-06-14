namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var guests = new List<string>();

        for (var i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            switch (command.Length)
            {
                case 3 when guests.Contains(command[0]):
                    Console.WriteLine($"{command[0]} is already in the list!");
                    break;
                case 3:
                    guests.Add(command[0]);
                    break;
                case 4 when guests.Contains(command[0]):
                    guests.Remove(command[0]);
                    break;
                case 4:
                    Console.WriteLine($"{command[0]} is not in the list!");
                    break;
            }
        }

        foreach (var item in guests) Console.WriteLine(item);
    }
}