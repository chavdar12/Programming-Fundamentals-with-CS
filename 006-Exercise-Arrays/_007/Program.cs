namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

        var currentNum = arr[0];
        var counter = 0;
        var longNum = 0;
        var longCounter = counter;

        foreach (var i in arr)
            if (currentNum == i)
            {
                counter++;
                if (counter <= longCounter) continue;
                longNum = currentNum;
                longCounter = counter;
            }
            else
            {
                counter = 1;
                currentNum = i;
            }

        var longArr = new int[longCounter];

        for (var i = 0; i < longArr.Length; i++) longArr[i] = longNum;

        Console.WriteLine(string.Join(" ", longArr));
    }
}