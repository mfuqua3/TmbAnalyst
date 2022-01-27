using System;

namespace TmbAnalyst.Services.DataContracts.Interfaces;

public interface IUnique<T> where T : IEquatable<T>
{
    public T Id { get; set; }
}