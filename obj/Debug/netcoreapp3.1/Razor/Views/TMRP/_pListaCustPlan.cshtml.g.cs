#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97478590bbc3dded558e0a57a3e085802fea869a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TMRP__pListaCustPlan), @"mvc.1.0.view", @"/Views/TMRP/_pListaCustPlan.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97478590bbc3dded558e0a57a3e085802fea869a", @"/Views/TMRP/_pListaCustPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TMRP__pListaCustPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VCCplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<!-- Show planing records -->\r\n");
#nullable restore
#line 209 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 211 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n");
#nullable restore
#line 213 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
      
        try{
        Model.CplanDateFrom=getDate(1);
        Model.CplanDateTo=getDate(2);}
        catch{}
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    <table class=\"table-edit\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 222 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 223 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new {  @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 224 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 225 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new {  @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            <td><input type=""submit"" class=""dropbtn"" value=""Go""  name=""actionType""/></td>
        </tr>
        <tr>
            <td>
                <input type=""hidden"" value=""2""  name=""panel1""/>
            </td>
            <td>
                ");
#nullable restore
#line 233 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 236 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 239 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 8737, "", 8757, 1);
#nullable restore
#line 240 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 8744, isVisible(1), 8744, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 243 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("PlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 245 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(35,12,@Columns("CustPlan",0),@getData_CustPlan((List<VCCplanning>)ViewBag.ListCustPlan),@Controller("CustPlan"),@Columns("CustPlan",1),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("</div>\r\n\r\n<!--Show Capacity results-->\r\n\r\n<div");
            BeginWriteAttribute("class", " class=", 10814, "", 10834, 1);
#nullable restore
#line 283 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 10821, isVisible(2), 10821, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 287 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("MaterialRequirement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n");
            WriteLiteral("        ");
#nullable restore
#line 290 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(36,12,@Columns("MatReq",0),@getData_MatReq((List<TExpMater>)ViewBag.ListMatExp),@Controller("MatReq"),@Columns("MatReq",1),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 12526, "", 12546, 1);
#nullable restore
#line 330 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 12533, isVisible(3), 12533, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 334 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterLoad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n");
            WriteLiteral("        ");
#nullable restore
#line 337 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(37,12,@Columns("WCCap",0),@getData_WCCap((List<TExpOper>)ViewBag.ListOpeExp),@Controller("WCCap"),@Columns("WCCap",1),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
            

    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "CustPlan":
                retur[0]="TMRP";
                retur[1]="";
                retur[2]="";
                retur[3]="";
                break;
        case "MatReq":
                retur[0]="TMRP";
                retur[1]="";
                retur[2]="";
                retur[3]="";
                break;
        case "WCCap":
                retur[0]="TMRP";
                retur[1]="";
                retur[2]="";
                retur[3]="";
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
            case "CustPlan":
                if (type==0)
                {
                    retur.Add("CustPlan");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("CustCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("PlantCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DescInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DateFrom"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DateTo"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                }
                else{
                    retur.Add("CplanId");
                    retur.Add("CplanCustCode");
                    retur.Add("CplanCplantCode");
                    retur.Add("CplanCprodRefInt");
                    retur.Add("CplanCprodDescInt");
                    retur.Add("CplanDateFrom");
                    retur.Add("CplanDateTo");
                    retur.Add("CplanQty");
                }
                break;
            case "MatReq":
                if (type==0)
                {
                    retur.Add("MatReq");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatRefer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatDescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("TcomQty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatUnMed"));
                }
                else{
                    retur.Add("WcdId");
                    retur.Add("MatRefer");
                    retur.Add("MatDescr");
                    retur.Add("TcomQty");
                    retur.Add("MatUnMed");
                }
                break;
            case "WCCap":
                if (type==0)
                {
                    retur.Add("WCCap");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCDesc"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("OperTime"));
                }
                else{
                    retur.Add("RouWcId");
                    retur.Add("Wccode");
                    retur.Add("Wcdescr");
                    retur.Add("OperTime");
                }
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_CustPlan(dynamic oTMaterial)
        {
            IEnumerable<VCCplanning> fTPersonal = (List<VCCplanning>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.CplanId,
                        Campo01 = f.CplanCustCode.ToString(),
                        Campo02 = f.CplanCplantCode.ToString(),
                        Campo03 = f.CplanCprodRefInt.ToString(),
                        Campo04 = f.CplanCprodDescInt.ToString(),
                        Campo05 = f.CplanDateFrom.ToString(),
                        Campo06 = f.CplanDateTo.ToString(), 
                        Campo07 = f.CplanQty.ToString(),
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

    IEnumerable<Container> getData_MatReq(dynamic oTMaterial)
        {
            IEnumerable<TExpMater> fTPersonal = (List<TExpMater>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = 0,
                        Campo01 = f.MatRefer.ToString(),
                        Campo02 = f.MatDescr.ToString(),
                        Campo03 = f.TcomQty.ToString(),
                        Campo04 = f.MatUnMed.ToString(),
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

    IEnumerable<Container> getData_WCCap(dynamic oTMaterial)
        {
            IEnumerable<TExpOper> fTPersonal = (List<TExpOper>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.RouWcId,
                        Campo01 = f.Wccode.ToString(),
                        Campo02 = f.Wcdescr.ToString(),
                        Campo03 = f.OperTime.ToString(),
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
    DateTime getDate(int date)
    {
        System.DateTime ret = System.DateTime.Now;
        if (date==1){
            try{
                ret = Convert.ToDateTime(ViewData["F1"].ToString());
            }
            catch{}
        }
        if (date==2){
            try{
                ret = Convert.ToDateTime(ViewData["F2"].ToString());
            }
            catch{}
        }
        return ret;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VCCplanning> Html { get; private set; }
    }
}
#pragma warning restore 1591
