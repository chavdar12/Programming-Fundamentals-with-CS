namespace _006;

internal static class Program
{
    private static void Main(string[] args)
    {
        var data = new Dictionary<string, List<string>>();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var cmdArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            var course = cmdArg[0];
            var student = cmdArg[1];

            if (!data.ContainsKey(course)) data[course] = new List<string>();

            data[course].Add(student);
        }


        foreach (var (course, students) in data)
        {
            Console.WriteLine($"{course}: {students.Count}");

            foreach (var student in students) Console.WriteLine($"-- {student}");
        }
    }
}