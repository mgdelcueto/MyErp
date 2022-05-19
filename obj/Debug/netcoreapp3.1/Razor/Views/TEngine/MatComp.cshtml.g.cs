#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a146ec0e9387e1b43403b7fdbb432fcb5596a87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_MatComp), @"mvc.1.0.view", @"/Views/TEngine/MatComp.cshtml")]
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
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a146ec0e9387e1b43403b7fdbb432fcb5596a87", @"/Views/TEngine/MatComp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_MatComp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 83 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("MatEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 87 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
Write(Html.HiddenFor(p => p.MatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    ");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-edit\">\r\n        <tr>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Cancel\" name=\"actionType\"/></td>\r\n            <td></td>\r\n        </tr>\r\n        ");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
   Write(Html.Partial("_pshowMaterials_parc",(TMaterial)ViewBag.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n    <div class=\"Visible\">\r\n");
            WriteLiteral("\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 104 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("ComponentsOf"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 104 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
                                                                                          Write(Model.MatDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 107 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
           Write(Html.dataGrid(27,9,@Columns("MatComp",0),@getData_MatComp((List<VTMComponent>)ViewBag.ListMatComp),@Controller("MatComp"),@Columns("MatComp",1),Model.MatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n");
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 113 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
                                          
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatComp.cshtml"
            
    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "MatComp":
                retur[0]="TEngine";
                retur[1]="CMatEdit";
                retur[2]="CMatCreate";
                retur[3]="CMatDelete";
                break;
        default:
            break;
        }
        return retur;
    }
    List<string> Columns(string table,int type){
        List<string> retur = new List<string>();
        switch (table)
        {
            case "MatComp":
                if (type==0)
                {
                    retur.Add("MatComp");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Component"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Description"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefQty<"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefUM"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("CompQty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("CompUM"));
                }
                else{
                    retur.Add("CoCoId");
                    retur.Add("CoComRe");
                    retur.Add("CoComDes");
                    retur.Add("CoRefQt");
                    retur.Add("CoRefUM");
                    retur.Add("CoComQt");
                    retur.Add("CoComUM");
                }
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_MatComp(dynamic oTMaterial)
        {
            IEnumerable<VTMComponent> fTPersonal = (List<VTMComponent>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.CoCoId,
                        Campo01 = f.CoComRe.ToString(),
                        Campo02 = f.CoComDes.ToString(),
                        Campo03 = f.CoRefQt.ToString(),
                        Campo04 = f.CoRefUM.ToString(),
                        Campo05 = f.CoComQt.ToString(),
                        Campo06 = f.CoComUM.ToString(),
                        Campo07 = "",
                        Campo08 = "",
                        Campo09 = "",
                        Campo10 = "",
                        Campo11 = "",
                        Campo12 = "",
                        Campo13 = "",
                        Campo14 = "",
                        Campo15 = ""
                });
            return TPersonal;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TMaterial> Html { get; private set; }
    }
}
#pragma warning restore 1591
