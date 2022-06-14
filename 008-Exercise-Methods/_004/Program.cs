namespace _004;

internal static class Program
{
    private static void Main(string[] args)
    {
        var password = Console.ReadLine();

        var isLengthValid = LengthOfPassword(password);
        var isThereLettersAndDigit = PasswordContainsLettersAndDigits(password);
        var isThereAtLeastTwoDigits = PasswordContainsAtLeastTwoDigits(password);

        if (isLengthValid && isThereLettersAndDigit && isThereAtLeastTwoDigits) Console.WriteLine("Password is valid");
    }

    private static bool LengthOfPassword(string password)
    {
        if (password.Length is >= 6 and <= 10) return true;

        Console.WriteLine("Password must be between 6 and 10 characters");
        return false;
    }

    private static bool PasswordContainsLettersAndDigits(string password)
    {
        var counter = password.Count(currChar =>
            !(currChar >= 48 && currChar <= 57 || currChar >= 65 && currChar <= 90 ||
              currChar >= 97 && currChar <= 122));

        if (counter <= 0) return true;
        Console.WriteLine("Password must consist only of letters and digits");
        return false;
    }

    private static bool PasswordContainsAtLeastTwoDigits(string password)
    {
        var counter = password.Count(currChar => currChar >= 48 && currChar <= 57);

        if (counter >= 2) return true;

        Console.WriteLine("Password must have at least 2 digits");
        return false;
    }
}