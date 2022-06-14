namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        var command = Console.ReadLine();

        while (command != "end")
        {
            var cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (cmd[0])
            {
                case "Add":
                    numbers.Add(int.Parse(cmd[1]));
                    break;
                case "Remove":
                    numbers.Remove(int.Parse(cmd[1]));
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(cmd[1]));
                    break;
                case "Insert":
                    numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}