#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79bd28558c1cf61a9d08ded84e99ea4241d76883"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_RevCreate), @"mvc.1.0.view", @"/Views/TPerson/RevCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79bd28558c1cf61a9d08ded84e99ea4241d76883", @"/Views/TPerson/RevCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_RevCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPReview>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
  
    Layout = "_LayPer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("ObjectiveReviewCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <table class=\"table-norm\" border=\"1\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.LabelFor(p => p.RevDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.EditorFor(p => p.RevDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.RevDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.LabelFor(p => p.RevObj,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.EditorFor(p => p.RevObj, new { htmlAttributes = new { @class = "norm-text", @style = "width:425px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.RevObj));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.LabelFor(p => p.RevObRat,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.EditorFor(p => p.RevObRat, new { htmlAttributes = new { @class = "norm-text", @style = "width:125px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.RevObRat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <input type=\"hidden\" name=\"RevPerId\"");
            BeginWriteAttribute("value", " value=\"", 1877, "\"", 1919, 1);
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
WriteAttributeValue("", 1885, ((TPerson)ViewBag.Person).PerId, 1885, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Add\" name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\RevCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPReview> Html { get; private set; }
    }
}
#pragma warning restore 1591
