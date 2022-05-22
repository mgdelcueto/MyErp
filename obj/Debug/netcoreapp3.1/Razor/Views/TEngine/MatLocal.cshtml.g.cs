#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c291d5b36b995a7d32ea1b59f8de0771b5dcf79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_MatLocal), @"mvc.1.0.view", @"/Views/TEngine/MatLocal.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c291d5b36b995a7d32ea1b59f8de0771b5dcf79", @"/Views/TEngine/MatLocal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_MatLocal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
Write(Html.Partial("_pmenuMat_com"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
Write(Html.Partial("_pshowMaterials_parc_com",(TMaterial)ViewBag.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"Visible\">\r\n");
            WriteLiteral("\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("ComponentsOf"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
                                                                                          Write(Model.MatDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
           Write(Html.dataGrid(31,9,@Columns("MatLocal",0),@getData_MatLocal((List<VTMLocation>)ViewBag.ListMatLoca),@Controller("MatLocal"),@Columns("MatLocal",1),Model.MatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n");
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
                                          
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatLocal.cshtml"
            
    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "MatLocal":
                retur[0]="TEngine";
                retur[1]="LMatEdit";
                retur[2]="LMatCreate";
                retur[3]="LMatDelete";
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
            case "MatLocal":
                if (type==0)
                {

                    retur.Add("MatRoute");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Code"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Stock"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UMed"));
                }
                else{
                    retur.Add("LoLoId");
                    retur.Add("LoLocCode");
                    retur.Add("LoLocDescr");
                    retur.Add("LoRefSt");
                    retur.Add("LoRefUM");
                }
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_MatLocal(dynamic oTMaterial)
        {
            IEnumerable<VTMLocation> fTPersonal = (List<VTMLocation>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.LoLoId,
                        Campo01 = f.LoLocCode.ToString(),
                        Campo02 = f.LoLocDescr.ToString(),
                        Campo03 = f.LoRefSt.ToString(),
                        Campo04 = f.LoRefUM.ToString(),
                        Campo05 = "",
                        Campo06 = "",
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
