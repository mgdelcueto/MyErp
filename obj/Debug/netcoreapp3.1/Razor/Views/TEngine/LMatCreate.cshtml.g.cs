#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89434ca378e43cc4b3a3524a36b53c77648cceb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_LMatCreate), @"mvc.1.0.view", @"/Views/TEngine/LMatCreate.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89434ca378e43cc4b3a3524a36b53c77648cceb2", @"/Views/TEngine/LMatCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_LMatCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VTMLocation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\" clearfix position-relative o_form_sheet center\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
  ViewData["MatId"]=@Model.LoRefId;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
Write(Html.Partial("_pmenuMat_com"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
Write(Html.Partial("_pshowMaterials_parc_com",(TMaterial)ViewBag.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("MatLocCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
 using (Html.BeginForm(new{id = Model.LoRefId})) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table-edit"">
         <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Add""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        ");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
   Write(Html.Partial("_pshowLMaterials",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\LMatCreate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VTMLocation> Html { get; private set; }
    }
}
#pragma warning restore 1591
