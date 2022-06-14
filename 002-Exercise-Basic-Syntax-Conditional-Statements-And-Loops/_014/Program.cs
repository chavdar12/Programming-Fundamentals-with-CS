namespace _014;

internal static class Program
{
    private static void Main(string[] args)
    {
        var budget = double.Parse(Console.ReadLine());
        var currentBalance = budget;
        var command = Console.ReadLine();

        while (command != "Game Time")
        {
            switch (command)
            {
                case "OutFall 4" when currentBalance < 39.99:
                    Console.WriteLine("Too Expensive");
                    break;
                case "OutFall 4":
                    currentBalance -= 39.99;
                    Console.WriteLine("Bought OutFall 4");
                    break;
                case "CS: OG" when currentBalance < 15.99:
                    Console.WriteLine("Too Expensive");
                    break;
                case "CS: OG":
                    currentBalance -= 15.99;
                    Console.WriteLine("Bought CS: OG");
                    break;
                case "Zplinter Zell" when currentBalance < 19.99:
                    Console.WriteLine("Too Expensive");
                    break;
                case "Zplinter Zell":
                    currentBalance -= 19.99;
                    Console.WriteLine("Bought Zplinter Zell");
                    break;
                case "Honored 2" when currentBalance < 59.99:
                    Console.WriteLine("Too Expensive");
                    break;
                case "Honored 2":
                    currentBalance -= 59.99;
                    Console.WriteLine("Bought Honored 2");
                    break;
                case "RoverWatch" when currentBalance < 29.99:
                    Console.WriteLine("Too Expensive");
                    break;
                case "RoverWatch":
                    currentBalance -= 29.99;
                    Console.WriteLine("Bought RoverWatch");
                    break;
                case "RoverWatch Origins Edition" when currentBalance < 39.99:
                    Console.WriteLine("Too Expensive");
                    break;
                case "RoverWatch Origins Edition":
                    currentBalance -= 39.99;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                    break;
                default:
                    Console.WriteLine("Not Found");
                    break;
            }

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Total spent: ${budget - currentBalance:f2}. Remaining: ${currentBalance:f2}");
    }
}