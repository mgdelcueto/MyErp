#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377107655dab58c349063f98228cca6273ed72d3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377107655dab58c349063f98228cca6273ed72d3", @"/Views/TCustomer/PoCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_PoCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCPorder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Add an Order record</h1>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class =\"invisible\">\r\n        <tr>\r\n            <input type=\"hidden\" name=\"CpocustId\"");
            BeginWriteAttribute("value", " value=\"", 403, "\"", 450, 1);
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
WriteAttributeValue("", 411, ((TCustomer)ViewBag.Customer).CustId, 411, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"CpocplantId\"");
            BeginWriteAttribute("value", " value=\"", 506, "\"", 523, 1);
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
WriteAttributeValue("", 514, Planta(), 514, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <td>Customer:</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </div>\r\n    <div class =\"visible\">\r\n        <tr>\r\n            <td>Custome:</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> </td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            Write(((TCustomer)ViewBag.Customer).CustNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </div>\r\n\r\n    <div class =\"div-bold\">\r\n        <tr>\r\n");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
             using (Html.BeginForm("Edit","TCustomer",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class =\"visible\">\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CpocplantId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.DropDownListFor(p => p.CpocplantId,(SelectList)ViewBag.ddlPlantVB,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n            </td>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </div>\r\n\r\n    <table class=\"table-norm\" border =\"1\">\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpopo,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpopo, new { htmlAttributes = new { @class = "norm-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpopo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpodate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpodate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpodate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CporeferEx,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.CporeferEx, new { htmlAttributes = new { @class = "norm-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CporeferEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CpodescEx,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.CpodescEx, new { htmlAttributes = new { @class = "norm-text" , @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.CpodescEx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.CpocprodId,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.DropDownListFor(p => p.CpocprodId,(SelectList)ViewBag.ddlReferVD,"",new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 74 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
               Write(Html.ValidationMessageFor(p => p.CpocprodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 78 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpoprice,new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 79 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpoprice, new { htmlAttributes = new { @class = "norm-text", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 80 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpoprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>        \r\n            <td>Divisa:</td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.DropDownListFor(p => p.Cpocurcy,
               new SelectList(DataSource.GetCurrency(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 90 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.LabelFor(p => p.Cpostatus,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 91 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.EditorFor(p => p.Cpostatus, new { htmlAttributes = new { @class = "norm-text", @style = "width:170px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 92 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.Cpostatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\PoCreate.cshtml"
            
    int? Planta(){
        int? retcol = (int?)ViewData["Plant"];
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCPorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
