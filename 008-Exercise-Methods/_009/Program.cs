namespace _009;

internal static class Program
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();
        PrintPalindrome(command);
    }

    private static void PrintPalindrome(string command)
    {
        var isPalindrome = false;

        while (command != "END")
        {
            for (var i = 0; i < command.Length / 2; i++)
            {
                if (command[i] == command[^1])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    Console.WriteLine("false");
                    break;
                }

                var num = int.Parse(command);
                num /= 10;
                command = num.ToString();
            }

            if (isPalindrome) Console.WriteLine("true");

            command = Console.ReadLine();
        }
    }
}