#pragma checksum "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "922f3765e6a1b2526199ea28da9da7ddfa65f9a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchRankResult), @"mvc.1.0.view", @"/Views/Home/SearchRankResult.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pwd\SearchRankCheck\Views\_ViewImports.cshtml"
using SearchRankCheck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pwd\SearchRankCheck\Views\_ViewImports.cshtml"
using SearchRankCheck.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"922f3765e6a1b2526199ea28da9da7ddfa65f9a9", @"/Views/Home/SearchRankResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5361207d3b432848375193f7e0b787debbe23e41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchRankResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchRankCheck.Models.RankResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
   
    ViewData["Title"] = "SEO result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Summary</h1>\r\n<p>\r\n    site \r\n    <b> ");
#nullable restore
#line 9 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
   Write(Model.TargetSite);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n    appeared on Google at \r\n    <b> ");
#nullable restore
#line 11 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
   Write(String.Join(",", Model.TargetSiteRank.Select(i=>i+1)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    when searching\r\n    <b>");
#nullable restore
#line 13 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
  Write(Model.Keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n</p>\r\n\r\n<p>bookmark this page for easy access</p>\r\n\r\n<h2>Detailed Results</h2>\r\n<ol>\r\n");
#nullable restore
#line 20 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
     foreach (Entry e in Model.AllResults){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li ");
#nullable restore
#line 21 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
             if(e.IsTargetSite){

#line default
#line hidden
#nullable disable
            WriteLiteral("class=\"highlight\"");
#nullable restore
#line 21 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=", 497, "", 509, 1);
#nullable restore
#line 21 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
WriteAttributeValue("", 503, e.Url, 503, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 21 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
                                                                           Write(e.Site);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n");
#nullable restore
#line 22 "C:\Users\pwd\SearchRankCheck\Views\Home\SearchRankResult.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchRankCheck.Models.RankResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
