#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c11751052e75b163408c61eb4a8bb49a6a5c64b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine__pListaStorages_all), @"mvc.1.0.view", @"/Views/TEngine/_pListaStorages_all.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c11751052e75b163408c61eb4a8bb49a6a5c64b", @"/Views/TEngine/_pListaStorages_all.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine__pListaStorages_all : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TLocation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
     using (Html.BeginForm("Index","TEngine",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n            <td>\r\n                <input type=\"hidden\" name=\"panel\" value=\"5\"/>\r\n            </td>\r\n\r\n            <td class=\"medium-text\">");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                               Write(SharedLocalizer.GetLocalizedHtmlString("Facility"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
               Write(ViewData["Plant"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
           Write(Html.DropDownList("FaId", (SelectList)ViewBag.ddlPlantVB, new { @class ="medium-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n    </table>\r\n    <tr>\r\n        <input type=\"hidden\" name=\"panel\" value=\"5\"/>\r\n        <input type=\"hidden\" name=\"Filter\" value=\"2\"/>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("FilterByCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value =\"", 1199, "\"", 1218, 1);
#nullable restore
#line 38 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
WriteAttributeValue("", 1208, fValue(1), 1208, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"norm-text\" id=\"pNam\" name=\"pNam\" type=\"text\"></input></td>\r\n        <td> ");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
        Write(SharedLocalizer.GetLocalizedHtmlString("FilterByDesc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value=\"", 1399, "\"", 1417, 1);
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
WriteAttributeValue("", 1407, fValue(2), 1407, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class =\"norm-text\" id=\"pNam1\" name=\"pNam1\" type=\"text\"></input></td>\r\n        <td><input type=\"submit\" value=\"Filter\"  name=\"actionType\"/></td>\r\n        <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n   <table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h2>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("LocationsData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("LocCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 54 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("LocDescr"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                \r\n        <th class=\"head-text\">");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("LocType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 58 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
     foreach (var c in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                             Write(c.LocCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                             Write(c.LocDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                              Write(c.LocType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 63 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                            Write(Html.ActionLink("Delete", "LoDelete", new { id = c.LocId}, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
                            Write(Html.ActionLink("Edit", "LoEdit", new { id = c.LocId ,panel=5}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
Write(Html.ActionLink("Add a New Item", "LoCreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<");
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\_pListaStorages_all.cshtml"
           
    string fValue (int valor){
        string ret1="";
        if (valor ==1){
        try{
            ret1 = (string)ViewData["Fil1"];
        }
        catch{}
        }
        else{
        try{
            ret1 = (string)ViewData["Fil2"];
        }
        catch{}
        }
        return ret1;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TLocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
