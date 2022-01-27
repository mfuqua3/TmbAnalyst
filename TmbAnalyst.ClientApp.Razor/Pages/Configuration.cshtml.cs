using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.ClientApp.Razor.Pages;

public class Configuration : PageModel
{
    private readonly IPreVoteManager _preVoteManager;

    public Configuration(IPreVoteManager preVoteManager)
    {
        _preVoteManager = preVoteManager;
    }
    public async Task<IActionResult> OnGetAsync()
    {
        var csvBytes = await _preVoteManager.GetPreVoteCsv();
        var dateString = DateTime.Now.ToString("YYYYMMDD");
        return File(csvBytes, "text/csv", $"PreVote{dateString}.csv");
    }
}