#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfd25fcc3a230f57e08d3b43dfae32cdb6eed2e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pshowOperators), @"mvc.1.0.view", @"/Views/TEngine/_pshowOperators.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd25fcc3a230f57e08d3b43dfae32cdb6eed2e1", @"/Views/TEngine/_pshowOperators.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pshowOperators : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TOperator>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.LabelFor(p => p.OpeCode,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.EditorFor(p => p.OpeCode, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.ValidationMessageFor(p => p.OpeCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.LabelFor(p => p.OpeDesc,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.EditorFor(p => p.OpeDesc, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:450px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.LabelFor(p => p.OpeAcct,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.EditorFor(p => p.OpeAcct, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.ValidationMessageFor(p => p.OpeDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.ValidationMessageFor(p => p.OpeAcct));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.LabelFor(p => p.OpeCosth,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.EditorFor(p => p.OpeCosth, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.LabelFor(p => p.OpeCurcy,new { @class = "norm-lab-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.DropDownListFor(p => p.OpeCurcy,
               new SelectList(DataSource.GetCurrency(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.ValidationMessageFor(p => p.OpeCosth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pshowOperators.cshtml"
           Write(Html.ValidationMessageFor(p => p.OpeCurcy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TOperator> Html { get; private set; }
    }
}
#pragma warning restore 1591
