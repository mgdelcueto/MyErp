#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815c00fb06b247f402c7d05812cde703e820dc5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pListaFacilities_all), @"mvc.1.0.view", @"/Views/TEngine/_pListaFacilities_all.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815c00fb06b247f402c7d05812cde703e820dc5d", @"/Views/TEngine/_pListaFacilities_all.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pListaFacilities_all : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TFacility>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <table class=""table-norm"" border=""1"">
    <div class=""cont-titles"">
    <h2>>Facilities Data</h2>
    </div>
    <tr>
        <th class=""head-text"">Code</th> 
        <th class=""head-text"">Description</th>                
        <th class=""head-text"">Type</th>        
    </tr>
   
");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
     foreach (var c in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
                             Write(c.FaCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
                             Write(c.FaDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
                              Write(c.FaType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
                            Write(Html.ActionLink("Delete", "FacDelete", new { id = c.FaId}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
                            Write(Html.ActionLink("Edit", "FacEdit", new { id = c.FaId ,panel=1,vpanel=1}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    ");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaFacilities_all.cshtml"
Write(Html.ActionLink("Add a New Item", "FacCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TFacility>> Html { get; private set; }
    }
}
#pragma warning restore 1591
