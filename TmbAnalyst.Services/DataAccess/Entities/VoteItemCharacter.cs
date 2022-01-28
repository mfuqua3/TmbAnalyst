using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class VoteItemCharacter : IUnique<int>
{
    public int CharacterId { get; set; }
    public int VoteItemId { get; set; }
    public Character Character { get; set; }
    public VoteItem VoteItem { get; set; }
    public int Id { get; set; }
}