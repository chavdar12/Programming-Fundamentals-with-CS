namespace Tests;

public class DataTypesExerciseTests
{
    private const string Module = "004-Exercise-Data-Types-And-Variables";

    [Theory]
    [InlineData("Ex001", "10\n20\n3\n3", "30")]
    [InlineData("Ex001", "15\n14\n2\n3", "42")]
    [InlineData("Ex002", "245678", "32")]
    [InlineData("Ex003", "17\n3", "6")]
    [InlineData("Ex003", "4\n12", "1")]
    [InlineData("Ex003", "6\n3", "2")]
    [InlineData("Ex004", "5\nA\nb\nC\nd\nE", "The sum equals: 399")]
    [InlineData("Ex005", "60\n65", "< = > ? @ A")]
    [InlineData("Ex006", "2", "aaa\naab\naba\nabb\nbaa\nbab\nbba\nbbb")]
    [InlineData("Ex007", "5\n20\n100\n100\n100\n20", "Insufficient capacity!\n240")]
    [InlineData("Ex008", "3\nSmall Keg\n10.3\n10\nNormal Keg\n29.90\n25\nBig Keg\n50.2\n50", "Big Keg")]
    [InlineData("Ex009", "111", "2\n134")]
    [InlineData("Ex009", "50", "0\n0")]
    [InlineData("Ex010", "5\n1\n4", "0\n5")]
    [InlineData("Ex010", "10\n5\n2", "2\n1")]
    [InlineData("Ex010", "3\n5\n1", "3\n0")]
    [InlineData("Ex011", "2\n10\n2\n3\n5\n5\n5", "10 : 2 = 125 (3)")]
    [InlineData("Ex012", "5\n2.5\ntrue\nabc\na\nEND", "5 is integer type\n2.5 is floating point type\ntrue is boolean type\nabc is string type\na is character type")]
    [InlineData("Ex013", "2\n1000 2000\n-15 -1", "2\n1")]
    [InlineData("Ex014", "5.3\n6.01", "False")]
    [InlineData("Ex014", "5.00000001\n5.00000003", "True")]
    [InlineData("Ex015", "5", "2 -> true\n3 -> true\n4 -> false\n5 -> true")]
    [InlineData("Ex016", "3\n3\nP\nl\nf", "Soi")]
    [InlineData("Ex017", "3\n(\n8\n)", "BALANCED")]
    [InlineData("Ex017", "4\n(\n(\n)\n)", "UNBALANCED")]
    [InlineData("Ex017", "2\n)\n(", "UNBALANCED")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
