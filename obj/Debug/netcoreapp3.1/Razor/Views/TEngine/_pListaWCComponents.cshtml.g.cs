#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a548da90159864a92e96e13436d519595e28df9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pListaWCComponents), @"mvc.1.0.view", @"/Views/TEngine/_pListaWCComponents.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/_ViewImports.cshtml"
using MyErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/_ViewImports.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a548da90159864a92e96e13436d519595e28df9", @"/Views/TEngine/_pListaWCComponents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pListaWCComponents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TWccomponent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <tr>\n        <th class=\"head-text\">Code</th> \n        <th class=\"head-text\">Description</th>                \n        <th class=\"head-text\">Type</th>        \n    </tr>\n   \n");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml"
     foreach (var c in ViewBag.ListPodAs) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td class =\"col-text\">");
#nullable restore
#line 10 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml"
                             Write(c.WcoCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \n            <td class =\"big-text\">");
#nullable restore
#line 11 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml"
                             Write(c.WcoDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class =\"norm-text\">");
#nullable restore
#line 12 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml"
                              Write(c.WcoType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"col-text\">");
#nullable restore
#line 13 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml"
                            Write(Html.ActionLink("Remove", "WCeEdit", new { id= c.WcoWcid, wrem = c.WcoId, wass=0}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 15 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pListaWCComponents.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TWccomponent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
