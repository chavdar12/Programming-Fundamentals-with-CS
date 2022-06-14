namespace _008;

internal static class Program
{
    private static void Main(string[] args)
    {
        var data = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArg = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

            var company = cmdArg[0];
            var idNumber = cmdArg[1];

            if (!data.ContainsKey(company)) data[company] = new List<string>();

            if (data[company].Contains(idNumber)) continue;

            data[company].Add(idNumber);
        }

        foreach (var (key, students) in data)
        {
            Console.WriteLine(key);
            foreach (var student in students) Console.WriteLine($"--{student}");
        }
    }
}