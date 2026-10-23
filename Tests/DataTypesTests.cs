namespace Tests;

public class DataTypesTests
{
    private const string Module = "003-Data-Types-And-Variables";

    private const string SpecialNumbers15 =
        "1 -> False\n2 -> False\n3 -> False\n4 -> False\n5 -> True\n6 -> False\n7 -> True\n8 -> False\n" +
        "9 -> False\n10 -> False\n11 -> False\n12 -> False\n13 -> False\n14 -> True\n15 -> False";

    [Theory]
    [InlineData("Ex001", "1852", "1.85")]
    [InlineData("Ex001", "798", "0.80")]
    [InlineData("Ex002", "80", "104.800")]
    [InlineData("Ex003", "3\n10\n20\n30", "60")]
    [InlineData("Ex003", "2\n1.5\n2.25", "3.75")]
    [InlineData("Ex004", "1", "1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes")]
    [InlineData("Ex005", "15", SpecialNumbers15)]
    [InlineData("Ex006", "A\nB\nC", "C B A")]
    [InlineData("Ex007", "John\nSmith\n->", "John->Smith")]
    [InlineData("Ex008", "Sofia\n1286383\n492", "Town Sofia has population of 1286383 and area 492 square km.")]
    [InlineData("Ex009", "a\nb\nc", "abc")]
    [InlineData("Ex010", "L", "upper-case")]
    [InlineData("Ex010", "f", "lower-case")]
    [InlineData("Ex011", "2\n3\n5", "Length: Width: Height: Pyramid Volume: 10.00")]
    [InlineData("Ex012", "15", SpecialNumbers15)]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
