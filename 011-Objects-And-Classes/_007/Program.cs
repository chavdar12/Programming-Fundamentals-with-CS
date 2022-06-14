namespace _007;

internal class Truck
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int Weight { get; set; }

    public override string ToString()
    {
        return $"{Brand}: {Model} - {Weight}kg";
    }
}

internal class Car
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int HorsePower { get; set; }

    public override string ToString()
    {
        return $"{Brand}: {Model} - {HorsePower}hp";
    }
}

internal class Catalog
{
    public List<Car> Cars { get; }

    public List<Truck> Trucks { get; }

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        var catalogObj = new Catalog();

        var input = Console.ReadLine();

        while (input != "end")
        {
            var cmdArg = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

            var type = cmdArg[0];
            var brand = cmdArg[1];
            var model = cmdArg[2];
            var valueHpOrHeight = int.Parse(cmdArg[3]);

            switch (type)
            {
                case "Car":
                {
                    var car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = valueHpOrHeight
                    };
                    catalogObj.Cars.Add(car);
                    break;
                }
                case "Truck":
                {
                    var truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = valueHpOrHeight
                    };
                    catalogObj.Trucks.Add(truck);
                    break;
                }
            }

            input = Console.ReadLine();
        }

        var orderedCars = catalogObj.Cars.OrderBy(cars => cars.Brand).ToList();
        var orderedTrucks = catalogObj.Trucks.OrderBy(trucks => trucks.Brand).ToList();

        if (catalogObj.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            foreach (var item in orderedCars) Console.WriteLine(item.ToString());
        }

        if (catalogObj.Trucks.Count <= 0) return;
        {
            Console.WriteLine("Trucks:");
            foreach (var item in orderedTrucks) Console.WriteLine(item.ToString());
        }
    }
}