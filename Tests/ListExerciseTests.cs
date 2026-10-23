namespace Tests;

public class ListExerciseTests
{
    private const string Module = "010-Exercise-List";

    [Theory]
    [InlineData("Ex001", "32 54 21 12 4 0 23\n75\nAdd 10\nAdd 0\n30\n10\n75\nend", "72 54 21 12 4 75 23 10 0")]
    [InlineData("Ex002", "1 2 3 4 5 5 5 6\nDelete 5\nInsert 10 1\nDelete 5\nend", "1 10 2 3 4 6")]
    [InlineData("Ex003", "4\nAllie is going!\nGeorge is going!\nJohn is not going!\nGeorge is not going!", "John is not in the list!\nAllie")]
    [InlineData("Ex003", "2\nTom is going!\nTom is going!", "Tom is already in the list!\nTom")]
    [InlineData("Ex004", "1 23 29 18 43 21 20\nAdd 5\nRemove 5\nShift left 3\nShift left 1\nEnd", "43 20 5 1 23 29 18")]
    [InlineData("Ex004", "5 12 42 95 32 1\nInsert 3 0\nRemove 10\nInsert 8 6\nShift right 1\nShift left 2\nEnd", "Invalid index\n5 12 42 95 32 8 1 3")]
    [InlineData("Ex005", "1 2 2 4 2 2 2 9\n4 2", "12")]
    [InlineData("Ex006", "20 30 40 50\n10 20 30 40", "First player wins! Sum: 240")]
    [InlineData("Ex006", "10 20 30 40 50\n50 40 30 30 10", "Second player wins! Sum: 50")]
    [InlineData("Ex007", "1 2 3 |4 5 6 |  7  8", "7 8 4 5 6 1 2 3")]
    [InlineData("Ex008", "Ivo Johny Tony Bony Mony\nmerge 0 3\nmerge 3 4\nmerge 0 3\n3:1", "IvoJohnyTonyBonyMony")]
    [InlineData("Ex008", "abcd efgh ijkl mnop qrst uvwx yz\nmerge 4 10\ndivide 4 5\n3:1", "abcd efgh ijkl mnop qr st uv wx yz")]
    [InlineData("Ex008", "abcdefgh\ndivide 0 3\nmerge -5 100\n3:1", "abcdefgh")]
    [InlineData("Ex008", "abcdefgh\ndivide 0 3\n3:1", "ab cd efgh")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
