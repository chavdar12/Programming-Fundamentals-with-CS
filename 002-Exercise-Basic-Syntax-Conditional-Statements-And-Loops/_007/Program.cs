namespace _007;

internal static class Program
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();
        double receivedMoney = 0;

        while (command != "Start")
        {
            var coins = double.Parse(command);

            if (coins is 0.1 or 0.2 or 0.5 or 1 or 2)
                receivedMoney += coins;
            else
                Console.WriteLine($"Cannot accept {coins}");

            command = Console.ReadLine();
        }

        command = Console.ReadLine();
        while (command != "End")
        {
            switch (command)
            {
                case "Nuts" when receivedMoney >= 2:
                    receivedMoney -= 2;
                    Console.WriteLine("Purchased nuts");
                    break;
                case "Water" when receivedMoney >= 0.7:
                    receivedMoney -= 0.7;
                    Console.WriteLine("Purchased water");
                    break;
                case "Crisps" when receivedMoney >= 1.5:
                    receivedMoney -= 1.5;
                    Console.WriteLine("Purchased crisps");
                    break;
                case "Soda" when receivedMoney >= 0.8:
                    receivedMoney -= 0.8;
                    Console.WriteLine("Purchased soda");
                    break;
                case "Coke" when receivedMoney >= 1:
                    receivedMoney -= 1;
                    Console.WriteLine("Purchased coke");
                    break;
                default:
                {
                    if (command != "Nuts" && command != "Water" && command != "Crisps" && command != "Soda" &&
                        command != "Coke")
                        Console.WriteLine("Invalid product");
                    else
                        Console.WriteLine("Sorry, not enough money");

                    break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Change: {receivedMoney:f2}");
    }
}