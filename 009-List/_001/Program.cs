﻿namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).ToList();

        for (var i = 0; i < numbers.Count - 1; i++)
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = -1;
            }

        Console.WriteLine(string.Join(" ", numbers));
    }
}