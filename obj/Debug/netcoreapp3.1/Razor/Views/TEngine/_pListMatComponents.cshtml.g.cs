#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52dbe88185078839575a0bf10d677598d0d4e1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pListMatComponents), @"mvc.1.0.view", @"/Views/TEngine/_pListMatComponents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52dbe88185078839575a0bf10d677598d0d4e1a1", @"/Views/TEngine/_pListMatComponents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pListMatComponents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VTMComponent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <table class=""table-norm"" border=""1"">
    <div class=""cont-titles"">
    </div>
    <tr>
        <th class=""head-text"">Component</th> 
        <th class=""head-text"">Description</th>                
        <th class=""head-text"">Ref Qty</th>        
        <th class=""head-text"">Ref UM</th>        
        <th class=""head-text"">Comp Qty</th>        
        <th class=""head-text"">Comp UM</th>        
    </tr>
   
");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
     foreach (var c in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                             Write(c.CoComRe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                             Write(c.CoComDes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                              Write(c.CoRefQt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                              Write(c.CoRefUM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                              Write(c.CoComQt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                              Write(c.CoComUM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                            Write(Html.ActionLink("Delete", "CMatDelete", new { id = c.CoCoId}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
                            Write(Html.ActionLink("Edit", "CMatEdit", new { id = c.CoCoId ,MId= c.CoRefId,panel=4}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListMatComponents.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VTMComponent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
