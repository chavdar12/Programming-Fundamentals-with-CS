namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var legendary = new Dictionary<string, int>()
        {
            {"shards", 0},
            {"motes", 0},
            {"fragments", 0}
        };

        var junk = new Dictionary<string, int>();

        var itemObtained = string.Empty;

        var items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();


        while (string.IsNullOrEmpty(itemObtained))
        {
            for (var i = 1; i < items.Length; i += 2)
            {
                if (legendary.ContainsKey(items[i].ToLower()))
                {
                    legendary[items[i].ToLower()] += int.Parse(items[i - 1]);
                    if (legendary[items[i].ToLower()] < 250) continue;
                    switch (items[i].ToLower())
                    {
                        case "shards":
                            Console.WriteLine("Shadowmourne obtained!");
                            break;
                        case "fragments":
                            Console.WriteLine("Valanyr obtained!");
                            break;
                        case "motes":
                            Console.WriteLine("Dragonwrath obtained!");
                            break;
                    }

                    legendary[items[i].ToLower()] -= 250;

                    foreach (var item in legendary)
                    {
                        var keyMaterial = item.Key;
                        var qty = item.Value;
                        Console.WriteLine($"{keyMaterial}: {qty}");
                    }

                    foreach (var item in junk) Console.WriteLine($"{item.Key}: {item.Value}");

                    return;
                }

                if (!junk.ContainsKey(items[i].ToLower())) junk[items[i].ToLower()] = 0;

                junk[items[i].ToLower()] += int.Parse(items[i - 1]);
            }

            items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}