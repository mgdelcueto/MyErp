#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3685918518ab04c7e4653e6e70a0a01227e5ba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_ConEdit), @"mvc.1.0.view", @"/Views/TPerson/ConEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3685918518ab04c7e4653e6e70a0a01227e5ba1", @"/Views/TPerson/ConEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_ConEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPContract>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
  
    Layout = "_LayPer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("ContractEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
Write(Html.HiddenFor(p => p.ConId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
Write(Html.HiddenFor(p => p.ConPerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table class=""table-edit"" >
        <hr style=""width:100%;text-align:left;margin-left:0"">
        <tr>
            <td>
            <input type=""submit"" value=""Update""  class=""dropbtn"" name=""actionType""/>
            <input type=""submit"" value=""Cancel"" class=""dropbtn"" name=""actionType""/>
            </td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
           Write(Html.LabelFor(p => p.ConRevDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
           Write(Html.EditorFor(p => p.ConRevDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ConRevDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
           Write(Html.LabelFor(p => p.ConObs,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
           Write(Html.EditorFor(p => p.ConObs, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:455px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ConObs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\ConEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPContract> Html { get; private set; }
    }
}
#pragma warning restore 1591
