#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a34f714902051cdd7a97eae4233f13a6e4f73bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_WCoEdit), @"mvc.1.0.view", @"/Views/TEngine/WCoEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a34f714902051cdd7a97eae4233f13a6e4f73bf", @"/Views/TEngine/WCoEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_WCoEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TWccomponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Edit a Component record</h1>\r\n</div>\r\n");
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
Write(Html.HiddenFor(p => p.WcoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
   Write(Html.Partial("_pshowWCComponents",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCoEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TWccomponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
