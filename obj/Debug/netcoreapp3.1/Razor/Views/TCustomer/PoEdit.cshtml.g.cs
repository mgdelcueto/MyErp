#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26d171cf867537682a2ae2744db0fd04026cc893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_PoEdit), @"mvc.1.0.view", @"/Views/TCustomer/PoEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26d171cf867537682a2ae2744db0fd04026cc893", @"/Views/TCustomer/PoEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PoEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCPorder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
  
    Layout = "_LayCus";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EditPORecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
Write(Html.HiddenFor(p => p.Cpoid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
Write(Html.HiddenFor(p => p.CpocustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <div class =\"div-bold\">\r\n        <tr>\r\n");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
             using (Html.BeginForm("Edit","TCustomer",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class =\"visible\">\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CpocplantId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.DropDownListFor(p => p.CpocplantId,(SelectList)ViewBag.ddlPlantVB,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n            </td>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </div>\r\n\r\n    <table class=\"table-norm\" border =\"1\">\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpopo,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpopo, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpopo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpodate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpodate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpodate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 54 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CporeferEx,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.EditorFor(p => p.CporeferEx, new { htmlAttributes = new { @class = "norm-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CporeferEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CpodescEx,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.EditorFor(p => p.CpodescEx, new { htmlAttributes = new { @class = "norm-text" , @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CpodescEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CpocprodId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.DropDownListFor(p => p.CpocprodId,(SelectList)ViewBag.ddlReferVD,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
               Write(Html.ValidationMessageFor(p => p.CpocprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpoprice,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpoprice, new { htmlAttributes = new { @class = "norm-text", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 74 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpoprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>        \r\n            <td>Divisa:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.DropDownListFor(p => p.Cpocurcy,
               new SelectList(DataSource.GetCurrency(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 84 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpostatus,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpostatus, new { htmlAttributes = new { @class = "norm-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpostatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 94 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCPorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
