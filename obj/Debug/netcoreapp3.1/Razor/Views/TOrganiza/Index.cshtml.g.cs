#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ccdc1b2ab05951d6fe575d7726fcdf595dc3ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_Index), @"mvc.1.0.view", @"/Views/TOrganiza/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ccdc1b2ab05951d6fe575d7726fcdf595dc3ff", @"/Views/TOrganiza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <!--Organization-->\r\n\r\n    <!--Chart-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 424, "", 444, 1);
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
WriteAttributeValue("", 431, isVisible(2), 431, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
Write(await Html.PartialAsync("_pListaChart",(List<VTChart>)ViewBag.ListChar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <!--Users-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 817, "", 837, 1);
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
WriteAttributeValue("", 824, isVisible(5), 824, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
Write(await Html.PartialAsync("_pListaUsers",(List<TUser>)ViewBag.ListUS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <!--Languages-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 958, "", 978, 1);
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
WriteAttributeValue("", 965, isVisible(3), 965, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            ");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Useddltoselect"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
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
