#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c59e4d033309e963047777165c7d39024c76c83a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_CharEdit), @"mvc.1.0.view", @"/Views/TOrganiza/CharEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59e4d033309e963047777165c7d39024c76c83a", @"/Views/TOrganiza/CharEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_CharEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TChart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n\r\n<div class=\" clearfix position-relative o_form_sheet center\">\r\n\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 129 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EdChart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 131 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 133 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
Write(Html.HiddenFor(p => p.CharId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 134 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table-edit"" >
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel"" name=""actionType""/></td>
        </tr>
        ");
#nullable restore
#line 140 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
   Write(Html.Partial("_pshowChart",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n");
            WriteLiteral("<div class=\"visible\">\r\n\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <div class=\"style-data\">\r\n            <h3>");
#nullable restore
#line 149 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("ChartUsers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"visible\">");
            WriteLiteral("   \r\n            <table>\r\n                <tr>\r\n                    <td class=\"norm-lab-text\">");
#nullable restore
#line 154 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
                                         Write(SharedLocalizer.GetLocalizedHtmlString("SelEmploytoChart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"norm-text\">\r\n                        ");
#nullable restore
#line 157 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
                   Write(Html.DropDownList("PerId", (SelectList)ViewBag.ddlPerso, new { @class ="norm-tb-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n\r\n");
            WriteLiteral("        ");
#nullable restore
#line 164 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
   Write(Html.dataGrid(22,9,@Columns("UserChar"),@getData_UserChar((List<VTChartRol>)ViewBag.ListCharRol),@Controller("UserChar"),@Fields("UserChar"),0,@parqsaction()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 168 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\CharEdit.cshtml"
            

    string parqsaction()
    {
        //deja el ultimo parametroa rellenar con el Id de la tabla en el javascript del control grid
        string ret ="/"+Model.CharId.ToString()+"?wrem=";
        return ret;
    }
    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "UserChar":
                retur[0]="TOrganiza";
                retur[1]="";            //Edit not enabled
                retur[2]="";            //Create not enabled
                retur[3]="CharEdit";     //delete is remove
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
            case "UserChar":
                retur.Add(addLine("RcharId","false"));
                retur.Add(addLine("RcharRolId","false"));
                retur.Add(addLine("RcharPerName","false"));
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
            case "UserChar":
                    retur.Add("UserChar");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Id"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Name"));
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_UserChar(dynamic oTMaterial)
        {
            IEnumerable<VTChartRol> fTPersonal = (List<VTChartRol>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.RcharId,
                        Campo01 = f.RcharRolId.ToString(),
                        Campo02 = f.RcharPerName.ToString(),
                        Campo03 = "",
                        Campo04 = "",
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



    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
        return retcol;
    }
string assVisible(int mPanel)
{
    string retcol="invisible";
    try{
    if ((int)ViewData["Assign"]==mPanel)
    {retcol="visible";}
    }
    catch{}
    return retcol;
 }
private int VAssign(int mPanel){
    int resul = 1;
    try{
    if ((int)ViewData["Assign"]==mPanel)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TChart> Html { get; private set; }
    }
}
#pragma warning restore 1591
