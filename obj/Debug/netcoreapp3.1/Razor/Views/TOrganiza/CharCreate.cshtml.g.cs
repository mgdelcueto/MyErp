#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4666c672dfd97ab6da616aec6c65500a64ca1f21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_CharCreate), @"mvc.1.0.view", @"/Views/TOrganiza/CharCreate.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4666c672dfd97ab6da616aec6c65500a64ca1f21", @"/Views/TOrganiza/CharCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_CharCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TChart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AdChart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
   Write(Html.Partial("_pshowChart",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         <tr>\r\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TChart> Html { get; private set; }
    }
}
#pragma warning restore 1591