namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var thirdNum = int.Parse(Console.ReadLine());
        var fourthNum = int.Parse(Console.ReadLine());

        var result = ((long) firstNum + secondNum) / thirdNum * fourthNum;
        Console.WriteLine(result);
    }
}