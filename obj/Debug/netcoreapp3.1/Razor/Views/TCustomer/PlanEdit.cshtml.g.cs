#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c9853f2ae648fbff3116a21087a7654fc09b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_PlanEdit), @"mvc.1.0.view", @"/Views/TCustomer/PlanEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c9853f2ae648fbff3116a21087a7654fc09b8c", @"/Views/TCustomer/PlanEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PlanEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCCplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Edit a Planning record</h1>\r\n</div>\r\n");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"visible\">\r\n    ");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
Write(Html.HiddenFor(p => p.CplanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
Write(Html.HiddenFor(p => p.CplanCustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <tr>\r\n            <td>Customer :</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> Nif:</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <table>\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.LabelFor(p => p.CplanCplantId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                ");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.DropDownList("CplantId", (SelectList)ViewBag.ddlPlantVB, new { @class ="norm-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.LabelFor(p => p.CplanCprodId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                ");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.DropDownList("CprodId", (SelectList)ViewBag.ddlReferVO, new { @class ="norm-text"  , onchange = "this.form.submit();"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        </table>\r\n        <table>\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 58 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.LabelFor(p => p.CplanQty,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.EditorFor(p => p.CplanQty, new { htmlAttributes = new { @class = "norm-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.LabelFor(p => p.CplanFirmSt,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 74 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.EditorFor(p => p.CplanFirmSt, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 75 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanFirmSt));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>        
        <tr>
            <td></td>
            <td><input type=""submit"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        </table>
    </table>
 </div>
");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanEdit.cshtml"
            
    int CustId(){
        return ((TCustomer)ViewBag.Customer).CustId;
    }
    int? Planta(){
        int? retcol = (int?)ViewData["Plant"];
        return retcol;
    }
    int? Produc(){
        int? retcol = (int?)ViewData["cProd"];
        return retcol;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCCplanning> Html { get; private set; }
    }
}
#pragma warning restore 1591
