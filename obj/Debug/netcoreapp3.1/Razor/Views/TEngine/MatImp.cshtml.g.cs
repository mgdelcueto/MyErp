#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd66c52365c6611d64c7dee1ce0a4c7264ab1fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_MatImp), @"mvc.1.0.view", @"/Views/TEngine/MatImp.cshtml")]
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
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd66c52365c6611d64c7dee1ce0a4c7264ab1fc", @"/Views/TEngine/MatImp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_MatImp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\" clearfix position-relative o_form_sheet center\">\r\n\r\n");
#nullable restore
#line 102 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
Write(Html.Partial("_pmenuMat_com"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 103 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
Write(Html.Partial("_pshowMaterials_parc_com",(TMaterial)ViewBag.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"Visible\">\r\n");
            WriteLiteral("\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 111 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Implosio_BOM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 111 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
                                                                                          Write(Model.MatDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 114 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
           Write(Html.dataGrid(29,9,@Columns("MatImp"),@getData_MatImp((List<TExplosionB>)ViewBag.ListMatImp),@Controller("MatImp"),@Fields("MatImp"),Model.MatId,"",false,false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n\r\n\r\n");
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 122 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
                                          
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\MatImp.cshtml"
            
    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "MatImp":
                retur[0]="TEngine";
                retur[1]="MatEdit";        //No edit MatEdit
                retur[2]="";        //No create
                retur[3]="";        //no delete
                break;
        default:
            break;
        }
        return retur;
    }
    List<string> addLine(string field, string ledit){
        List<string> retLin = new List<string>();
        retLin.Add(field);
        retLin.Add(ledit);
        return retLin;
    }
    List<List<string>>  Fields(string table){
        List<List<string>> retur = new List<List<string>>();
        switch (table)
        {
            case "MatImp":
                retur.Add(addLine("ExpId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("ExpsLevel","false"));
                retur.Add(addLine("ExpRefer","false"));
                retur.Add(addLine("ExpDescr","true"));
                retur.Add(addLine("ExpCoef","false"));
                retur.Add(addLine("ExpUm","false"));
                retur.Add(addLine("ExpRouFase","false"));
                retur.Add(addLine("ExpRouOper","false"));
                retur.Add(addLine("ExpRouTime","false"));
                retur.Add(addLine("ExpRouTunit","false"));
                break;
            default:
                break;
        }
        return retur;
    }
    List<string> Columns(string table){
        List<string> retur = new List<string>();
        switch (table)
        {
            case "MatImp":
                    retur.Add("MatImp");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Level"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Refer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Decsr<"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Coef"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UM"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Fase"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Oper"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Time"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UnitT"));
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_MatImp(dynamic oTMaterial)
        {
            IEnumerable<TExplosionB> fTPersonal = (List<TExplosionB>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.ExpId,
                        CampoKy = f.ExpComp,
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
