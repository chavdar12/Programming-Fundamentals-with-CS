namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();
        PrintPalindrome(command);
    }

    private static void PrintPalindrome(string? command)
    {
        var reversed = string.Empty;
        for (var i = command.Length - 1; i >= 0; i--) reversed += command[i];

        if (reversed == command)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}