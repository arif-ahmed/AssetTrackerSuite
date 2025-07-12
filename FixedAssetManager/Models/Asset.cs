using System.ComponentModel.DataAnnotations;

namespace FixedAssetManager.Models;
public class Asset
{
    public int Id { get; set; }
    [Required]
    public string AssetName { get; set; } = default!;
    [Required]
    public string Category { get; set; } = default!;
    [Required]
    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; }
    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal PurchaseValue { get; set; }
    [Required]
    [Range(1, int.MaxValue)]
    public int UsefulLifeYears { get; set; }
}
