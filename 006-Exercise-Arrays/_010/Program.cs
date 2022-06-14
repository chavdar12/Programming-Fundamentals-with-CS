namespace _010;

internal static class Program
{
    private static void Main(string[] args)
    {
        var fieldSize = int.Parse(Console.ReadLine());

        var field = new bool[fieldSize];

        var initialIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        foreach (var index in initialIndexes)
        {
            if (index < 0 || index >= field.Length) continue;

            field[index] = true;
        }

        while (true)
        {
            var line = Console.ReadLine();

            if (line == "end") break;

            var parts = line.Split();

            var index = int.Parse(parts[0]);
            var direction = parts[1];
            var length = int.Parse(parts[2]);

            if (index < 0 || index >= field.Length || !field[index]) continue;

            field[index] = false;

            while (true)
            {
                if (direction == "right")
                    index += length;
                else
                    index -= length;

                if (index >= field.Length || index < 0) break;

                if (field[index]) continue;
                field[index] = true;
                break;
            }
        }

        foreach (var cell in field) Console.Write(cell ? "1 " : "0 ");
    }
}