#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "415eefd55652e3854f730fcc41d44d12aa537584"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_PlantEdit), @"mvc.1.0.view", @"/Views/TCustomer/PlantEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415eefd55652e3854f730fcc41d44d12aa537584", @"/Views/TCustomer/PlantEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PlantEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCCplant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
  
    Layout = "_LayCus";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EditPlantRecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
Write(Html.HiddenFor(p => p.CplantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
Write(Html.HiddenFor(p => p.CplantCustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <table class=\"table-edit\">\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n");
            WriteLiteral("        <tr>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.LabelFor(p => p.CplantCode,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.EditorFor(p => p.CplantCode, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.LabelFor(p => p.CplantDeno,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.EditorFor(p => p.CplantDeno, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantDeno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.LabelFor(p => p.CplantAdStrt,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.EditorFor(p => p.CplantAdStrt, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantAdStrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.LabelFor(p => p.CplantAdCity,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.EditorFor(p => p.CplantAdCity, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:220px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantAdCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.LabelFor(p => p.CplantAdCtry,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.DropDownListFor(p => p.CplantAdCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.LabelFor(p => p.CplantTruckId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.DropDownListFor(p => p.CplantTruckId,(SelectList)ViewBag.ddlTruckX,"",new { @class = "norm-tb-text"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantTruckId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 71 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCCplant> Html { get; private set; }
    }
}
#pragma warning restore 1591
