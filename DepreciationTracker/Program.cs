using DepreciationTracker;

Console.WriteLine("How many assets do you want to input?");
int count = int.Parse(Console.ReadLine() ?? "0");
var assets = new List<Asset>();

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"\nAsset #{i + 1}");

    Console.Write("Asset Name: ");
    string name = Console.ReadLine();

    decimal value = ReadDecimal("Purchase Value: ");
    DateTime date = ReadDate("Purchase Date (yyyy-MM-dd): ");
    int life = ReadInt("Useful Life (years): ");

    assets.Add(new Asset
    {
        Name = name,
        PurchaseValue = value,
        PurchaseDate = date,
        UsefulLifeYears = life
    });
}

Console.WriteLine("\nResults:");
Console.WriteLine("Name\tYearlyDepreciation\tTotalDepreciation\tNetBookValue");
foreach (var a in assets)
{
    Console.WriteLine($"{a.Name}\t{a.YearlyDepreciation}\t{a.TotalDepreciation}\t{a.NetBookValue}");
}

static decimal ReadDecimal(string prompt)
{
    decimal val;
    while (true)
    {
        Console.Write(prompt);
        if (decimal.TryParse(Console.ReadLine(), out val) && val > 0)
            break;
        Console.WriteLine("Invalid decimal value. Try again.");
    }
    return val;
}

static int ReadInt(string prompt)
{
    int val;
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out val) && val > 0)
            break;
        Console.WriteLine("Invalid integer value. Try again.");
    }
    return val;
}

static DateTime ReadDate(string prompt)
{
    DateTime val;
    while (true)
    {
        Console.Write(prompt);
        if (DateTime.TryParse(Console.ReadLine(), out val))
            break;
        Console.WriteLine("Invalid date. Format should be yyyy-MM-dd.");
    }
    return val;
}