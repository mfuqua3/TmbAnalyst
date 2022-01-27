using System;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class CharacterItem : IUnique<int>, INamed, IOrdered
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime? Date { get; set; }
    public int OrderNumber { get; set; }
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public Character Character { get; set; }
}