#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d17c655e65f2dc449cd3248d3481bbfcff3f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_UserCreate), @"mvc.1.0.view", @"/Views/TOrganiza/UserCreate.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d17c655e65f2dc449cd3248d3481bbfcff3f84", @"/Views/TOrganiza/UserCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_UserCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AdUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
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
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
   Write(Html.Partial("_pshowUser",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            ");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
       Write(Coment());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserCreate.cshtml"
            
    string Coment(){
        string coment="";
        try{
        coment =@SharedLocalizer.GetLocalizedHtmlString((string)ViewData["Coment"]);
        coment = coment +" "+(string)ViewData["NewPw"];
        }catch{}
        return coment;
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
