namespace Tests;

public class MethodsExerciseTests
{
    private const string Module = "008-Exercise-Methods";

    [Theory]
    [InlineData("Ex001", "2\n5\n3", "2")]
    [InlineData("Ex001", "2\n2\n3", "2")]
    [InlineData("Ex001", "-1\n-2\n-3", "-3")]
    [InlineData("Ex002", "SoftUni", "3")]
    [InlineData("Ex002", "Cats", "1")]
    [InlineData("Ex003", "a\nd", "b c")]
    [InlineData("Ex003", "d\na", "b c")]
    [InlineData("Ex004", "logIn", "Password must be between 6 and 10 characters\nPassword must have at least 2 digits")]
    [InlineData("Ex004", "MyPass123", "Password is valid")]
    [InlineData("Ex004", "Pa$s$s", "Password must consist only of letters and digits\nPassword must have at least 2 digits")]
    [InlineData("Ex005", "23\n6\n10", "19")]
    [InlineData("Ex005", "1\n17\n30", "-12")]
    [InlineData("Ex006", "aString", "r")]
    [InlineData("Ex006", "someText", "eT")]
    [InlineData("Ex007", "3", "3 3 3\n3 3 3\n3 3 3")]
    [InlineData("Ex008", "5\n2", "60.00")]
    [InlineData("Ex008", "6\n2", "360.00")]
    [InlineData("Ex008", "2\n5", "0.02")]
    [InlineData("Ex009", "123\n323\n421\n121\nEND", "false\ntrue\nfalse\ntrue")]
    [InlineData("Ex010", "50", "17\n35")]
    [InlineData("Ex010", "100", "17\n35\n53\n71\n79\n97")]
    [InlineData("Ex011", "1 3 5 7 9\nexchange 1\nmax odd\nmin even\nfirst 2 odd\nlast 2 even\nexchange 3\nend", "2\nNo matches\n[5, 7]\n[]\n[3, 5, 7, 9, 1]")]
    [InlineData("Ex011", "1 10 100 1000\nmax even\nfirst 5 odd\nexchange 10\nmin odd\nexchange 0\nmax even\nmin even\nend", "3\nInvalid count\nInvalid index\n0\n2\n0\n[10, 100, 1000, 1]")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
