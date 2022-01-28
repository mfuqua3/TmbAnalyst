using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.ClientApp.Razor.Areas.Vote.Pages;

public class Current : PageModel
{
    private readonly IVoteManager _voteManager;

    public Current(IVoteManager voteManager)
    {
        _voteManager = voteManager;
    }
    public List<VoteItemModel> VoteItems { get; set; }
    
    public async Task<IActionResult> OnGetAsync()
    {
        var currentVote = await _voteManager.GetCurrentVote();
        VoteItems = await _voteManager.GetVoteItems(currentVote.Id);
        return Page();
    }
}