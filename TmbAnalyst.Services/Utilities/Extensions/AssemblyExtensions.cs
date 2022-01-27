using System.IO;
using System.Linq;
using System.Reflection;

namespace TmbAnalyst.Services.Utilities.Extensions;

public static class AssemblyExtensions
{
    public static string ReadResource(this Assembly assembly, string resourceName)
    {
        var names = assembly.GetManifestResourceNames();
        var qualifiedResourceName = names.Single(n => n.Contains(resourceName));
        using var stream = assembly.GetManifestResourceStream(qualifiedResourceName);
        if (stream == null) return null;
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}