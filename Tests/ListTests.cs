namespace Tests;

public class ListTests
{
    private const string Module = "009-List";

    [Theory]
    [InlineData("Ex001", "3 3 6 1", "12 1")]
    [InlineData("Ex001", "8 2 2 4 8 16", "16 8 16")]
    [InlineData("Ex002", "1 2 3 4 5", "6 6 3")]
    [InlineData("Ex003", "3 5 2 43 12 3 54 10 23\n76 5 34 2 4 12", "3 76 5 5 2 34 43 2 12 4 3 12 54 10 23")]
    [InlineData("Ex004", "4\nPotatoes\nTomatoes\nOnions\nApples", "1.Apples\n2.Onions\n3.Potatoes\n4.Tomatoes")]
    [InlineData("Ex005", "", "Hello, World!")]
    [InlineData("Ex006", "4 19 2 53 6 43\nAdd 3\nRemove 2\nRemoveAt 1\nInsert 8 3\nend", "4 53 6 8 43 3")]
    [InlineData("Ex007", "2 13 43 876 342 23 543\nContains 100\nContains 543\nPrintEven\nPrintOdd\nGetSum\nFilter >= 43\nFilter < 100\nend", "No such number\nYes\n2 876 342\n13 43 23 543\n1842\n43 876 342 543\n2 13 43 23")]
    [InlineData("Ex007", "1 2\nAdd 3\nend", "1 2 3")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
