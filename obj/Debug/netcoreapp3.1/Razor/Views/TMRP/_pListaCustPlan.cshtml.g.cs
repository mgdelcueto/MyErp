#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9033fa46b0b44517f5d1b258f8f4b768a1f472d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TMRP__pListaCustPlan), @"mvc.1.0.view", @"/Views/TMRP/_pListaCustPlan.cshtml")]
namespace AspNetCore
{
    #line hidden
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
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9033fa46b0b44517f5d1b258f8f4b768a1f472d", @"/Views/TMRP/_pListaCustPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TMRP__pListaCustPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VCXplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("}\r\n");
#nullable restore
#line 299 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 301 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n");
#nullable restore
#line 303 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
      
        try{
        Model.CplanDateFrom=getDate(1);
        Model.CplanDateTo=getDate(2);
        Model.CPlancStock=getACSt();}
        catch{}
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    <table class=\"table-edit\">\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 314 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 315 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new {  @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 316 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 317 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new {  @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-lab-text\">");
#nullable restore
#line 318 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                                 Write(SharedLocalizer.GetLocalizedHtmlString("AccountStocks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 319 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.CheckBoxFor( p => p.CPlancStock,true ));

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
#line 327 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 330 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 12477, "", 12497, 1);
#nullable restore
#line 335 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 12484, isVisible(1), 12484, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 338 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("PlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 340 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(35,12,@Columns("CustPlan",0),@getData_CustPlan((List<VCCplanning>)ViewBag.ListCustPlan),@Controller("CustPlan"),@Columns("CustPlan",1),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 12812, "", 12832, 1);
#nullable restore
#line 343 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 12819, isVisible(2), 12819, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 347 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("MaterialRequirement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 349 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(36,12,@Columns("MatReq",0),@getData_MatReq((List<TExpMater>)ViewBag.ListMatExp),@Controller("MatReq"),@Columns("MatReq",1),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 13142, "", 13162, 1);
#nullable restore
#line 351 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 13149, isVisible(3), 13149, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 355 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterLoad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 357 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(37,12,@Columns("WCCap",0),@getData_WCCap((List<TExpOper>)ViewBag.ListOpeExp),@Controller("WCCap"),@Columns("WCCap",1),0,"",true,true,"",@sModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 13488, "", 13508, 1);
#nullable restore
#line 359 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 13495, isVisible(4), 13495, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 363 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterLoad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 365 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(38,12,@Columns("WCDet",0),@getData_WCDet((List<TExpOperd>)ViewBag.ListOpeDet),@Controller("WCDet"),@Columns("WCDet",1),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 367 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
            

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
                retur[1]="CapDetwc";  //Edit
                retur[2]="";  //Create
                retur[3]="";  //Delete
                break;
        case "WCDet":
                retur[0]="TMRP";
                retur[1]="";  //Edit
                retur[2]="";  //Create
                retur[3]="";  //Delete
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
            case "WCDet":
                if (type==0)
                {
                    retur.Add("WCCap");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("expcomp"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("matunmed"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("TTime"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("rouwcid"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("matrefer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("matdescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("roufase"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("rouoper"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("TTimes"));
                }
                else{
                    retur.Add("RouWcId");
                    retur.Add("expcomp");
                    retur.Add("Qty");
                    retur.Add("matunmed");
                    retur.Add("TTime");
                    retur.Add("rouwcid");
                    retur.Add("matrefer");
                    retur.Add("matdescr");
                    retur.Add("roufase");
                    retur.Add("rouoper");
                    retur.Add("TTimes");
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

    IEnumerable<Container> getData_WCDet(dynamic oTMaterial)
        {
            IEnumerable<TExpOperd> fTPersonal = (List<TExpOperd>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = 0,
                        Campo01 = f.expcomp.ToString(),
                        Campo02 = f.Qty.ToString(),
                        Campo03 = f.matunmed.ToString(),
                        Campo04 = f.TTime.ToString(),
                        Campo05 = f.rouwcid.ToString(),
                        Campo06 = f.matrefer.ToString(), 
                        Campo07 = f.matdescr.ToString(),
                        Campo08 = f.roufase.ToString(),
                        Campo09 = f.rouoper.ToString(),
                        Campo10 = f.TTimes.ToString(),
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

    bool IntBool(int? value)
    {
        bool ret = true;
        if (value ==0||value == null){ret = false;}
        return ret;
    }
    bool getACSt()
    {
        bool ret = false;
        try{
            ret=Convert.ToBoolean(ViewData["ACSt"]);
        }
        catch{}
        return ret;
    }
    string sModel()
    {
        string ret ="";
        try{
        ret ="F1=\"";
        ret+=getDate(1).ToString();
        ret+="\"&F2=\"";
        ret+=getDate(2).ToString();
        ret+="\"&accStock=\"";
        ret+=getACSt().ToString();
        ret+="\"";}
        catch{}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VCXplanning> Html { get; private set; }
    }
}
#pragma warning restore 1591
