namespace TmbAnalyst.Services.DataContracts.Interfaces;

public interface IEnumTable : INamed, IUnique<int>
{
    string Description { get; set; }
}