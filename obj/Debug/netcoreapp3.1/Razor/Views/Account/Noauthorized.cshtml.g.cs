#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\Account\Noauthorized.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d92e71d3374d94696342261d5d1c27f7964e734e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Noauthorized), @"mvc.1.0.view", @"/Views/Account/Noauthorized.cshtml")]
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
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\Account\Noauthorized.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92e71d3374d94696342261d5d1c27f7964e734e", @"/Views/Account/Noauthorized.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Noauthorized : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\Account\Noauthorized.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">>");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\Account\Noauthorized.cshtml"
                      Write(SharedLocalizer.GetLocalizedHtmlString("Unauthorized"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\Account\Noauthorized.cshtml"
       Write(Html.ActionLink(@SharedLocalizer.GetLocalizedHtmlString("PleaseLogin"), "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\Account\Noauthorized.cshtml"
            
    string Enlace(){
        string retcol="";
        try{
        retcol = (string)ViewData["link"];
        }catch{}
        return retcol;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591