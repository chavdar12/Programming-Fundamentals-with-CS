namespace Tests;

public class BasicSyntaxTests
{
    private const string Module = "001-Basic-Syntax-Conditional-Statements-And-Loops";

    [Theory]
    [InlineData("Ex001", "Peter\n20\n5.5", "Name: Peter, Age: 20, Grade: 5.50")]
    [InlineData("Ex001", "George\n18\n5.4466", "Name: George, Age: 18, Grade: 5.45")]
    [InlineData("Ex002", "5.32", "Passed!")]
    [InlineData("Ex002", "2.34", "")]
    [InlineData("Ex003", "5.32", "Passed!")]
    [InlineData("Ex003", "2.36", "Failed!")]
    [InlineData("Ex004", "1\n46", "2:16")]
    [InlineData("Ex004", "23\n59", "0:29")]
    [InlineData("Ex004", "11\n08", "11:38")]
    [InlineData("Ex005", "2", "February")]
    [InlineData("Ex005", "13", "Error!")]
    [InlineData("Ex006", "USA", "English")]
    [InlineData("Ex006", "Mexico", "Spanish")]
    [InlineData("Ex006", "Germany", "unknown")]
    [InlineData("Ex007", "Weekday\n42", "18$")]
    [InlineData("Ex007", "Holiday\n15", "5$")]
    [InlineData("Ex007", "Holiday\n-12", "Error!")]
    [InlineData("Ex009", "3", "1\n3\n5\nSum: 9")]
    [InlineData("Ex010", "2", "2 X 1 = 2\n2 X 2 = 4\n2 X 3 = 6\n2 X 4 = 8\n2 X 5 = 10\n2 X 6 = 12\n2 X 7 = 14\n2 X 8 = 16\n2 X 9 = 18\n2 X 10 = 20")]
    [InlineData("Ex011", "5\n8", "5 X 8 = 40\n5 X 9 = 45\n5 X 10 = 50")]
    [InlineData("Ex011", "2\n14", "2 X 14 = 28")]
    [InlineData("Ex012", "1\n3\n6", "Please write an even number.\nPlease write an even number.\nThe number is: 6")]
    [InlineData("Ex012", "-4", "The number is: 4")]
    [InlineData("Ex013", "1.1.2024\n14.1.2024", "4")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));

    [Fact]
    public void Ex008_PrintsMultiplesOfThreeBelow100() =>
        Assert.Equal(string.Join("\n", Enumerable.Range(1, 33).Select(i => i * 3)),
            ProgramRunner.Run($"{Module}/Ex008"));
}
