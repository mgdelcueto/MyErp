#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2b4e7fd4780d499b87ebef888a316a8a94da8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_Create), @"mvc.1.0.view", @"/Views/TCustomer/Create.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2b4e7fd4780d499b87ebef888a316a8a94da8f", @"/Views/TCustomer/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Add a New Customer</h1>\r\n</div>\r\n");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustRasoc,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustRasoc, new { htmlAttributes = new { @class = "norm-text", @style = "width:450px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustRasoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustNif,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustNif, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustNif));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustCrDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustCrDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustCode,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustCode, new { htmlAttributes = new { @class = "norm-text", @style = "width:250px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustAdStrt,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustAdStrt, new { htmlAttributes = new { @class = "norm-text", @style = "width:450px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustAdCity,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustAdCity, new { htmlAttributes = new { @class = "norm-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustAdStrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustAdCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustAdCtry,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.DropDownListFor(p => p.CustAdCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustCtPhone,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustCtPhone, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustAdCtry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCtPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustCtEmailLog,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 71 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustCtEmailLog, new { htmlAttributes = new { @class = "norm-text", @style = "width:250px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.LabelFor(p => p.CustCtEdilog,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.EditorFor(p => p.CustCtEdilog, new { htmlAttributes = new { @class = "norm-text", @style = "width:250px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 77 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCtEmailLog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 79 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCtEdilog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591
