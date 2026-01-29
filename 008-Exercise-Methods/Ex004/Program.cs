namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var password = Console.ReadLine();

        var isLengthValid = LengthOfPassword(password);
        var isThereLettersAndDigit = PasswordContainsLettersAndDigits(password);
        var isThereAtLeastTwoDigits = PasswordContainsAtLeastTwoDigits(password);

        if (isLengthValid && isThereLettersAndDigit && isThereAtLeastTwoDigits) Console.WriteLine("Password is valid");
    }

    private static bool PasswordContainsAtLeastTwoDigits(string? password)
    {
        if (password.Count(char.IsDigit) >= 2) return true;
        Console.WriteLine("Password must have at least 2 digits");
        return false;
    }

    private static bool PasswordContainsLettersAndDigits(string? password)
    {
        if (password.Any(char.IsLetter) && password.Any(char.IsDigit)) return true;
        Console.WriteLine("Password must consist only of letters and digits");
        return false;
    }

    private static bool LengthOfPassword(string? password)
    {
        if (password.Length >= 6 && password.Length <= 10) return true;
        Console.WriteLine("Password must be between 6 and 10 characters");
        return false;
    }
}