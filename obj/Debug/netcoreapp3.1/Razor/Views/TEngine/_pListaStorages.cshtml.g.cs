#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585af6dc1bfcf8fb08609e994e5d9966e438c62f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pListaStorages), @"mvc.1.0.view", @"/Views/TEngine/_pListaStorages.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\_ViewImports.cshtml"
using MyErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\_ViewImports.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585af6dc1bfcf8fb08609e994e5d9966e438c62f", @"/Views/TEngine/_pListaStorages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pListaStorages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TLocation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <tr>\r\n        <th class=\"head-text\">Code</th> \r\n        <th class=\"head-text\">Description</th>                \r\n        <th class=\"head-text\">Type</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml"
     foreach (var c in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml"
                             Write(c.LocCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml"
                             Write(c.LocDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml"
                              Write(c.LocType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml"
                            Write(Html.ActionLink("Remove", "FacEdit", new { id= c.LocFaId, wrel = c.LocId, wasl=0,vpanel=2}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TLocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591