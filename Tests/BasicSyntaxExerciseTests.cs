namespace Tests;

public class BasicSyntaxExerciseTests
{
    private const string Module = "002-Exercise-Basic-Syntax-Conditional-Statements-And-Loops";

    [Theory]
    [InlineData("Ex001", "1", "baby")]
    [InlineData("Ex001", "14", "teenager")]
    [InlineData("Ex001", "20", "adult")]
    [InlineData("Ex001", "100", "elder")]
    [InlineData("Ex002", "30", "The number is divisible by 10")]
    [InlineData("Ex002", "12", "The number is divisible by 6")]
    [InlineData("Ex002", "15", "The number is divisible by 3")]
    [InlineData("Ex002", "1643", "Not divisible")]
    [InlineData("Ex003", "30\nStudents\nSunday", "Total price: 266.73")]
    [InlineData("Ex003", "40\nRegular\nSaturday", "Total price: 800.00")]
    [InlineData("Ex003", "15\nRegular\nFriday", "Total price: 213.75")]
    [InlineData("Ex003", "110\nBusiness\nFriday", "Total price: 1090.00")]
    [InlineData("Ex004", "5\n10", "5 6 7 8 9 10\nSum: 45")]
    [InlineData("Ex005", "Acer\nlogin\ngo\nlet me in\nrecA", "Incorrect password. Try again.\nIncorrect password. Try again.\nIncorrect password. Try again.\nUser Acer logged in.")]
    [InlineData("Ex005", "sunny\nrainy\ncloudy\nsunny\nnot sunny", "Incorrect password. Try again.\nIncorrect password. Try again.\nIncorrect password. Try again.\nUser sunny blocked!")]
    [InlineData("Ex005", "momo\nomom", "User momo logged in.")]
    [InlineData("Ex006", "145", "yes")]
    [InlineData("Ex006", "123", "no")]
    [InlineData("Ex007", "1\n1\n0.5\n0.6\nStart\nCoke\nSoda\nCrisps\nEnd", "Cannot accept 0.6\nPurchased coke\nPurchased soda\nSorry, not enough money\nChange: 0.70")]
    [InlineData("Ex007", "1\nStart\nNuts\nPizza\nEnd", "Sorry, not enough money\nInvalid product\nChange: 1.00")]
    [InlineData("Ex008", "3", "1\n2 2\n3 3 3")]
    [InlineData("Ex009", "100\n2\n1.0\n2.0\n3.0", "The money is enough - it would cost 13.00lv.")]
    [InlineData("Ex009", "100\n42\n12.0\n4.0\n3.0", "John will need 737.00lv more.")]
    [InlineData("Ex010", "7\n2\n3\n4\n5", "Rage expenses: 16.00 lv.")]
    [InlineData("Ex010", "23\n12.50\n21.50\n40\n200", "Rage expenses: 608.00 lv.")]
    [InlineData("Ex011", "1\n1.53\n30\n8", "The price for the coffee is: $367.20\nTotal: $367.20")]
    [InlineData("Ex011", "2\n4.99\n31\n3\n0.35\n31\n5", "The price for the coffee is: $464.07\nThe price for the coffee is: $54.25\nTotal: $518.32")]
    [InlineData("Ex012", "2\n1\n3", "3\n2\n1")]
    [InlineData("Ex012", "-2\n1\n3", "3\n1\n-2")]
    [InlineData("Ex013", "1643", "three")]
    [InlineData("Ex013", "10", "zero")]
    [InlineData("Ex014", "120\nRoverWatch\nHonored 2\nGame Time", "Bought RoverWatch\nBought Honored 2\nTotal spent: $89.98. Remaining: $30.02")]
    [InlineData("Ex014", "19.99\nReimen origin\nRoverWatch\nZplinter Zell\nGame Time", "Not Found\nToo Expensive\nBought Zplinter Zell\nOut of money!")]
    [InlineData("Ex014", "55.98\nOutFall 4\nCS: OG\nGame Time", "Bought OutFall 4\nBought CS: OG\nOut of money!")]
    [InlineData("Ex015", "Hello", "olleH")]
    [InlineData("Ex016", "5\n44\n33\n555\n555\n666", "hello")]
    [InlineData("Ex016", "3\n2\n0\n2", "a a")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run($"{Module}/{exercise}", input));
}
