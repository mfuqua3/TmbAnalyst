﻿using System.Threading.Tasks;

namespace TmbAnalyst.Services.Manager.Contracts;

public interface IImportManager
{
    Task ImportWishlistData(string rawImport);
}