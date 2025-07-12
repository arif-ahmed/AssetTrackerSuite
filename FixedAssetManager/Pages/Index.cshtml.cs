using FixedAssetManager.Data;
using FixedAssetManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<AssetListViewModel> AssetList { get; set; }

    [BindProperty(SupportsGet = true)]
    public string SelectedCategory { get; set; }
    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; }
    public List<string> Categories { get; set; }

    public async Task OnGetAsync()
    {
        // For the dropdown
        Categories = await _context.Assets
            .Select(a => a.Category)
            .Distinct()
            .OrderBy(c => c)
            .ToListAsync();

        var assetsQuery = _context.Assets.AsQueryable();

        if (!string.IsNullOrEmpty(SelectedCategory))
            assetsQuery = assetsQuery.Where(a => a.Category == SelectedCategory);

        if (!string.IsNullOrWhiteSpace(SearchTerm))
            assetsQuery = assetsQuery.Where(a => a.AssetName.Contains(SearchTerm));

        var assets = await assetsQuery.ToListAsync();
        AssetList = assets.Select(asset => new AssetListViewModel { Asset = asset }).ToList();
    }
}
