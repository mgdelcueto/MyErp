#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "211751207eafc2058148c5262763e5b63edae6d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_PoEdit_copy), @"mvc.1.0.view", @"/Views/TSuplier/PoEdit copy.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211751207eafc2058148c5262763e5b63edae6d6", @"/Views/TSuplier/PoEdit copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_PoEdit_copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSPorder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EditPORecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(Html.HiddenFor(p => p.Spoid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(Html.HiddenFor(p => p.SposupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table-edit"">
        <hr style=""width:100%;text-align:left;margin-left:0"">        
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        ");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
   Write(Html.Partial("_pshowspo",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\PoEdit copy.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TSPorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
