using System.Text;

namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var sb = new StringBuilder();
        var strength = 0;

        for (var i = 0; i < line.Length; i++)
            if (line[i] == '>')
            {
                strength += int.Parse(line[i + 1].ToString());
                sb.Append(line[i]);
            }
            else
            {
                if (strength > 0)
                {
                    strength -= 1;
                    continue;
                }

                sb.Append(line[i]);
            }

        Console.WriteLine(sb.ToString());
    }
}