#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ab794639cb0089676b9af4e9548de5ff7199970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza__pListaChartRol), @"mvc.1.0.view", @"/Views/TOrganiza/_pListaChartRol.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab794639cb0089676b9af4e9548de5ff7199970", @"/Views/TOrganiza/_pListaChartRol.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza__pListaChartRol : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VTChartRol>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n   <table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h2>>");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
    Write(SharedLocalizer.GetLocalizedHtmlString("CharData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
     foreach (var c in (List<VTChartRol>) ViewBag.ListCharRol) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
                             Write(c.RcharRolId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
                             Write(c.RcharPerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
                            Write(Html.ActionLink("Remove", "RCharDelete", new { id = c.RcharId,  chid = c.RcharCharId} ,new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
Write(Html.ActionLink("Add a New Item", "RCharCreate",new {chid=@ChartId()}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\_pListaChartRol.cshtml"
            
    int ChartId(){
        int retcol=0;
        try{retcol=(int)ViewData["ChartId"];}catch{}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VTChartRol>> Html { get; private set; }
    }
}
#pragma warning restore 1591