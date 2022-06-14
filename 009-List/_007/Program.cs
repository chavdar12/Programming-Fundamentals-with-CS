namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        var command = Console.ReadLine();

        var counter = 0;

        while (command != "end")
        {
            var cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (cmd[0])
            {
                case "Contains" when numbers.Contains(int.Parse(cmd[1])):
                    Console.WriteLine("Yes");
                    break;
                case "Contains":
                    Console.WriteLine("No such number");
                    break;
                case "PrintEven":
                {
                    var evenList = new List<int>();
                    evenList.AddRange(numbers);
                    evenList.RemoveAll(item => item % 2 != 0);
                    Console.WriteLine(string.Join(" ", evenList));
                    break;
                }
                case "PrintOdd":
                {
                    var oddList = new List<int>();
                    oddList.AddRange(numbers);
                    oddList.RemoveAll(item => item % 2 == 0);
                    Console.WriteLine(string.Join(" ", oddList));
                    break;
                }
                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;
                case "Filter":
                {
                    var filterNum = int.Parse(cmd[2]);
                    List<int> filterList;

                    if (cmd[1] == "<")
                    {
                        filterList = numbers.FindAll(item => item < filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }

                    if (cmd[1] == ">")
                    {
                        filterList = numbers.FindAll(item => item > filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }

                    if (cmd[1] == "<=")
                    {
                        filterList = numbers.FindAll(item => item <= filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }

                    if (cmd[1] == ">=")
                    {
                        filterList = numbers.FindAll(item => item >= filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }

                    break;
                }
                case "Add":
                    numbers.Add(int.Parse(cmd[1]));
                    counter++;
                    break;
                case "Remove":
                    numbers.Remove(int.Parse(cmd[1]));
                    counter++;
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(cmd[1]));
                    counter++;
                    break;
                case "Insert":
                    numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                    counter++;
                    break;
            }

            command = Console.ReadLine();
        }

        if (counter > 0) Console.WriteLine(string.Join(" ", numbers));
    }
}