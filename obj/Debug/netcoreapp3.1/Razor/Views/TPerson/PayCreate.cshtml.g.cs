#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7c5da8cf6b950029cbcca4cc3c630dd4f367ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_PayCreate), @"mvc.1.0.view", @"/Views/TPerson/PayCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c5da8cf6b950029cbcca4cc3c630dd4f367ea7", @"/Views/TPerson/PayCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_PayCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPPay>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
  
    Layout = "_LayPer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("PayrollCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table class=""table-edit"" border=""0"">
        <hr style=""width:100%;text-align:left;margin-left:0"">
        <tr>
            <td>
            <input type=""submit"" value=""Add""  class=""dropbtn"" name=""actionType""/>
            <input type=""submit"" value=""Cancel"" class=""dropbtn"" name=""actionType""/>
            </td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayStDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayStDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayType,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayType, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayImporte,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayImporte, new { htmlAttributes = new { @class = "norm-tb-num", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayImporte));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayRet,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayRet, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayRet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayAccount,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayAccount, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:225px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <input type=\"hidden\" name=\"PayPerId\"");
            BeginWriteAttribute("value", " value=\"", 2937, "\"", 2979, 1);
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
WriteAttributeValue("", 2945, ((TPerson)ViewBag.Person).PerId, 2945, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPPay> Html { get; private set; }
    }
}
#pragma warning restore 1591
