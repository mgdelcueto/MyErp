#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b51895217b90d58c5f5d8db770e535de213cfcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_OphEdit), @"mvc.1.0.view", @"/Views/TEngine/OphEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b51895217b90d58c5f5d8db770e535de213cfcd", @"/Views/TEngine/OphEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_OphEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TOperator>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("OperEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
Write(Html.HiddenFor(p => p.OpeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
   Write(Html.Partial("_pshowOperators",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\OphEdit.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
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
private int VAssign(){
    int resul = 1;
    try{
    if ((int)ViewData["Assign"]==1)
    {resul=0;}
    }
    catch{}
    return resul;

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TOperator> Html { get; private set; }
    }
}
#pragma warning restore 1591
