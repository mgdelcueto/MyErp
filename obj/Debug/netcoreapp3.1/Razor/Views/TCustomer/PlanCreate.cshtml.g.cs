#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4dd5e1675a879ecd2b5583d5fe0228367666f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_PlanCreate), @"mvc.1.0.view", @"/Views/TCustomer/PlanCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4dd5e1675a879ecd2b5583d5fe0228367666f34", @"/Views/TCustomer/PlanCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PlanCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCCplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Add a New Planning record</h1>\r\n</div>\r\n");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"visible\">\r\n    ");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <tr>\r\n            <input type=\"hidden\" name=\"CPlanCustId\"");
            BeginWriteAttribute("value", " value=\"", 700, "\"", 747, 1);
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 708, ((TCustomer)ViewBag.Customer).CustId, 708, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CPlanCPlantId\"");
            BeginWriteAttribute("value", " value=\"", 805, "\"", 822, 1);
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 813, Planta(), 813, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CPlanCProdId\"");
            BeginWriteAttribute("value", " value=\"", 879, "\"", 896, 1);
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 887, Produc(), 887, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CPlanTruckId\"");
            BeginWriteAttribute("value", " value=\"", 953, "\"", 969, 1);
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 961, Truck(), 961, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <td>Customer :</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>  Nif:</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <table>\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanCplantId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                ");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.DropDownList("CplantId", (SelectList)ViewBag.ddlPlantVB, new { @class ="norm-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanCprodId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.DropDownListFor(p=> p.CplanCprodId, (SelectList)ViewBag.ddlReferVO, new { @class ="norm-text"  , onchange = "this.form.submit();"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanCprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n          </tr>\r\n        </table>\r\n        <table>\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 71 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 75 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanQty,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 76 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanQty, new { htmlAttributes = new { @class = "norm-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 77 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 80 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanUemb,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 81 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanUemb, new { htmlAttributes = new { @class = "norm-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 82 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanUemb));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanFirmSt,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanFirmSt, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 87 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanFirmSt));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>        
        <tr>
            <td></td>
            <td><input type=""submit"" value=""Add""  name=""actionType""/></td>
            <td><input type=""submit"" value=""Cancel"" name=""actionType""/></td>

        </tr>
    </table>
    </table>
    </div>
");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
            
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
    int? Truck(){
        int? retcol = (int?)ViewData["truck"];
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
