#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "063f4164b426b0de1a329e3c8052dc5e46f397ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza__pListaUsers), @"mvc.1.0.view", @"/Views/TOrganiza/_pListaUsers.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063f4164b426b0de1a329e3c8052dc5e46f397ac", @"/Views/TOrganiza/_pListaUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza__pListaUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n   <table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h3>");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("UsrData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("UName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                \r\n        <th class=\"head-text\">");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("ULastName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
     foreach (var c in (List<TUser>) ViewBag.ListUS) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
                             Write(c.UserFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
                             Write(c.UserLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
                            Write(Html.ActionLink("Delete", "UserDelete", new { id = c.UserId}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
                            Write(Html.ActionLink("Edit", "UserEdit", new { id = c.UserId ,panel=5}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaUsers.cshtml"
Write(Html.ActionLink(@SharedLocalizer.GetLocalizedHtmlString("AddItem"), "UserCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
