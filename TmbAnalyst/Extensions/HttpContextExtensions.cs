using System;
using Microsoft.AspNetCore.Http;

namespace TmbAnalyst.Extensions;

public static class HttpContextExtensions
{
    public static bool IsApiRequest(this HttpContext httpContext)
    {
        return httpContext.Request.Path.Value?.Contains("api", StringComparison.OrdinalIgnoreCase) ?? false;
    }
}