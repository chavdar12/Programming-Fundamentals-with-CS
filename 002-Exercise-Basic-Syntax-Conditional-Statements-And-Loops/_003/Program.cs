namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var numOfPeople = int.Parse(Console.ReadLine());
        var typeOfGroup = Console.ReadLine();
        var dayOfTheWeek = Console.ReadLine();
        double price = 0;

        switch (typeOfGroup)
        {
            case "Students" when dayOfTheWeek == "Friday":
                price = 8.45;
                break;
            case "Students" when dayOfTheWeek == "Saturday":
                price = 9.80;
                break;
            case "Students":
            {
                if (dayOfTheWeek == "Sunday") price = 10.46;

                break;
            }
            case "Business" when dayOfTheWeek == "Friday":
                price = 10.90;
                break;
            case "Business" when dayOfTheWeek == "Saturday":
                price = 15.60;
                break;
            case "Business":
            {
                if (dayOfTheWeek == "Sunday") price = 16;

                break;
            }
            case "Regular" when dayOfTheWeek == "Friday":
                price = 15;
                break;
            case "Regular" when dayOfTheWeek == "Saturday":
                price = 20;
                break;
            case "Regular":
            {
                if (dayOfTheWeek == "Sunday") price = 22.50;

                break;
            }
        }

        var total = numOfPeople * price;

        if (numOfPeople >= 30 && typeOfGroup == "Students") total -= 0.15 * total;

        switch (numOfPeople)
        {
            case >= 100 when typeOfGroup == "Business":
                total -= 10 * price;
                break;
            case >= 10 and <= 20 when typeOfGroup == "Regular":
                total -= 0.05 * total;
                break;
        }

        Console.WriteLine($"Total price: {total:f2}");
    }
}