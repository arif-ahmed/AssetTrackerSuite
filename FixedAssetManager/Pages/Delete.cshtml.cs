using FixedAssetManager.Data;
using FixedAssetManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Asset Asset { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
            return NotFound();

        Asset = await _context.Assets.FirstOrDefaultAsync(a => a.Id == id);

        if (Asset == null)
            return NotFound();

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
            return NotFound();

        Asset = await _context.Assets.FindAsync(id);

        if (Asset != null)
        {
            _context.Assets.Remove(Asset);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("Index");
    }
}
