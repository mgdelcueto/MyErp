#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c5f6dd088574298634f0ce03bdcf2c217269fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_PayEdit), @"mvc.1.0.view", @"/Views/TPerson/PayEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c5f6dd088574298634f0ce03bdcf2c217269fb", @"/Views/TPerson/PayEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_PayEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPPay>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"visicont-titlesble\">\r\n<h1>Edit a Pay record</h1>\r\n</div>\r\n");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
Write(Html.HiddenFor(p => p.PayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
Write(Html.HiddenFor(p => p.PayPerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <tr>\r\n            <td>Nombre :</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
            Write(((TPerson)ViewBag.Person).PerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> </td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
            Write(((TPerson)ViewBag.Person).PerName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.LabelFor(p => p.PayStDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.EditorFor(p => p.PayStDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.LabelFor(p => p.PayType,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.EditorFor(p => p.PayType, new { htmlAttributes = new { @class = "norm-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.LabelFor(p => p.PayRet,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.EditorFor(p => p.PayRet, new { htmlAttributes = new { @class = "norm-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayRet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.LabelFor(p => p.PayAccount,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.EditorFor(p => p.PayAccount, new { htmlAttributes = new { @class = "norm-text", @style = "width:225px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
        <tr>
        <tr>
            <td></td>
            <td><input type=""submit"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" value=""Cancel"" name=""actionType""/></td>

        </tr>
    </table>
    </div>
");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\PayEdit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPPay> Html { get; private set; }
    }
}
#pragma warning restore 1591
