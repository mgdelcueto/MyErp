#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68be1e7d1d9e7798f69a9db2b98208285e130dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pListaWCComponents_all), @"mvc.1.0.view", @"/Views/TEngine/_pListaWCComponents_all.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68be1e7d1d9e7798f69a9db2b98208285e130dc", @"/Views/TEngine/_pListaWCComponents_all.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pListaWCComponents_all : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TWccomponent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
     using (Html.BeginForm("Index","TEngine",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n            <td>\r\n                <input type=\"hidden\" name=\"panel\" value=\"3\"/>\r\n            </td>\r\n\r\n            <td class=\"medium-text\">Work Center</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
           Write(Html.DropDownList("WcdId", (SelectList)ViewBag.ddlReferVD, new { @class ="medium-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n    </table>\r\n");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <table class=""table-norm"" border=""1"">
    <div class=""cont-titles"">
    <h2>>Work Centers-Components Data</h2>
    </div>
    <tr>
        <th class=""head-text"">Code</th> 
        <th class=""head-text"">Description</th>                
        <th class=""head-text"">Type</th>        
    </tr>
   
");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
     foreach (var c in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
                             Write(c.WcoCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
                             Write(c.WcoDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
                              Write(c.WcoType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
                            Write(Html.ActionLink("Delete", "WCoDelete", new { id = c.WcoId}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
                            Write(Html.ActionLink("Edit", "WCoEdit", new { id = c.WcoId ,panel=2}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaWCComponents_all.cshtml"
Write(Html.ActionLink("Add a New Item", "WCoCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
