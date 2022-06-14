namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        var command = Console.ReadLine();

        while (command != "End")
        {
            var cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            switch (cmd[0])
            {
                case "Add":
                    list.Add(int.Parse(cmd[1]));
                    break;
                case "Insert":
                {
                    var numberToInsert = int.Parse(cmd[1]);
                    var indexToInsert = int.Parse(cmd[2]);
                    if (indexToInsert >= list.Count || indexToInsert < 0)
                        Console.WriteLine("Invalid index");
                    else
                        list.Insert(indexToInsert, numberToInsert);

                    break;
                }
                case "Remove":
                {
                    var indexToRemove = int.Parse(cmd[1]);
                    if (indexToRemove >= list.Count || indexToRemove < 0)
                        Console.WriteLine("Invalid index");
                    else
                        list.RemoveAt(indexToRemove);

                    break;
                }
                case "Shift":
                {
                    var count = int.Parse(cmd[2]);
                    switch (cmd[1])
                    {
                        case "left":
                        {
                            for (var i = 0; i < count; i++)
                            {
                                var firstNum = list[0];
                                list.Add(firstNum);
                                list.RemoveAt(0);
                            }

                            break;
                        }
                        case "right":
                        {
                            for (var i = 0; i < count; i++)
                            {
                                var lastNum = list[^1];
                                list.Insert(0, lastNum);
                                list.RemoveAt(list.Count - 1);
                            }

                            break;
                        }
                    }

                    break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", list));
    }
}