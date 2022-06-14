namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var reversed = string.Empty;

            for (var i = input.Length - 1; i >= 0; i--) reversed += input[i];

            Console.WriteLine($"{input} = {reversed}");
        }
    }
}