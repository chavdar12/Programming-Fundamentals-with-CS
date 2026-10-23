namespace Tests;

public class ArraysTests
{
    private const string Module = "005-Arrays";

    [Theory]
    [InlineData("Ex001", "3", "Wednesday")]
    [InlineData("Ex001", "8", "Invalid day!")]
    [InlineData("Ex002", "3\n10\n20\n30", "30 20 10")]
    [InlineData("Ex003", "0.9 1.5 2.4 2.5 3.14", "0.9 => 1\n1.5 => 2\n2.4 => 2\n2.5 => 3\n3.14 => 3")]
    [InlineData("Ex003", "-5.01 -1.599 -2.5 -1.50 0", "-5.01 => -5\n-1.599 => -2\n-2.5 => -3\n-1.5 => -2\n0 => 0")]
    [InlineData("Ex004", "a b c d e", "e d c b a")]
    [InlineData("Ex005", "1 2 3 4 5 6", "12")]
    [InlineData("Ex006", "1 2 3 4 5 6", "3")]
    [InlineData("Ex007", "10 20 30\n10 91 30", "Arrays are not identical. Found difference at 1 index")]
    [InlineData("Ex007", "1 2 3 4 5\n1 2 3 4 5", "Arrays are identical. Sum: 15")]
    [InlineData("Ex008", "2 10 3", "25")]
    [InlineData("Ex008", "5 0 4 1 2", "35")]
    [InlineData("Ex008", "1", "1")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
