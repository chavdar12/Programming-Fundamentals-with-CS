namespace Tests;

public class ArraysExerciseTests
{
    private const string Module = "006-Exercise-Arrays";

    [Theory]
    [InlineData("Ex001", "3\n1\n2\n3", "1 2 3\n6")]
    [InlineData("Ex002", "Hey hello 2 4\n10 hey 4 hello", "4 hello")]
    [InlineData("Ex003", "4\n1 5\n9 10\n31 81\n41 20", "1 10 31 20\n5 9 81 41")]
    [InlineData("Ex004", "51 47 32 61 21\n2", "32 61 21 51 47")]
    [InlineData("Ex005", "1 4 3 2", "4 3 2")]
    [InlineData("Ex005", "14 24 3 19 15 17", "24 19 17")]
    [InlineData("Ex006", "1 2 3 3", "2")]
    [InlineData("Ex006", "1 2", "no")]
    [InlineData("Ex006", "1", "0")]
    [InlineData("Ex007", "2 1 1 2 3 3 2 2 2 1", "2 2 2")]
    [InlineData("Ex007", "1 1 1 2 3 1 3 3", "1 1 1")]
    [InlineData("Ex007", "4 4 4 4", "4 4 4 4")]
    [InlineData("Ex008", "1 7 6 2 19 23\n8", "1 7\n6 2")]
    [InlineData("Ex009", "5\n1!0!1!1!0\n0!1!1!0!0\nClone them!", "Best DNA sample 2 with sum: 2.\n0 1 1 0 0")]
    [InlineData("Ex010", "3\n0 1\n0 right 1\n2 right 1\nend", "0 1 0")]
    [InlineData("Ex010", "3\n0 1 2\n0 right 1\n1 right 1\n2 right 1\nend", "0 0 0")]
    [InlineData("Ex011", "4\nPeter\nMaria\nKaty\nHarry", "1032\n1071\n1168\n1532")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
