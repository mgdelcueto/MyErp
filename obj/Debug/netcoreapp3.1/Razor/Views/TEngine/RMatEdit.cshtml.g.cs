#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "217df7b22e70ec7b6260987f4f078d0667c11df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_RMatEdit), @"mvc.1.0.view", @"/Views/TEngine/RMatEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"217df7b22e70ec7b6260987f4f078d0667c11df4", @"/Views/TEngine/RMatEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_RMatEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VTMRouting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Edit a Operation record</h1>\r\n</div>\r\n");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml"
 using (Html.BeginForm(new{Mid = Model.RoRoMatId})) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"visible\">\r\n    ");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml"
   Write(Html.Partial("_pshowRMaterials",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\RMatEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VTMRouting> Html { get; private set; }
    }
}
#pragma warning restore 1591
