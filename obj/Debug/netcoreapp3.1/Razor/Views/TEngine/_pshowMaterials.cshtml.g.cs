#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f92f6b0e2016faa4923d265ed4b88b1f52a9eb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pshowMaterials), @"mvc.1.0.view", @"/Views/TEngine/_pshowMaterials.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f92f6b0e2016faa4923d265ed4b88b1f52a9eb9", @"/Views/TEngine/_pshowMaterials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pshowMaterials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 3 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatRefer,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 4 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatRefer, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 5 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatClass,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"norm-text\">\n");
            WriteLiteral("                ");
#nullable restore
#line 10 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.DropDownListFor(p => p.MatClass,
               new SelectList(DataSource.GetMCatlass(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 16 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatRefer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 18 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 21 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatType,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"norm-text\">\n");
            WriteLiteral("                ");
#nullable restore
#line 26 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.DropDownListFor(p => p.MatType,
               new SelectList(DataSource.GetMatType(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>");
#nullable restore
#line 29 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatDescr,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 30 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatDescr, new { htmlAttributes = new { @class = "norm-text", @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>        \n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 34 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 36 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatDescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 39 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatUnMed,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"norm-text\">\n");
            WriteLiteral("                ");
#nullable restore
#line 44 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.DropDownListFor(p => p.MatUnMed,
               new SelectList(DataSource.GetMatUnits(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 50 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatUnMed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 53 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatDim1,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 54 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatDim1, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 55 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatDim2,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 56 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatDim2, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 60 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatDim1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 62 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatDim2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 65 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatDim3,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 66 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatDim3, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 67 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatWeight,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 68 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatWeight, new { htmlAttributes = new { @class = "norm-num", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>        \n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 72 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatDim3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 74 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 77 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatStatus,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 78 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatStatus, new { htmlAttributes = new { @class = "norm-text", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 79 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.LabelFor(p => p.MatStDate,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 80 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.EditorFor(p => p.MatStDate, new { htmlAttributes = new { @class = "norm-text" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>        \n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 84 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 86 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TEngine/_pshowMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TMaterial> Html { get; private set; }
    }
}
#pragma warning restore 1591
