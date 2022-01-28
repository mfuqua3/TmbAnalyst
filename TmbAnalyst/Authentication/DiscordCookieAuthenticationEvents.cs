using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.Authentication;

public class DiscordCookieAuthenticationEvents : CookieAuthenticationEvents
{
    public override async Task SigningIn(CookieSigningInContext context)
    {
        if (context.Principal == null) return;
        var idClaim = context.Principal.FindFirst(ClaimTypes.NameIdentifier);
        var nameClaim = context.Principal.FindFirst(ClaimTypes.Name);
        if (nameClaim == null)
        {
            throw new ArgumentNullException(nameof(nameClaim));
        }
        if (!ulong.TryParse(idClaim?.Value, out var userId))
        {
            return;
        }
        var userManager = context.HttpContext.RequestServices.GetRequiredService<IUserManager>();
        var roles = await userManager.GetUserRoles(userId);
        var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x.Name));
        var identity = new ClaimsIdentity(new[]
        {
            idClaim,
            nameClaim
        }, CookieAuthenticationDefaults.AuthenticationScheme);
        identity.AddClaims(roleClaims);
        context.Principal.AddIdentities(new []{identity});
    }
}