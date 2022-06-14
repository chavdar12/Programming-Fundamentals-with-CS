namespace _005;

internal class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var students = new List<Student>();

        while (command != "end")
        {
            var data = command.Split();
            var firstName = data[0];
            var lastName = data[1];
            var age = int.Parse(data[2]);
            var homeTown = data[3];

            var student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (student == null)
            {
                students.Add(new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                });
            }
            else
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
            }

            command = Console.ReadLine();
        }

        var town = Console.ReadLine();
        var filteredStudents = students.Where(s => s.HomeTown == town).ToList();

        foreach (var student in filteredStudents) Console.WriteLine(student.ToString());
    }
}