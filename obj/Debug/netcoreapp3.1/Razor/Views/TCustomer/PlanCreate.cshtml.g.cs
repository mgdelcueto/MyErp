#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989bd3d4203089fbb2b59694171f010a543ca828"
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
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989bd3d4203089fbb2b59694171f010a543ca828", @"/Views/TCustomer/PlanCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PlanCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCCplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
  
    Layout = "_LayCus";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AddPlanningRecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"div-edit\">\r\n    ");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n    <table class=\"table-edit\">\r\n");
            WriteLiteral("    <input id=\"sallpprods\" name =\"sallpprods\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=", 1630, "", 1645, 1);
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 1637, allPP(), 1637, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table class=\"table-edit\">\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanCplantId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.DropDownList("CplantId", (SelectList)ViewBag.ddlPlantVB, new { @class ="norm-tb-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanCprodId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.DropDownListFor(p=> p.CplanCprodId, (SelectList)ViewBag.ddlReferVO, new { @class ="norm-tb-text"  , onchange = "this.form.submit();"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 78 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanCprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>  
          </tr>
    </table>
    <table class=""table-edit"">
        <hr style=""width:100%;text-align:left;margin-left:0"">
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Add""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 90 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 93 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 94 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanQty,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 99 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanQty, new { htmlAttributes = new { @class = "norm-tb-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 103 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanUemb,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 104 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.EditorFor(p => p.CplanUemb, new { htmlAttributes = new { @class = "norm-tb-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 105 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanUemb));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 108 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.LabelFor(p => p.CplanFirmSt,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n               ");
#nullable restore
#line 110 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
          Write(Html.DropDownListFor(p => p.CplanFirmSt,
               new SelectList(DataSource.GetCPlanStatus(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 113 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanFirmSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <input type=\"hidden\" name=\"CPlanCustId\"");
            BeginWriteAttribute("value", " value=\"", 5055, "\"", 5102, 1);
#nullable restore
#line 114 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 5063, ((TCustomer)ViewBag.Customer).CustId, 5063, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CPlanCPlantId\"");
            BeginWriteAttribute("value", " value=\"", 5160, "\"", 5177, 1);
#nullable restore
#line 115 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 5168, Planta(), 5168, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CPlanCProdId\"");
            BeginWriteAttribute("value", " value=\"", 5234, "\"", 5251, 1);
#nullable restore
#line 116 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 5242, Produc(), 5242, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CPlanTruckId\"");
            BeginWriteAttribute("value", " value=\"", 5308, "\"", 5324, 1);
#nullable restore
#line 117 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
WriteAttributeValue("", 5316, Truck(), 5316, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n       </tr>        \r\n    </table>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 122 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlanCreate.cshtml"
            
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
    string allPP(){
        string ret = "false";
        try{
            ret = ViewData["Allpp"].ToString();
        }
        catch(Exception ex) {
            string mensaje = ex.Message;
            }
        return ret;
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCCplanning> Html { get; private set; }
    }
}
#pragma warning restore 1591
