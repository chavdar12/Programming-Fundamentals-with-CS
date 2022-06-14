using System.Text;

namespace _002;

internal static class Program
{
    private static void Main(string[] args)
    {
        var participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

        string info;
        var distance = 0;
        var data = new Dictionary<string, int>();

        while ((info = Console.ReadLine()) != "end of race")
        {
            var chars = info.ToCharArray();
            var sb = new StringBuilder();

            foreach (var @ch in chars)
                if (char.IsLetter(ch))
                    sb.Append(ch);
                else if (char.IsDigit(ch)) distance += int.Parse(ch.ToString());

            if (participants.Contains(sb.ToString()))
            {
                if (!data.ContainsKey(sb.ToString())) data[sb.ToString()] = 0;

                data[sb.ToString()] += distance;
            }

            sb.Clear();
            distance = 0;
        }

        data = data.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value);

        var counter = 1;
        foreach (var (key, _) in data)
            switch (counter)
            {
                case 1:
                    Console.WriteLine($"1st place: {key}");
                    counter++;
                    continue;
                case 2:
                    Console.WriteLine($"2nd place: {key}");
                    counter++;
                    continue;
                case 3:
                    Console.WriteLine($"3rd place: {key}");
                    break;
            }
    }
}