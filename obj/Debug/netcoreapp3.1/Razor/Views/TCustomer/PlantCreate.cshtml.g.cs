#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39bdc35632a4fe9eb094fc8593c85b66f79c2343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_PlantCreate), @"mvc.1.0.view", @"/Views/TCustomer/PlantCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39bdc35632a4fe9eb094fc8593c85b66f79c2343", @"/Views/TCustomer/PlantCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PlantCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCCplant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Add a New Plant record</h1>\r\n</div>\r\n");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <table class=\"table-norm\" border =\"1\">\r\n        <tr>\r\n            <input type=\"hidden\" name=\"CplantCustId\"");
            BeginWriteAttribute("value", " value=\"", 309, "\"", 356, 1);
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
WriteAttributeValue("", 317, ((TCustomer)ViewBag.Customer).CustId, 317, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <td>Customer:</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td> </td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.LabelFor(p => p.CplantCode,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.EditorFor(p => p.CplantCode, new { htmlAttributes = new { @class = "norm-text", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.LabelFor(p => p.CplantDeno,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.EditorFor(p => p.CplantDeno, new { htmlAttributes = new { @class = "norm-text", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantDeno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.LabelFor(p => p.CplantAdStrt,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.EditorFor(p => p.CplantAdStrt, new { htmlAttributes = new { @class = "norm-text", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantAdStrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.LabelFor(p => p.CplantAdCity,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.EditorFor(p => p.CplantAdCity, new { htmlAttributes = new { @class = "norm-text", @style = "width:220px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantAdCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>Pais</td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.DropDownListFor(p => p.CplantAdCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.LabelFor(p => p.CplantTruckId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.DropDownListFor(p => p.CplantTruckId,(SelectList)ViewBag.ddlTruckX,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplantTruckId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PlantCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCCplant> Html { get; private set; }
    }
}
#pragma warning restore 1591
