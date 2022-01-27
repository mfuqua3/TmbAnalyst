using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class ItemSource : IUnique<int>, INamed, IOrdered
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Item> Items { get; set; }
    public int ItemSourceCategoryId { get; set; }
    public ItemSourceCategory ItemSourceCategory { get; set; }
    public int OrderNumber { get; set; }
}