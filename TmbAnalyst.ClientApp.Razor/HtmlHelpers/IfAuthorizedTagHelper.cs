using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TmbAnalyst.ClientApp.Razor.HtmlHelpers;

[HtmlTargetElement("If-Authorized")]
public class IfAuthorizedTagHelper : TagHelper
{
    private readonly IAuthorizationService _authorizationService;
    private readonly IHttpContextAccessor _contextAccessor;
    public string Roles { get; set; }

    public IfAuthorizedTagHelper(IAuthorizationService authorizationService, 
        IHttpContextAccessor contextAccessor)
    {
        _authorizationService = authorizationService;
        _contextAccessor = contextAccessor;
    }

    public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var user = _contextAccessor.HttpContext?.User;
        var authorized = false;
        if (user != null)
        {
            var authorizedRoles = Roles.Split(',').ToArray();
            var userRoles = user.FindAll(ClaimTypes.Role).Select(x => x.Value).ToArray();
            if (userRoles.Any(x => authorizedRoles.Contains(x)))
            {
                authorized = true;
            }
        }

        if (!authorized)
        {
            output.Content.SetHtmlContent(string.Empty);
        }
        return Task.CompletedTask;
    }
}