#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eb72a1bc7334aa99a6ceabfd5e40f7a6d7c3270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pshowTrucks), @"mvc.1.0.view", @"/Views/TEngine/_pshowTrucks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb72a1bc7334aa99a6ceabfd5e40f7a6d7c3270", @"/Views/TEngine/_pshowTrucks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pshowTrucks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCTruck>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.LabelFor(p => p.TruckCustId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.DropDownListFor(p => p.TruckCustId,(SelectList)ViewBag.ddlCustoX,"",new { @class = "norm-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.LabelFor(p => p.TruckPlantId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.DropDownListFor(p => p.TruckPlantId,(SelectList)ViewBag.ddlPlantX,"",new { @class = "norm-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.LabelFor(p => p.TruckCode,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.EditorFor(p => p.TruckCode, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.LabelFor(p => p.TruckCrDate,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.EditorFor(p => p.TruckCrDate, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.ValidationMessageFor(p => p.TruckCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.ValidationMessageFor(p => p.TruckCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.LabelFor(p => p.TruckDeno,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.EditorFor(p => p.TruckDeno, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowTrucks.cshtml"
           Write(Html.ValidationMessageFor(p => p.TruckDeno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCTruck> Html { get; private set; }
    }
}
#pragma warning restore 1591
