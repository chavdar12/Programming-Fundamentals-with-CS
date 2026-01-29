namespace Ex011;

internal class Program
{
    private static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var command = cmdArg[0];

            switch (command)
            {
                case "exchange":
                {
                    var exchangeValue = int.Parse(cmdArg[1]);
                    if (exchangeValue < 0 || exchangeValue >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    array = ExchangeArray(array, exchangeValue).ToArray();
                    break;
                }
                case "max":
                {
                    var value = cmdArg[1];
                    switch (value)
                    {
                        case "odd":
                            MaxOdd(array);
                            break;
                        case "even":
                            MaxEven(array);
                            break;
                    }

                    break;
                }
                case "min":
                {
                    var value = cmdArg[1];
                    switch (value)
                    {
                        case "odd":
                            MinOdd(array);
                            break;
                        case "even":
                            MinEven(array);
                            break;
                    }

                    break;
                }
                case "first":
                {
                    var count = int.Parse(cmdArg[1]);
                    var cmd = cmdArg[2];

                    switch (cmd)
                    {
                        case "odd" when count > array.Length:
                            Console.WriteLine("Invalid count");
                            continue;
                        case "odd":
                            FirstOdd(array, count);
                            break;
                        case "even" when count > array.Length:
                            Console.WriteLine("Invalid count");
                            continue;
                        case "even":
                            FirstEven(array, count);
                            break;
                    }

                    break;
                }
                case "last":
                {
                    var count = int.Parse(cmdArg[1]);
                    var cmd = cmdArg[2];

                    switch (cmd)
                    {
                        case "odd" when count > array.Length:
                            Console.WriteLine("Invalid count");
                            continue;
                        case "odd":
                            LastOdd(array, count);
                            break;
                        case "even" when count > array.Length:
                            Console.WriteLine("Invalid count");
                            continue;
                        case "even":
                            LastEven(array, count);
                            break;
                    }

                    break;
                }
            }
        }

        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

    private static void LastEven(int[] array, int count)
    {
        var result = new List<int>();
        for (var i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == 0)
                result.Add(array[i]);
            if (result.Count == count)
                break;
        }

        result.Reverse();
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }

    private static void LastOdd(int[] array, int count)
    {
        var result = new List<int>();
        for (var i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 != 0)
                result.Add(array[i]);
            if (result.Count == count)
                break;
        }

        result.Reverse();
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }

    private static void FirstEven(int[] array, int count)
    {
        var result = new List<int>();
        foreach (var number in array)
        {
            if (number % 2 == 0)
                result.Add(number);
            if (result.Count == count)
                break;
        }

        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }

    private static void FirstOdd(int[] array, int count)
    {
        var result = new List<int>();
        foreach (var number in array)
        {
            if (number % 2 != 0)
                result.Add(number);
            if (result.Count == count)
                break;
        }

        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }

    private static void MinEven(int[] array)
    {
        var min = int.MaxValue;
        var index = -1;
        for (var i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0 && array[i] <= min)
            {
                min = array[i];
                index = i;
            }

        if (index == -1)
            Console.WriteLine("No matches");
        else
            Console.WriteLine(index);
    }

    private static void MinOdd(int[] array)
    {
        var min = int.MaxValue;
        var index = -1;
        for (var i = 0; i < array.Length; i++)
            if (array[i] % 2 != 0 && array[i] <= min)
            {
                min = array[i];
                index = i;
            }

        if (index == -1)
            Console.WriteLine("No matches");
        else
            Console.WriteLine(index);
    }

    private static void MaxEven(int[] array)
    {
        var max = int.MinValue;
        var index = -1;
        for (var i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0 && array[i] >= max)
            {
                max = array[i];
                index = i;
            }

        if (index == -1)
            Console.WriteLine("No matches");
        else
            Console.WriteLine(index);
    }

    private static void MaxOdd(int[] array)
    {
        var max = int.MinValue;
        var index = -1;
        for (var i = 0; i < array.Length; i++)
            if (array[i] % 2 != 0 && array[i] >= max)
            {
                max = array[i];
                index = i;
            }

        if (index == -1)
            Console.WriteLine("No matches");
        else
            Console.WriteLine(index);
    }

    private static IEnumerable<int> ExchangeArray(int[] array, int exchangeValue)
    {
        var left = array.Take(exchangeValue + 1).ToArray();
        var right = array.Skip(exchangeValue + 1).ToArray();
        return right.Concat(left).ToArray();
    }
}