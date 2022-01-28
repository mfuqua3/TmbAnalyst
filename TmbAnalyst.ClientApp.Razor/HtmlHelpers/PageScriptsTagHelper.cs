using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;
using TmbAnalyst.Services.Utilities.Configuration;

namespace TmbAnalyst.ClientApp.Razor.HtmlHelpers;

[HtmlTargetElement("Page-Scripts")]
[OutputElementHint("script")]
public class PageScriptsTagHelper : TagHelper
{
    private readonly bool _useDevServer;
    [HtmlAttributeNotBound] [ViewContext] public ViewContext ViewContext { get; set; }
    public string Src { get; set; }
    public PageScriptsTagHelper(IOptions<DevelopmentOptions> options)
    {
        _useDevServer = options.Value.UseWebpackDevServer;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var directory = _useDevServer ? "http://localhost:9000" : "/dist";
        var name = Src;
        if (string.IsNullOrWhiteSpace(name))
        {
            name = ViewContext.ViewData.ContainsKey("Script") ? 
                ViewContext.ViewData["Script"] + "Page" :
                ViewContext.RouteData.Values["page"] + "Page";
        }
        if (!name.StartsWith('/'))
            name = '/' + name;
        var scriptFile = $"{directory}{name}.js";
        output.TagName = "script";
        output.Attributes.SetAttribute("src", scriptFile);
    }
}