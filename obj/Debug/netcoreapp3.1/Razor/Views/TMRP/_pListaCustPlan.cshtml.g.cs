#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6f02d5a400947e8ccd569956120c975037c6bd"
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
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6f02d5a400947e8ccd569956120c975037c6bd", @"/Views/TMRP/_pListaCustPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TMRP__pListaCustPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VCXplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 491 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 493 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n");
#nullable restore
#line 495 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
      
        try{
        Model.CplanDateFrom=getDate(1);
        Model.CplanDateTo=getDate(2);
        Model.CPlancStock=getACSt();}
        //Model.wcent=getWCent();
        catch{}
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    <table class=\"table-edit\">\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 507 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 508 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new {  @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 509 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 510 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new {  @class = "norm-tb-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-lab-text\">");
#nullable restore
#line 511 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                                 Write(SharedLocalizer.GetLocalizedHtmlString("AccountStocks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 512 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.CheckBoxFor( p => p.CPlancStock,true ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Go\"  name=\"actionType\"/></td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <input type=\"hidden\" value=\"2\"  name=\"panel1\"/>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=", 20588, "", 20605, 1);
#nullable restore
#line 518 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 20595, getWCen(), 20595, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  name=\"wcent\"/>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=", 20659, "", 20675, 1);
#nullable restore
#line 519 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 20666, getMat(), 20666, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  name=\"material\"/>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 522 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 525 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 20957, "", 20977, 1);
#nullable restore
#line 530 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 20964, isVisible(1), 20964, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 533 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("PlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 535 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(39,12,@Columns("CustPlan"),@getData_CustPlan((List<VCCplanning>)ViewBag.ListCustPlan),@Controller("CustPlan"),@Fields("CustPlan"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 21287, "", 21307, 1);
#nullable restore
#line 538 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 21294, isVisible(2), 21294, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 542 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("MaterialRequirement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class = \"", 21467, "\"", 21492, 1);
#nullable restore
#line 544 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 21477, isVisibleReq(), 21477, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <table class=\"table-edit\">\r\n                 <tr>\r\n                    <td><input type=\"submit\" class=\"dropbtn\" value=\"Validate\"  name=\"actionType\"/></td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n        ");
#nullable restore
#line 551 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(40,12,@Columns("MatReq"),@getData_MatReq((List<TExpMater>)ViewBag.ListMatExp),@Controller("MatReq"),@Fields("MatReq"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 21882, "", 21902, 1);
#nullable restore
#line 553 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 21889, isVisible(3), 21889, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 557 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterLoad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 559 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(41,12,@Columns("WCCap"),@getData_WCCap((List<TExpOper>)ViewBag.ListOpeExp),@Controller("WCCap"),@Fields("WCCap"),0,"",true,true,"",@sModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 22223, "", 22243, 1);
#nullable restore
#line 561 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 22230, isVisible(4), 22230, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 565 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterLoad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        <h5 class=\"myh4\">");
#nullable restore
#line 567 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                    Write(SharedLocalizer.GetLocalizedHtmlString("WCentDetLoad"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 567 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                                                                            Write(WCentName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 568 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(42,12,@Columns("WCDet"),@getData_WCDet((List<TExpOperd>)ViewBag.ListOpeDet),@Controller("WCDet"),@Fields("WCDet"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 22641, "", 22661, 1);
#nullable restore
#line 571 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 22648, isVisible(5), 22648, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 575 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("MatPOrders"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        <h5 class=\"myh4\">");
#nullable restore
#line 577 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                    Write(SharedLocalizer.GetLocalizedHtmlString("MaterialPO"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 577 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                                                                          Write(MaterData());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 578 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(43,12,@Columns("MatPO"),@getData_MatPO((List<TExpMatd>)ViewBag.ListMatPO),@Controller("MatPO"),@Fields("MatPO"),0,"",true,true,"",@sModel(),true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 23082, "", 23102, 1);
#nullable restore
#line 581 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 23089, isVisible(6), 23089, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 582 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
          
            var service = Context.RequestServices.GetService(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment)) as Microsoft.AspNetCore.Hosting.IHostingEnvironment;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 587 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("GanttChar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n");
            WriteLiteral("       <input type=\"submit\" class=\"dropbtn\" value=\"Refresh\" name=\"actionType\"");
            BeginWriteAttribute("onclick", " onclick=\"", 23632, "\"", 23697, 3);
            WriteAttributeValue("", 23642, "location.href=\'", 23642, 15, true);
#nullable restore
#line 592 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 23657, Url.Action("ExecPythonScript", "TMRP"), 23657, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 23696, "\'", 23696, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />  \r\n       ");
#nullable restore
#line 593 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
  Write(Html.Raw(File.ReadAllText(@service.WebRootPath+"/images/"+getUserFig())));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=", 23809, "", 23829, 1);
#nullable restore
#line 596 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 23816, isVisible(7), 23816, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 600 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("SchedTable"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        <h5 class=\"myh4\">");
#nullable restore
#line 602 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                    Write(SharedLocalizer.GetLocalizedHtmlString("MaterialPO"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 602 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                                                                          Write(MaterData());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 603 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
   Write(Html.dataGrid(44,12,@Columns("SchedT"),@getData_SchedT((List<TCTimeRule>)ViewBag.ListTRul),@Controller("SchedT"),@Fields("SchedT"),0,"",true,true,"",@sModel(),true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 605 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
            

    private string getUserName()
    {
        var name = Context.User.Claims.FirstOrDefault(
                x => x.Type == "UserName")?.Value; //FullName
        return name;
    }
    private string getUserFig()
    {
        var service = Context.RequestServices.GetService(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment)) as Microsoft.AspNetCore.Hosting.IHostingEnvironment;
        var ret ="_FiGantt"+getUserName().Trim();
        var file =@service.WebRootPath+"/images/"+ret;
        if (! File.Exists(file)) {
           ret="figure0.html";
        }        
        return ret;
    }

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
                retur[1]="CapDetma";
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
        case "MatPO":
                retur[0]="TSuplier";
                retur[1]="PoEdit";  //Edit
                retur[2]="";  //Create
                retur[3]="";  //Delete
                break;
        case "SchedT":
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
            case "CustPlan":
                retur.Add(addLine("CplanId","false"));
                retur.Add(addLine("CplanCustCode","false"));
                retur.Add(addLine("CplanCplantCode","false"));
                retur.Add(addLine("CplanCprodRefInt","false"));
                retur.Add(addLine("CplanCprodDescInt","false"));
                retur.Add(addLine("CplanDateFrom","false"));
                retur.Add(addLine("CplanDateTo","false"));
                retur.Add(addLine("CplanQty","false"));
                break;
            case "MatReq":
                retur.Add(addLine("WcdId","false"));
                retur.Add(addLine("MatRefer","false"));
                retur.Add(addLine("MatDescr","true"));
                retur.Add(addLine("TcomQty","false"));
                retur.Add(addLine("MatUnMed","false"));
                retur.Add(addLine("TCom","false"));
                break;
            case "WCCap":
                retur.Add(addLine("RouWcId","false"));
                retur.Add(addLine("Wccode","false"));
                retur.Add(addLine("Wcdescr","true"));
                retur.Add(addLine("OperTime","false"));
                break;
            case "WCDet":
                retur.Add(addLine("RouWcId","false"));
                retur.Add(addLine("expcomp","false"));
                retur.Add(addLine("matrefer","false"));
                retur.Add(addLine("matdescr","false"));
                retur.Add(addLine("roufase","false"));
                retur.Add(addLine("rouoper","false"));
                retur.Add(addLine("TTimes","false"));
                retur.Add(addLine("Qty","false"));
                retur.Add(addLine("matunmed","false"));
                retur.Add(addLine("TTime","false"));
                retur.Add(addLine("rouwcid","false"));
                break;
            case "MatPO":
                retur.Add(addLine("SPoId","false"));
                retur.Add(addLine("SupRaSoc","false"));
                retur.Add(addLine("matrefer","false"));
                retur.Add(addLine("SPOReferEx","false"));
                retur.Add(addLine("matdescr","false"));
                retur.Add(addLine("SPOPO","false"));
                retur.Add(addLine("SpoPcRep","true"));
                retur.Add(addLine("SPoPcRequ","false"));
                break;
            case "SchedT":
                retur.Add(addLine("ShopId","false"));
                retur.Add(addLine("Wccode","false"));
                retur.Add(addLine("Wcdescr","false"));
                retur.Add(addLine("MatRefer","false"));
                retur.Add(addLine("MatDescr","false"));
                retur.Add(addLine("ShopDate","false"));
                retur.Add(addLine("ShopTunit","false"));
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
            case "CustPlan":
                    retur.Add("CustPlan");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("CustCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("PlantCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DescInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DateFrom"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DateTo"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                break;
            case "MatReq":
                    retur.Add("MatReq");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatRefer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatDescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("TcomQty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatUnMed"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("TCom"));
                break;
            case "WCCap":
                    retur.Add("WCCap");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCDesc"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("OperTime"));
                break;
            case "WCDet":
                    retur.Add("WCDet");
                    //retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ProdId"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Refer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Fase"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Oper"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Time"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UM"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("TotTime"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WcId"));
                break;
            case "MatPO":
                    retur.Add("MatPO");
                    //retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SPoId"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SupRaSoc"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("matrefer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SPOReferEx"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("matdescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SPOPO"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SPoPcRep"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SPoPcRequ"));
                break;
            case "SchedT":
                    retur.Add("SchedT");
                    //retur.Add(@SharedLocalizer.GetLocalizedHtmlString("SPoId"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Wccode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Wcdescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatRefer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatDescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ShopDate"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ShopTunit"));
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
                        CampoId = f.ExpComp,
                        Campo01 = f.MatRefer.ToString(),
                        Campo02 = f.MatDescr.ToString(),
                        Campo03 = f.TComQty.ToString(),
                        Campo04 = f.MatUnMed.ToString(),
                        Campo05 = f.TCom.ToString(),
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
                        CampoId = f.expcomp,
                        Campo01 = f.matrefer.ToString(), 
                        Campo02 = f.matdescr.ToString(),
                        Campo03 = f.roufase.ToString(),
                        Campo04 = f.rouoper.ToString(),
                        Campo05 = f.TTimes.ToString(),
                        Campo06 = f.Qty.ToString(),
                        Campo07 = f.matunmed.ToString(),
                        Campo08 = f.TTime.ToString(),
                        Campo09 = f.rouwcid.ToString(),
                        Campo10 = "",
                        Campo11 = "",
                        Campo12 = "",
                        Campo13 = "",
                        Campo14 = "",
                        Campo15 = ""
                });
            return TPersonal;
        }

    IEnumerable<Container> getData_MatPO(dynamic oTMaterial)
        {
            IEnumerable<TExpMatd> fTPersonal = (List<TExpMatd>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.SPoId,
                        Campo01 = f.SupRaSoc.ToString(),
                        Campo02 = f.matrefer.ToString(), 
                        Campo03 = f.SPOReferEx.ToString(),
                        Campo04 = f.matdescr.ToString(),
                        Campo05 = f.SPOPO.ToString(),
                        Campo06 = f.SPoPcRep.ToString(),
                        Campo07 = f.SPoPcRequ.ToString(),
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
    IEnumerable<Container> getData_SchedT(dynamic oTMaterial)
        {
            IEnumerable<TCTimeRule> fTPersonal = (List<TCTimeRule>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.ShopId,
                        Campo01 = f.Wccode.ToString(),
                        Campo02 = f.Wcdescr.ToString(), 
                        Campo03 = f.MatRefer.ToString(),
                        Campo04 = f.MatDescr.ToString(),
                        Campo05 = f.ShopDate.ToString(),
                        Campo06 = f.ShopTunit.ToString(),
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


    string isVisibleReq()
    {
        string ret = "invisible";
        try{
            List<TExpMater>  mode_=(List<TExpMater>)ViewBag.ListMatExp;
            var maxTCo = mode_.Max(p => p.TCom);
            var minTCo = mode_.Min(p => p.TCom);
            if (maxTCo==1 && minTCo==1){ret="visible";}
            }
        catch{}
        return ret;
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
    string getWCen()
    {
        string ret ="0";
        try{
            ret=Convert.ToString(ViewData["WCen"]);
        }
        catch{}
        return ret;
    }
    string getMat()
    {
        string ret ="0";
        try{
            ret=Convert.ToString(ViewData["MatPO"]);
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
    string WCentName()
    {
        string ret = "";
        try{
            int id = Convert.ToInt32(ViewData["WCent"].ToString());
            var xdbContext = new MyErpDBContext();
            var model_ = xdbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(id));
            ret=model_.Wcdescr;
            }
        catch{}
        return ret;
    }

    string MaterData()
    {
        string ret = "";
        try{
            int id = Convert.ToInt32(ViewData["MatPO"].ToString());
            var xdbContext = new MyErpDBContext();
            var model_ = xdbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            List<TExpMater>  mode_=(List<TExpMater>)ViewBag.ListMatExp;
            var myreg = mode_.Where(p => p.ExpComp.Equals(id)).ElementAt(0);
            //var myreg=mode_.SingleOrDefault(u => u.ExpComp.Equals(id));
            ret=model_.MatDescr+" " +@SharedLocalizer.GetLocalizedHtmlString("NeedsQty")+" "+myreg.TComQty.ToString()+" "+myreg.MatUnMed;
            }
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
