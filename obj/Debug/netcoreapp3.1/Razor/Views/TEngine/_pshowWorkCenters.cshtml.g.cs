#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9dc34d7fd4e6309bb452ae0f6f56e8eadb50d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pshowWorkCenters), @"mvc.1.0.view", @"/Views/TEngine/_pshowWorkCenters.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dc34d7fd4e6309bb452ae0f6f56e8eadb50d28", @"/Views/TEngine/_pshowWorkCenters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pshowWorkCenters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TWorkCenter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.Wccode,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.Wccode, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.Wctype,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.Wctype, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.Wccode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.Wctype));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.Wcdescr,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.Wcdescr, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.WcfaId,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.DropDownListFor(p => p.WcfaId,(SelectList)ViewBag.ddlPlantVB,"",new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.Wcdescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.WcfaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.Wcacct,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.Wcacct, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.WccrDate,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.WccrDate, new { htmlAttributes = new { @class = "norm-tb-text" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.Wcacct));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.WccrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.Wcstatus,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.Wcstatus, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:90px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.WcstDate,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.WcstDate, new { htmlAttributes = new { @class = "norm-tb-text" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.Wcstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.WcstDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.Wcsupm2,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.Wcsupm2, new { htmlAttributes = new { @class = "norm-tb-num", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.LabelFor(p => p.WccostMin,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.EditorFor(p => p.WccostMin, new { htmlAttributes = new { @class = "norm-tb-num", @style = "width:150px," } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.Wcsupm2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowWorkCenters.cshtml"
           Write(Html.ValidationMessageFor(p => p.WccostMin));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TWorkCenter> Html { get; private set; }
    }
}
#pragma warning restore 1591
