namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        var command = Console.ReadLine();

        while (command != "end")
        {
            var cmd = command.Split();
            switch (cmd[0])
            {
                case "Delete":
                {
                    var item = int.Parse(cmd[1]);
                    numbers.RemoveAll(x => x == item);
                    break;
                }
                case "Insert":
                {
                    var numToInsert = int.Parse(cmd[1]);
                    var indexToInsert = int.Parse(cmd[2]);
                    numbers.Insert(indexToInsert, numToInsert);
                    break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}