#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a455fe8dc8bd086ab9ca691c080869f826a808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pshowMaterials_parc_com), @"mvc.1.0.view", @"/Views/TEngine/_pshowMaterials_parc_com.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a455fe8dc8bd086ab9ca691c080869f826a808", @"/Views/TEngine/_pshowMaterials_parc_com.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pshowMaterials_parc_com : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"div-edit\">\r\n");
            WriteLiteral("    ");
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
Write(Html.HiddenFor(p => p.MatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-edit\" >\r\n        <tr>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Cancel\" name=\"actionType\"/></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.LabelFor(p => p.MatRefer,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.EditorFor(p => p.MatRefer, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.LabelFor(p => p.MatClass,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.DropDownListFor(p => p.MatClass,
               new SelectList(DataSource.GetMCatlass(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatRefer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.LabelFor(p => p.MatType,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.DropDownListFor(p => p.MatType,
               new SelectList(DataSource.GetMatType(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.LabelFor(p => p.MatDescr,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.EditorFor(p => p.MatDescr, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowMaterials_parc_com.cshtml"
           Write(Html.ValidationMessageFor(p => p.MatDescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </table>\r\n    </div>\r\n");
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
