#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8e0e6e0c3d6e2cafb0954532e8efb5128ee6eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pshowCMaterials), @"mvc.1.0.view", @"/Views/TEngine/_pshowCMaterials.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\_ViewImports.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8e0e6e0c3d6e2cafb0954532e8efb5128ee6eb", @"/Views/TEngine/_pshowCMaterials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pshowCMaterials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VTMComponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <tr>\r\n            ");
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
       Write(Html.HiddenFor(p => p.CoRefId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
       Write(Html.HiddenFor(p => p.CoRefRe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
       Write(Html.HiddenFor(p => p.CoRefDes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
       Write(Html.HiddenFor(p => p.CoRefUM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.LabelFor(p => p.CoRefRe,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Model.CoRefRe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.LabelFor(p => p.CoRefDes,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Model.CoRefDes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.LabelFor(p => p.CoComId,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
             using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\" name=\"Filter\" value=\"2\"/>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.DropDownListFor(p => p.CoComId,(SelectList)ViewBag.ddlMatCOM,"",new { @class = "norm-tb-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.CoComId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.LabelFor(p => p.CoRefQt,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.EditorFor(p => p.CoRefQt, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Model.CoRefUM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.CoRefQt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.LabelFor(p => p.CoComQt,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.EditorFor(p => p.CoComQt, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Model.CoComUM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowCMaterials.cshtml"
           Write(Html.ValidationMessageFor(p => p.CoComQt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VTMComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
