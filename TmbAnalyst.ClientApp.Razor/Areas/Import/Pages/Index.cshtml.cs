using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TmbAnalyst.Services.DataContracts.Requests;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.ClientApp.Razor.Areas.Import.Pages;

[Authorize(Roles = "Admin,Developer")]
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

    public async Task<IActionResult> OnPostCsvAsync(CreateWishlistImportRequest request)
    {
        var result = await _importManager.ImportWishlistData(request.ImportString);
        return new JsonResult(result);
    }
}