using FixedAssetManager.Data;
using FixedAssetManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _context;

    [BindProperty]
    public Asset Asset { get; set; }

    public CreateModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        // Prepare dropdown or other initial data if needed
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Assets.Add(Asset);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}
