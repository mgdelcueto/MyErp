#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19722daaedc6fddef711a52139df845af97d2cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_PoEdit_copy), @"mvc.1.0.view", @"/Views/TSuplier/PoEdit copy.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19722daaedc6fddef711a52139df845af97d2cbe", @"/Views/TSuplier/PoEdit copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_PoEdit_copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSPorder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EditPORecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(Html.HiddenFor(p => p.Spoid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(Html.HiddenFor(p => p.SposupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table-edit"">
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.Spopo,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.EditorFor(p => p.Spopo, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.ValidationMessageFor(p => p.Spopo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.Spodate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.EditorFor(p => p.Spodate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.ValidationMessageFor(p => p.Spodate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.SporeferEx,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.EditorFor(p => p.SporeferEx, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.ValidationMessageFor(p => p.SporeferEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.SpocprodId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.DropDownListFor(p => p.SpocprodId,(SelectList)ViewBag.ddlReferVD,"",new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
               Write(Html.ValidationMessageFor(p => p.SpocprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.Spoprice,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.EditorFor(p => p.Spoprice, new { htmlAttributes = new { @class = "norm-tb-num", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.ValidationMessageFor(p => p.Spoprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>        \r\n            <td>");
#nullable restore
#line 54 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.Spocurcy,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.DropDownListFor(p => p.Spocurcy,
               new SelectList(DataSource.GetCurrency(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.LabelFor(p => p.Spostatus,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.EditorFor(p => p.Spostatus, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
           Write(Html.ValidationMessageFor(p => p.Spostatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TSPorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
