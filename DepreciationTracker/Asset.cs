namespace DepreciationTracker;

public class Asset
{
    public string Name { get; set; }
    public decimal PurchaseValue { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int UsefulLifeYears { get; set; }

    public decimal YearlyDepreciation => Math.Round(PurchaseValue / UsefulLifeYears, 2);
    public double YearsPassed => (DateTime.Now - PurchaseDate).TotalDays / 365.25;
    public decimal TotalDepreciation => Math.Round(YearlyDepreciation * (decimal)YearsPassed, 2);
    public decimal NetBookValue => Math.Max(PurchaseValue - TotalDepreciation, 0);
}
