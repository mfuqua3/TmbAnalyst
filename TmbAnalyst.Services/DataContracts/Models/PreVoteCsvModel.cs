using System.Collections.Generic;
using CsvHelper.Configuration.Attributes;

namespace TmbAnalyst.Services.DataContracts.Models;

public class PreVoteCsvModel
{
    public string Raid { get; set; }
    public string Boss { get; set; }
    public string Item { get; set; }
    [Name("Characters")] public string CommaDelimitedUsers => string.Join(',', Users);
    [Ignore]
    public List<string> Users { get; set; }
}