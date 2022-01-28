using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TmbAnalyst.Services.DataContracts.Requests;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.ClientApp.Razor.Controllers;

[ApiController]
[Route("Admin/[controller]")]
[Authorize(Roles = "Admin,Developer")]
public class VoteController:Controller
{
    private readonly IVoteManager _voteManager;

    public VoteController(IVoteManager voteManager)
    {
        _voteManager = voteManager;
    }
    [HttpPost]
    public async Task<IActionResult> CreateVote(CreateVoteRequest request)
    {
        var voteSummary = await _voteManager.CreateVote(request);
        return Created("", voteSummary);
    }
}