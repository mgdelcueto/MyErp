#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18fbb72621ac712b8f6d093fa1ebeee0c8a98af3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_PoCreate), @"mvc.1.0.view", @"/Views/TCustomer/PoCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18fbb72621ac712b8f6d093fa1ebeee0c8a98af3", @"/Views/TCustomer/PoCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PoCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCPorder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
  
    Layout = "_LayCus";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AddPORecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class =\"invisible\">\r\n        <tr>\r\n            <input type=\"hidden\" name=\"CpocustId\"");
            BeginWriteAttribute("value", " value=\"", 530, "\"", 577, 1);
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
WriteAttributeValue("", 538, ((TCustomer)ViewBag.Customer).CustId, 538, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </div>\r\n");
            WriteLiteral("    <div class =\"div-edit\">\r\n        <tr>\r\n");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
             using (Html.BeginForm("Edit","TCustomer",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class =\"div-edit\">\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CpocplantId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.DropDownListFor(p => p.CpocplantId,(SelectList)ViewBag.ddlPlantVB,"",new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n            </td>\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tr>
    </div>

    <table class=""table-edit"">
        <hr style=""width:100%;text-align:left;margin-left:0"">
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Add""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpopo,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpopo, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpopo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpodate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpodate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpodate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CporeferEx,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.CporeferEx, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 71 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CporeferEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 74 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CpodescEx,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 75 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.CpodescEx, new { htmlAttributes = new { @class = "norm-tb-text" , @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 76 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CpodescEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 79 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CpocprodId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 81 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.DropDownListFor(p => p.CpocprodId,(SelectList)ViewBag.ddlReferVD,"",new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 82 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
               Write(Html.ValidationMessageFor(p => p.CpocprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpoprice,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 87 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpoprice, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpoprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>        \r\n            <td>");
#nullable restore
#line 91 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpocurcy,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.DropDownListFor(p => p.Cpocurcy,
               new SelectList(DataSource.GetCurrency(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpostatus,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 99 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpostatus, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpostatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <input type=\"hidden\" name=\"CpocustId\"");
            BeginWriteAttribute("value", " value=\"", 4537, "\"", 4584, 1);
#nullable restore
#line 101 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
WriteAttributeValue("", 4545, ((TCustomer)ViewBag.Customer).CustId, 4545, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CpocplantId\"");
            BeginWriteAttribute("value", " value=\"", 4640, "\"", 4657, 1);
#nullable restore
#line 102 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
WriteAttributeValue("", 4648, Planta(), 4648, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 106 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            
    int? Planta(){
        int? retcol = (int?)ViewData["Plant"];
        return retcol;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCPorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
