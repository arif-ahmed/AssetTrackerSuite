using FixedAssetManager.Models;

namespace FixedAssetManager.ViewModels;
public class AssetListViewModel
{
    public Asset Asset { get; set; }
    public decimal YearlyDepreciation => Math.Round(Asset.PurchaseValue / Asset.UsefulLifeYears, 2);
    public double YearsPassed => (DateTime.Now - Asset.PurchaseDate).TotalDays / 365.25;
    public decimal TotalDepreciation => Math.Round(YearlyDepreciation * (decimal)YearsPassed, 2);
    public decimal NetBookValue => Math.Max(Asset.PurchaseValue - TotalDepreciation, 0);
}
