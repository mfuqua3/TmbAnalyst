using System.ComponentModel;

namespace TmbAnalyst.Services.Utilities;

public class Enums
{
    public enum Role
    {
        [Description("Base User")]
        User = 1,
        [Description("Loot Council Member")]
        Council = 2,
        [Description("Admin User")]
        Admin = 3,
        [Description("Application Developer/SuperUser")]
        Developer
    }
}