#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eabf57f12b873969ce5b0b9563561e9f3267c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_CarCreate), @"mvc.1.0.view", @"/Views/TPerson/CarCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eabf57f12b873969ce5b0b9563561e9f3267c2a", @"/Views/TPerson/CarCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_CarCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPCareer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
  
    Layout = "_LayPer";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("CareerCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table class=""table-edit"" >
        <hr style=""width:100%;text-align:left;margin-left:0"">
        <tr>
            <td>
            <input type=""submit"" value=""Add"" class=""dropbtn"" name=""actionType""/>
            <input type=""submit"" value=""Cancel"" class=""dropbtn"" name=""actionType""/>
            </td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.LabelFor(p => p.CareDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.EditorFor(p => p.CareDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CareDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.LabelFor(p => p.CarePosit,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.EditorFor(p => p.CarePosit, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:125px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CarePosit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.LabelFor(p => p.CareObser,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.EditorFor(p => p.CareObser, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:425px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CareObser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <input type=\"hidden\" name=\"CarePerId\"");
            BeginWriteAttribute("value", " value=\"", 2268, "\"", 2310, 1);
#nullable restore
#line 58 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
WriteAttributeValue("", 2276, ((TPerson)ViewBag.Person).PerId, 2276, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n       </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\CarCreate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPCareer> Html { get; private set; }
    }
}
#pragma warning restore 1591
