#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc1b3c81bf3d123d2298ef70f9d2a60e08e1170f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_MatBom), @"mvc.1.0.view", @"/Views/TEngine/MatBom.cshtml")]
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
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1b3c81bf3d123d2298ef70f9d2a60e08e1170f", @"/Views/TEngine/MatBom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_MatBom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
Write(Html.Partial("_pmenuMat_com"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
Write(Html.Partial("_pshowMaterials_parc_com",(TMaterial)ViewBag.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"Visible\">\r\n");
            WriteLiteral("\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("B.O.M."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
                                                                                    Write(Model.MatDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
           Write(Html.dataGrid(28,9,@Columns("MatBom",0),@getData_MatBom((List<TExplosionB>)ViewBag.ListMatBom),@Controller("MatBom"),@Columns("MatBom",1),Model.MatId,"",false,false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n\r\n\r\n");
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 106 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
                                          
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatBom.cshtml"
            
    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "MatBom":
                retur[0]="TEngine";
                retur[1]="";        //No edit MatEdit
                retur[2]="";        //No create
                retur[3]="";        //no delete
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
            case "MatBom":
                if (type==0)
                {
                    retur.Add("MatBom");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Level"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Refer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Decsr<"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Coef"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UM"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Fase"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Oper"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Time"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UnitT"));
                }
                else{
                    retur.Add("ExpId");
                    retur.Add("ExpsLevel");
                    retur.Add("ExpRefer");
                    retur.Add("ExpDescr");
                    retur.Add("ExpCoef");
                    retur.Add("ExpUm");
                    retur.Add("ExpRouFase");
                    retur.Add("ExpRouOper");
                    retur.Add("ExpRouTime");
                    retur.Add("ExpRouTunit");
                }
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_MatBom(dynamic oTMaterial)
        {
            IEnumerable<TExplosionB> fTPersonal = (List<TExplosionB>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.ExpId,
                        Campo01 = f.ExpsLevel.ToString(),
                        Campo02 = f.ExpRefer.ToString(),
                        Campo03 = f.ExpDescr.ToString(),
                        Campo04 = f.ExpCoef.ToString(),
                        Campo05 = f.ExpUm.ToString(),
                        Campo06 = f.ExpRouFase.ToString(),
                        Campo07 = f.ExpRouOper.ToString(),
                        Campo08 = f.ExpRouTime.ToString(),
                        Campo09 = f.ExpRouTunit.ToString(),
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
