using System;

namespace TmbAnalyst.Services.DataContracts.Interfaces;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }

    public DateTime? Deleted { get; set; }
}