#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc1197c757b0d6eb943a1637d7d627f90d793eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_WCEComp), @"mvc.1.0.view", @"/Views/TEngine/WCEComp.cshtml")]
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
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc1197c757b0d6eb943a1637d7d627f90d793eb", @"/Views/TEngine/WCEComp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_WCEComp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TWorkCenter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("WCEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n");
            WriteLiteral("    ");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
   Write(Html.Partial("_pshowWCenters_parc",(TWorkCenter)ViewBag.WCenter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n    <div class=\"cont-titles\">\r\n    <h3>");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("ComponentsOf"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
                                                           Write(Model.Wcdescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
   Write(Html.Partial("_pListaWCComponents",(List<TWccomponent>)ViewBag.ListPodAs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
Write(Html.ActionLink("Assig a new Component", "WCEComp", new { id= @Model.WcdId, wrem = 0, wass=0,assign=@VAssign()}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 1506, "", 1526, 1);
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
WriteAttributeValue("", 1513, assVisible(), 1513, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table>\r\n        <tr>\r\n");
#nullable restore
#line 63 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
             using (Html.BeginForm("WCEComp","TEngine", new { id= @Model.WcdId, wrem = 0, wass=1},FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WCToAssign"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"hidden\" name=\"wass\" value=\"1\"/>\r\n            </td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
           Write(Html.DropDownList("WcoId", (SelectList)ViewBag.ddlPodNAS, new { @class ="medium-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 71 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 75 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"






}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\WCEComp.cshtml"
            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TWorkCenter> Html { get; private set; }
    }
}
#pragma warning restore 1591
