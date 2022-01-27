using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.ClientApp.Razor.Pages;

public class Index : PageModel
{
    private readonly IImportManager _importManager;

    public Index(IImportManager importManager)
    {
        _importManager = importManager;
    }
    [BindProperty]
    [DisplayName("TMB CSV Import")]
    public string RawImportString { get; set; }
    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _importManager.ImportWishlistData(RawImportString);
        return Page();
    }
}