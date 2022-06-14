namespace _009;

internal static class Program
{
    private static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());

        var bestSequenceSize = 0;
        var bestSequenceStartIndex = 0;
        var bestSequenceSum = 0;
        var bestSequence = new int[size];
        var bestSample = 1;

        var sample = 0;

        while (true)
        {
            var line = Console.ReadLine();
            sample += 1;

            if (line == "Clone them!") break;

            var sequence = line.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var sequenceSum = sequence.Sum();


            for (var i = 0; i < sequence.Length; i++)
            {
                var currentNumber = sequence[i];
                if (currentNumber == 0) continue;

                var currentSequenceSize = 1;

                for (var j = i + 1; j < sequence.Length; j++)
                    if (currentNumber == sequence[j])
                        currentSequenceSize += 1;
                    else
                        break;

                if (currentSequenceSize > bestSequenceSize)
                {
                    bestSequenceSize = currentSequenceSize;
                    bestSequenceStartIndex = i;
                    bestSequenceSum = sequenceSum;
                    bestSequence = sequence;
                    bestSample = sample;
                }
                else if (currentSequenceSize == bestSequenceSize)
                {
                    if (i < bestSequenceStartIndex)
                    {
                        bestSequenceSize = currentSequenceSize;
                        bestSequenceStartIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSequence = sequence;
                        bestSample = sample;
                    }
                    else if (i == bestSequenceStartIndex && sequenceSum > bestSequenceSum)
                    {
                        bestSequenceSize = currentSequenceSize;
                        bestSequenceStartIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSequence = sequence;
                        bestSample = sample;
                    }
                }
            }
        }

        Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
        Console.WriteLine(string.Join(' ', bestSequence));
    }
}