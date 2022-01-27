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

    public PageScriptsTagHelper(IOptions<DevelopmentOptions> options)
    {
        _useDevServer = options.Value.UseWebpackDevServer;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var directory = _useDevServer ? "http://localhost:9000" : "/dist";
        var currentPage = ViewContext.RouteData.Values["page"].ToString();
        output.TagName = "script";
        output.Attributes.SetAttribute("src", $"{directory}{currentPage}Page.js");
    }
}