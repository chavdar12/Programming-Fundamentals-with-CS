namespace _016;

internal static class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var word = string.Empty;


        for (var i = 1; i <= number; i++)
        {
            var text = Console.ReadLine();
            var currentNumber = int.Parse(text);
            var mainDigit = currentNumber % 10;

            var offset = (mainDigit - 2) * 3;
            if (mainDigit == 8 || mainDigit == 9) offset++;

            offset = offset + (text.Length - 1) + 97;
            var letter = (char) offset;
            if (text == "0")
                word += " ";
            else
                word += letter;
        }

        Console.WriteLine(word);
    }
}