namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var firstChar = (char) ('a' + i);
            for (var j = 0; j < n; j++)
            {
                var secondChar = (char) ('a' + j);
                for (var k = 0; k < n; k++)
                {
                    var thirdChar = (char) ('a' + k);
                    Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                }
            }
        }
    }
}