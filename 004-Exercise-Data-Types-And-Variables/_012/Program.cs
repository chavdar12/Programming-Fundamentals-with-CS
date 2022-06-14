namespace _012;

internal static class Program
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();

        while (command != "END")
        {
            var isInteger = int.TryParse(command, out _);
            var isDouble = double.TryParse(command, out _);
            var isChar = char.TryParse(command, out _);
            var isBool = bool.TryParse(command, out _);

            if (isInteger)
                Console.WriteLine($"{command} is integer type");
            else if (isDouble)
                Console.WriteLine($"{command} is floating point type");
            else if (isChar)
                Console.WriteLine($"{command} is character type");
            else if (isBool)
                Console.WriteLine($"{command} is boolean type");
            else
                Console.WriteLine($"{command} is string type");

            command = Console.ReadLine();
        }
    }
}