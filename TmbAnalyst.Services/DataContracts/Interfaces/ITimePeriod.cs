using System;

namespace TmbAnalyst.Services.DataContracts.Interfaces;

public interface ITimePeriod
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
}