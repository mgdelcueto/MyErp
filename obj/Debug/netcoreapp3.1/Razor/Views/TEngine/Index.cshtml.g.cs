#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38a3d6c08f46a53f0966e6ebb0a83a2120cc8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TEngine_Index), @"mvc.1.0.view", @"/Views/TEngine/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38a3d6c08f46a53f0966e6ebb0a83a2120cc8a4", @"/Views/TEngine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TEngine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <!--Facilities-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 15309, "", 15329, 1);
#nullable restore
#line 442 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 15316, isVisible(1), 15316, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 444 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("FacilitiesList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 446 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(10,16,@Columns("Facility"),@getData_Facility((List<TFacility>)ViewBag.ListFA),@Controller("Facility"),@Fields("Facility"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Work Centers-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 15744, "", 15764, 1);
#nullable restore
#line 451 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 15751, isVisible(2), 15751, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 453 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 455 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(11,16,@Columns("WCenter"),@getData_WCenter((List<TWorkCenter>)ViewBag.ListProd),@Controller("WCenter"),@Fields("WCenter"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Work Centers Components-->\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=", 16197, "", 16217, 1);
#nullable restore
#line 461 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 16204, isVisible(3), 16204, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 479 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("WorkCenterCompList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n    <table>\r\n            <td class=\"norm-lab-text\">");
#nullable restore
#line 482 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
                                 Write(SharedLocalizer.GetLocalizedHtmlString("SelectWorkCenter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 484 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(Html.DropDownList("WcdId", (SelectList)ViewBag.ddlReferVD, new { @class ="norm-tb-text" , onchange = "ddlfunc(3,'WcdId',this.value)"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n    </table>\r\n \r\n        ");
#nullable restore
#line 488 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(12,16,@Columns("WCenterC"),@getData_WCenterC((List<TWccomponent>)ViewBag.ListPO),@Controller("WCenterC"),@Fields("WCenterC"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Materials-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 17534, "", 17554, 1);
#nullable restore
#line 493 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 17541, isVisible(4), 17541, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    \r\n\r\n");
            WriteLiteral("        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 513 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("MaterialsList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n    <table>\r\n            <td class=\"norm-lab-text\">");
#nullable restore
#line 516 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
                                 Write(SharedLocalizer.GetLocalizedHtmlString("MaterialClass"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 518 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(Html.DropDownList("Code",
               new SelectList(DataSource.GetMCatlassL(), "Code", "Name",@isCode()),new { @class = "norm-tb-text", onchange = "ddlfunc(4,'code',this.value)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n    </table>\r\n        ");
#nullable restore
#line 522 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(13,16,@Columns("Materials"),@getData_Materials((List<TMaterial>)ViewBag.ListMA),@Controller("Materials"),@Fields("Materials"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Storages-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 18994, "", 19014, 1);
#nullable restore
#line 527 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 19001, isVisible(5), 19001, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 529 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("StorageLocList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 531 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(14,16,@Columns("SLocation"),@getData_SLocation((List<TLocation>)ViewBag.ListLO),@Controller("SLocation"),@Fields("SLocation"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Roles-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 19424, "", 19444, 1);
#nullable restore
#line 536 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 19431, isVisible(6), 19431, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 538 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("OperatorList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 540 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(15,16,@Columns("Operators"),@getData_Operators((List<TOperator>)ViewBag.ListOP),@Controller("Operators"),@Fields("Operators"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Trucks-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 19854, "", 19874, 1);
#nullable restore
#line 545 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 19861, isVisible(7), 19861, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class = \"cont-titles\">\r\n            <h3>");
#nullable restore
#line 547 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("TrucksList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n        </div>\r\n        ");
#nullable restore
#line 549 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
   Write(Html.dataGrid(16,16,@Columns("Trucks"),@getData_Trucks((List<TCTruck>)ViewBag.ListTruck),@Controller("Trucks"),@Fields("Trucks"),0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Error-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 20268, "", 20290, 1);
#nullable restore
#line 554 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
WriteAttributeValue("", 20275, isVisible(999), 20275, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p>\r\n            ERROR:");
#nullable restore
#line 556 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
             Write(errmsg());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TEngine\Index.cshtml"
            
    string isCode(){
        string  code ="";
        try{
        code = (string)ViewData["Code"];}
        catch{}
        return code;
    }


    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "Facility":
                retur[0]="TEngine";
                retur[1]="FacEdit";
                retur[2]="FacCreate";
                retur[3]="FacDelete";
                break;
        case "WCenter":
                retur[0]="TEngine";
                retur[1]="WCeEdit";
                retur[2]="WCeCreate";
                retur[3]="WCeDelete";
                break;
        case "WCenterC":
                retur[0]="TEngine";
                retur[1]="WCoEdit";
                retur[2]="WCoCreate";
                retur[3]="WCoDelete";
                break;
        case "Materials":
                retur[0]="TEngine";
                retur[1]="MatEdit";
                retur[2]="MatCreate";
                retur[3]="MatDelete";
                break;
        case "SLocation":
                retur[0]="TEngine";
                retur[1]="LoEdit";
                retur[2]="LoCreate";
                retur[3]="LoDelete";
                break;
        case "Operators":
                retur[0]="TEngine";
                retur[1]="OphEdit";
                retur[2]="OphCreate";
                retur[3]="OphDelete";
                break;
        case "Trucks":
                retur[0]="TEngine";
                retur[1]="TrEdit";
                retur[2]="TrCreate";
                retur[3]="TrDelete";
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
            case "Facility":
                retur.Add(addLine("FaId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("FaCode","false"));
                retur.Add(addLine("FaDescr","true"));
                retur.Add(addLine("FaType","false"));
                break;
            case "WCenter":
                retur.Add(addLine("WcdId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("Wccode","false"));
                retur.Add(addLine("Wcdescr","true"));
                retur.Add(addLine("Wctype","false"));
                break;
            case "WCenterC":
                retur.Add(addLine("WcoId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("WcoCode","false"));
                retur.Add(addLine("WcoDescr","true"));
                retur.Add(addLine("WcoType","false"));
                break;
            case "Materials":
                retur.Add(addLine("MatId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("MatRefer","false"));
                retur.Add(addLine("MatDescr","true"));
                retur.Add(addLine("MatClass","false"));
                break;
            case "SLocation":
                retur.Add(addLine("LocId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("LocCode","false"));
                retur.Add(addLine("LocDescr","true"));
                retur.Add(addLine("LocType","false"));
                break;
            case "Operators":
                retur.Add(addLine("OpeId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("OpeCode","false"));
                retur.Add(addLine("OpeDesc","true"));
                retur.Add(addLine("OpeCosth","true"));
                retur.Add(addLine("OpeCurcy","false"));
                break;
            case "Trucks":
                retur.Add(addLine("TruckId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("TruckCode","false"));
                retur.Add(addLine("TruckDeno","true"));
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
            case "Facility":
                    retur.Add("Facility");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FcCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FcDescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FcType"));
                break;
            case "WCenter":
                    retur.Add("WCenter");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCDesc"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("WCType"));
                break;
            case "WCenterC":
                    retur.Add("WCenterCo");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Code"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Description"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Type"));
                break;
            case "Materials":
                    retur.Add("Materials");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatRefer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatDescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("MatClass"));
                break;
            case "SLocation":
                    retur.Add("SLocation");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("LocCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("LocDescr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("LocType"));
                break;
            case "Operators":
                    retur.Add("Review");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Code"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Costh"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Curcy"));
                break;
            case "Trucks":
                    retur.Add("Trucks");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Code"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Deno"));
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_Facility(dynamic oTMaterial)
        {
            IEnumerable<TFacility> fTPersonal = (List<TFacility>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.FaId,
                        CampoKy = f.FaId,
                        Campo01 = f.FaCode.ToString(),
                        Campo02 = f.FaDescr.ToString(),
                        Campo03 = f.FaType.ToString(),
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











    IEnumerable<Container> getData_WCenter(dynamic oTMaterial)
        {
            IEnumerable<TWorkCenter> fTPersonal = (List<TWorkCenter>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.WcdId,
                        CampoKy = f.WcdId,
                        Campo01 = f.Wccode.ToString(),
                        Campo02 = f.Wcdescr.ToString(),
                        Campo03 = f.Wctype.ToString(),
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








    IEnumerable<Container> getData_WCenterC(dynamic oTMaterial)
        {
            IEnumerable<TWccomponent> fTPersonal = (List<TWccomponent>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.WcoId,
                        CampoKy = f.WcoId,
                        Campo01 = f.WcoCode.ToString(),
                        Campo02 = f.WcoDescr.ToString(),
                        Campo03 = f.WcoType.ToString(),
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









    IEnumerable<Container> getData_Materials(dynamic oTMaterial)
        {
            IEnumerable<TMaterial> fTPersonal = (List<TMaterial>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.MatId,
                        CampoKy = f.MatId,
                        Campo01 = f.MatRefer.ToString(),
                        Campo02 = f.MatDescr.ToString(),
                        Campo03 = f.MatClass.ToString(),
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








    IEnumerable<Container> getData_SLocation(dynamic oTMaterial)
        {
            IEnumerable<TLocation> fTPersonal = (List<TLocation>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.LocId,
                        CampoKy = f.LocId,
                        Campo01 = f.LocCode.ToString(),
                        Campo02 = f.LocDescr.ToString(),
                        Campo03 = f.LocType.ToString(),
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








    IEnumerable<Container> getData_Operators(dynamic oTMaterial)
        {
            IEnumerable<TOperator> fTPersonal = (List<TOperator>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.OpeId,
                        CampoKy = f.OpeId,
                        Campo01 = f.OpeCode.ToString(),
                        Campo02 = f.OpeDesc.ToString(),
                        Campo03 = f.OpeCosth.ToString(),
                        Campo04 = f.OpeCurcy.ToString(),
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








    IEnumerable<Container> getData_Trucks(dynamic oTMaterial)
        {
            IEnumerable<TCTruck> fTPersonal = (List<TCTruck>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.TruckId,
                        CampoKy = f.TruckId,
                        Campo01 = f.TruckCode.ToString(),
                        Campo02 = f.TruckDeno.ToString(),
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
    string errmsg()
    {
        string ret = (string)ViewData["ErrorMs"];
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
