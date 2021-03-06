#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79764777010d557ca4d757ad590b90e196f80d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_TrEdit), @"mvc.1.0.view", @"/Views/TEngine/TrEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79764777010d557ca4d757ad590b90e196f80d1", @"/Views/TEngine/TrEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_TrEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCTruck>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("HRAreaIndexPage");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Edit a Truck record</h1>\r\n</div>\r\n");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
Write(Html.HiddenFor(p => p.TruckId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
   Write(Html.Partial("_pshowTrucks",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
            WriteLiteral("<!--Work Centers-->\r\n<div");
            BeginWriteAttribute("class", " class=", 1219, "", 1239, 1);
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
WriteAttributeValue("", 1226, isVisible(1), 1226, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h2>>Truck Schedules</h2>\r\n    </div>\r\n    ");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
Write(Html.Partial("_pListaTruckSchedules",(List<TCTrSched>)ViewBag.ListSTrucks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
Write(Html.ActionLink("Assign a new Schedule", "TrSCreate", new { tid= @Model.TruckId,vpanel=1}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 58 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\TrEdit.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        try{
        int opanel = (int)ViewData["vpanel"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
        }catch{}
        return retcol;
    }
string assVisible()
{
    string retcol="invisible";
    try{
    if ((int)ViewData["Assign"]==1)
    {retcol="visible";}
    }
    catch{}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCTruck> Html { get; private set; }
    }
}
#pragma warning restore 1591
