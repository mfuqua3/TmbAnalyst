using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class ItemSourceCategory : IUnique<int>, INamed
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ItemSource> ItemSources { get; set; }
}