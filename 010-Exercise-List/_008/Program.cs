using System.Text;

namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        string input;

        while ((input = Console.ReadLine()) != "3:1")
        {
            var command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            switch (command[0])
            {
                case "merge":
                {
                    var startIndex = int.Parse(command[1]);
                    var endIndex = int.Parse(command[2]);

                    switch (startIndex)
                    {
                        case < 0 when endIndex >= list.Count:
                            continue;
                        case < 0:
                            startIndex = 0;
                            break;
                    }

                    if (endIndex >= list.Count) endIndex = list.Count - 1;

                    var merged = new StringBuilder();

                    for (var i = startIndex; i <= endIndex; i++)
                    {
                        merged.Append(list[startIndex]);
                        list.RemoveAt(startIndex);
                    }

                    list.Insert(startIndex, merged.ToString());
                    break;
                }
                case "divide":
                {
                    var index = int.Parse(command[1]);
                    var partitions = int.Parse(command[2]);

                    if (partitions > list.Count) continue;

                    var wordToDivide = list[index];

                    var divideArray = new char[wordToDivide.Length];

                    for (var i = 0; i <= wordToDivide.Length; i++) divideArray[i] = wordToDivide[i];

                    break;
                }
            }
        }
    }
}