namespace _006;

internal class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}

internal class Box
{
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PriceForABox { get; set; }

    public override string ToString()
    {
        return $"{SerialNumber}" + "\n" + $"-- {Item.Name} - ${Item.Price:f2}: {ItemQuantity}" + "\n" +
               $"-- ${PriceForABox:f2}";
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        var list = new List<Box>();
        var command = Console.ReadLine();

        while (command != "end")
        {
            var cmdArg = command.Split(' ');
            var serialNumber = cmdArg[0];
            var itemName = cmdArg[1];
            var itemQuantity = int.Parse(cmdArg[2]);
            var itemPrice = decimal.Parse(cmdArg[3]);

            var item = new Item()
            {
                Name = itemName,
                Price = itemPrice
            };
            var box = new Box()
            {
                SerialNumber = serialNumber,
                ItemQuantity = itemQuantity,
                PriceForABox = itemQuantity * itemPrice,
                Item = item
            };

            list.Add(box);

            command = Console.ReadLine();
        }

        var orderedList = list.OrderByDescending(b => b.PriceForABox).ToList();

        foreach (var item in orderedList) Console.WriteLine(item.ToString());
    }
}