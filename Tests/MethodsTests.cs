namespace Tests;

public class MethodsTests
{
    [Fact]
    public void Ex001_PrintsHelloWorld() =>
        Assert.Equal("Hello, World!", ProgramRunner.Run("007-Methods/Ex001"));
}
