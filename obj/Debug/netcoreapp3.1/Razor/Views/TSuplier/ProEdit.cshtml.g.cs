#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08cd1c9e169d92a17bcdfdb6a191c9457f2f57b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_ProEdit), @"mvc.1.0.view", @"/Views/TSuplier/ProEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08cd1c9e169d92a17bcdfdb6a191c9457f2f57b4", @"/Views/TSuplier/ProEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_ProEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
  
    Layout = "_LaySup";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EditProdRecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
Write(Html.HiddenFor(p => p.ProdId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
Write(Html.HiddenFor(p => p.ProdSupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table-norm"" border =""1"">
        <hr style=""width:100%;text-align:left;margin-left:0"">
         <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>

        </tr>
        <tr>
            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdRefer,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdRefer, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:220px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdRefer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdDescr,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdDescr, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdDescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdCrDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdCrDate, new { htmlAttributes = new { @class = "norm-tb-text" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdStatus,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdStatus, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdStDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdStDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <input type=\"hidden\" name=\"ProdSupId\"");
            BeginWriteAttribute("value", " value=\"", 2517, "\"", 2561, 1);
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
WriteAttributeValue("", 2525, ((TSuplier)ViewBag.Suplier).SupId, 2525, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TSProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
