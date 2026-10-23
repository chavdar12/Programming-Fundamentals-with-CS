using System.Text;

namespace Ex008;

internal class Program
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

                    startIndex = Math.Max(startIndex, 0);
                    endIndex = Math.Min(endIndex, list.Count - 1);

                    if (startIndex > endIndex) continue;

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

                    var wordToDivide = list[index];
                    var partLength = wordToDivide.Length / partitions;

                    var parts = new List<string>();

                    // the last part takes the remainder when the word doesn't divide evenly
                    for (var i = 0; i < partitions - 1; i++) parts.Add(wordToDivide.Substring(i * partLength, partLength));
                    parts.Add(wordToDivide.Substring((partitions - 1) * partLength));

                    list.RemoveAt(index);
                    list.InsertRange(index, parts);
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}