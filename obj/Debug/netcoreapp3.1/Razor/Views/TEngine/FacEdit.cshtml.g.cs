#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e968cbcbbe0d0298226cb3913bb90ba2204451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_FacEdit), @"mvc.1.0.view", @"/Views/TEngine/FacEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e968cbcbbe0d0298226cb3913bb90ba2204451", @"/Views/TEngine/FacEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_FacEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TFacility>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cont-titles\">\r\n<h1>Edit a Facility record</h1>\r\n</div>\r\n");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.HiddenFor(p => p.FaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
   Write(Html.Partial("_pshowFacilities",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.Partial("_pmenuFac",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Work Centers-->\r\n<div");
            BeginWriteAttribute("class", " class=", 1513, "", 1533, 1);
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
WriteAttributeValue("", 1520, isVisible(1), 1520, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h2>>Work Centers Asigned</h2>\r\n    </div>\r\n    ");
#nullable restore
#line 78 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.Partial("_pListaWorkCenters",(List<TWorkCenter>)ViewBag.ListProdAs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 80 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.ActionLink("Assign a new work Center", "FacEdit", new { id= @Model.FaId,vpanel=1, wrem = 0, wass=0,assign=@VAssign()}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 1879, "", 1899, 1);
#nullable restore
#line 81 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
WriteAttributeValue("", 1886, assVisible(), 1886, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table>\r\n        <tr>\r\n");
#nullable restore
#line 84 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
             using (Html.BeginForm("FacEdit","TEngine", new { id= @Model.FaId,vpanel=1, wrem = 0, wass=1},FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Work Center to assign\r\n            <input type=\"hidden\" name=\"wass\" value=\"1\"/>\r\n            </td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 90 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
           Write(Html.DropDownList("WcdId", (SelectList)ViewBag.ddlProdNAS, new { @class ="medium-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 92 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>\r\n");
            WriteLiteral("<!--Locations-->\r\n<div");
            BeginWriteAttribute("class", " class=", 2501, "", 2521, 1);
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
WriteAttributeValue("", 2508, isVisible(2), 2508, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h2>>Storages Asigned</h2>\r\n    </div>\r\n    ");
#nullable restore
#line 105 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.Partial("_pListaStorages",(List<TLocation>)ViewBag.ListStorAs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 107 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
Write(Html.ActionLink("Assign a new Location", "FacEdit", new { id= @Model.FaId, wrel = 0,vpanel=2, wasl=0,assigl=@LAssign()}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 2855, "", 2875, 1);
#nullable restore
#line 108 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
WriteAttributeValue("", 2862, aslVisible(), 2862, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table>\r\n        <tr>\r\n");
#nullable restore
#line 111 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
             using (Html.BeginForm("FacEdit","TEngine", new { id= @Model.FaId, wrel = 0,vpanel=2, wasl=1},FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Location to assign\r\n            <input type=\"hidden\" name=\"wasl\" value=\"1\"/>\r\n            </td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 116 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 117 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
           Write(Html.DropDownList("LocId", (SelectList)ViewBag.ddlLocNAS, new { @class ="medium-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 119 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 123 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\FacEdit.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["vpanel"];
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

string aslVisible()
{
    string retcol="invisible";
    try{
    if ((int)ViewData["LAssign"]==1)
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
private int LAssign(){
    int resul = 1;
    try{
    if ((int)ViewData["LAssign"]==1)
    {resul=0;}
    }
    catch{}
    return resul;
}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TFacility> Html { get; private set; }
    }
}
#pragma warning restore 1591
