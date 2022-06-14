namespace _011;

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var result = new List<int>();

        for (var i = 0; i < n; i++)
        {
            var name = Console.ReadLine();
            var currSum = 0;
            char[] vowels = {'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I'};

            foreach (var ch in name)
                if (vowels.Contains(ch))
                    currSum += ch * name.Length;
                else
                    currSum += ch / name.Length;

            result.Add(currSum);
        }

        result.Sort();
        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}