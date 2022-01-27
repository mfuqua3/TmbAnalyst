using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class Item : IUnique<int>, INamed
{
    public int Id { get; set; }
    public int ItemSourceId { get; set; }
    public ItemSource ItemSource { get; set; }
    public string Name { get; set; }
    public List<CharacterItem> CharacterItems { get; set; }
}