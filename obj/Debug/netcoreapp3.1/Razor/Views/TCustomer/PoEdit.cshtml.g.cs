#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce4bceda2b69c950859dadcddf66c0580107dc7a"
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/_ViewImports.cshtml"
using MyErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce4bceda2b69c950859dadcddf66c0580107dc7a", @"/Views/TCustomer/PoEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PoEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCPorder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\n<h1>Edit an Order record</h1>\n</div>\n");
#nullable restore
#line 6 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\n    ");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
Write(Html.HiddenFor(p => p.Cpoid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 9 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
Write(Html.HiddenFor(p => p.CpocustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 10 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class =\"visible\">\n        <tr>\n            <td>Custome:</td>\n            <td>");
#nullable restore
#line 15 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td> </td>\n            <td>");
#nullable restore
#line 17 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </div>\n\n    <div class =\"div-bold\">\n        <tr>\n");
#nullable restore
#line 23 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
             using (Html.BeginForm("Edit","TCustomer",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class =\"visible\">\n            <td>");
#nullable restore
#line 25 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CpocplantId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"norm-text\">\n                <!--");
#nullable restore
#line 27 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\n                ");
#nullable restore
#line 28 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.DropDownListFor(p => p.CpocplantId,(SelectList)ViewBag.ddlPlantVB,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n           \n            </td>\n            </div>\n");
#nullable restore
#line 32 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </div>\n\n    <table class=\"table-norm\" border =\"1\">\n\n        <tr>\n            <td>");
#nullable restore
#line 39 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpopo,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 40 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpopo, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 41 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpopo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 44 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpodate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 45 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpodate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 46 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpodate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 49 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CporeferEx,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 50 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.EditorFor(p => p.CporeferEx, new { htmlAttributes = new { @class = "norm-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 51 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CporeferEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 54 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CpodescEx,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 55 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.EditorFor(p => p.CpodescEx, new { htmlAttributes = new { @class = "norm-text" , @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 56 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CpodescEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 59 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.CpocprodId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"norm-text\">\n                <!--");
#nullable restore
#line 61 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\n                ");
#nullable restore
#line 62 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.DropDownListFor(p => p.CpocprodId,(SelectList)ViewBag.ddlReferVD,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <td>");
#nullable restore
#line 63 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
               Write(Html.ValidationMessageFor(p => p.CpocprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 67 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpoprice,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 68 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpoprice, new { htmlAttributes = new { @class = "norm-text", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 69 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpoprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>        \n        <tr>        \n            <td>Divisa:</td>\n            <td>\n                ");
#nullable restore
#line 74 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.DropDownListFor(p => p.Cpocurcy,
               new SelectList(DataSource.GetCurrency(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 79 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.LabelFor(p => p.Cpostatus,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 80 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.EditorFor(p => p.Cpostatus, new { htmlAttributes = new { @class = "norm-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 81 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpostatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\n        </tr>\n    </table>\n    </div>\n");
#nullable restore
#line 89 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TCustomer/PoEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCPorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
