#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725372ef147474406d7bfcb6163cedbe5834f0b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza__pListaUserRol), @"mvc.1.0.view", @"/Views/TOrganiza/_pListaUserRol.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725372ef147474406d7bfcb6163cedbe5834f0b2", @"/Views/TOrganiza/_pListaUserRol.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza__pListaUserRol : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TUsRol>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("   <table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h2>>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
    Write(SharedLocalizer.GetLocalizedHtmlString("UsrRolData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("RolName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
     foreach (var c in (List<TUsRol>) ViewBag.ListUserRol) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
                             Write(c.UsRolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class=\"col-text\">");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
                            Write(Html.ActionLink("Remove", "RolDelete", new { id = c.UsRolId, usid = c.UsRolUsId}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
Write(Html.ActionLink(@SharedLocalizer.GetLocalizedHtmlString("AddItem"), "RolCreate",new {usid=@UserId()}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUserRol.cshtml"
            
    int UserId(){
        int retcol=0;
        try{retcol=(int)ViewData["UserId"];}catch{}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TUsRol>> Html { get; private set; }
    }
}
#pragma warning restore 1591