#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb734658db13ed85024eb1af55c4f74fbc8b3c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_Edit), @"mvc.1.0.view", @"/Views/TSuplier/Edit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb734658db13ed85024eb1af55c4f74fbc8b3c87", @"/Views/TSuplier/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSuplier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
  
    Layout = null;  
    Layout = "_LaySup.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 209 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
Write(Html.HiddenFor(p => p.SupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=", 8004, "", 8024, 1);
#nullable restore
#line 212 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 8011, isVisible(1), 8011, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"cont-titles\">\r\n        <h3 class=\"style-data\">");
#nullable restore
#line 214 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("SuplierData"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    </div>
    <div class=""div-edit"">
    <table class=""table-edit"">
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Update"" name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel""  name=""actionType""/></td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 223 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupRasoc,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 224 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupRasoc, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:320" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 228 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupRasoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 231 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupNif,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 232 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupNif, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:90" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 236 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupNif));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 239 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCrDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 240 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCrDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 244 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 247 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCode,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 248 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCode, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 252 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 255 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupAdStrt,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 256 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupAdStrt, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:350" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 257 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupAdCity,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 258 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupAdCity, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 262 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupAdStrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 264 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupAdCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 267 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupAdCtry,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 269 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.DropDownListFor(p => p.SupAdCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 272 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCtPhone,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 273 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCtPhone, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 277 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupAdCtry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 279 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCtPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 282 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCtEmailLog,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 283 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCtEmailLog, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:250" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 284 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCtEdilog,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 285 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCtEdilog, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:250" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 289 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCtEmailLog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 291 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCtEdilog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n    </table>\r\n    </div>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=", 12130, "", 12150, 1);
#nullable restore
#line 296 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 12137, isVisible(2), 12137, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 299 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("ProductData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 302 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.dataGrid(24,9,@Columns("Product",0),@getData_Product((List<TSProduct>)ViewBag.ListProd),@Controller("Product"),@Columns("Product",1),Model.SupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=", 12657, "", 12677, 1);
#nullable restore
#line 307 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 12664, isVisible(3), 12664, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 310 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("SupPlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 313 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.dataGrid(25,9,@Columns("SPlan",0),@getData_SPlan((List<TSPlanningV>)ViewBag.ListPlan),@Controller("SPlan"),@Columns("SPlan",1),Model.SupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=", 13182, "", 13202, 1);
#nullable restore
#line 318 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 13189, isVisible(4), 13189, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 321 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("SupPlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 324 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.dataGrid(26,9,@Columns("SPO",0),@getData_SPO((List<VTSPorder>)ViewBag.listSpo),@Controller("SPO"),@Columns("SPO",1),Model.SupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n\r\n    </div>    \r\n");
#nullable restore
#line 329 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
            

    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "Product":
                retur[0]="TSuplier";
                retur[1]="ProEdit";
                retur[2]="ProCreate";
                retur[3]="ProDelete";
                break;
        case "SPlan":
                retur[0]="TSuplier";
                retur[1]="PlanEdit";
                retur[2]="PlanCreate";
                retur[3]="PlanDelete";
                break;
        case "SPO":
                retur[0]="TSuplier";
                retur[1]="PoEdit";
                retur[2]="PoCreate";
                retur[3]="PoDelete";
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
            case "Product":
                if (type==0)
                {
                    retur.Add("Product");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Reference"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descriptio"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Date Creation"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Status"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Date Status"));
                }
                else{
                    retur.Add("ProdId");
                    retur.Add("ProdRefer");
                    retur.Add("ProdDescr");
                    retur.Add("ProdCrDate");
                    retur.Add("ProdStatus");
                    retur.Add("ProdStDate");
                }
                break;
            case "SPlan":
                if (type==0)
                {
                    retur.Add("SPlan");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Refer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FromDate"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ToDate"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FirmStat"));
                }
                else{
                    retur.Add("PlanId");
                    retur.Add("ProdRefer");
                    retur.Add("ProdDescr");
                    retur.Add("PlanDateFrom");
                    retur.Add("PlanDateTo");
                    retur.Add("PlanQty");
                    retur.Add("PlanFirmSt");
                }
                break;
            case "SPO":
                if (type==0)
                {
                    retur.Add("SPO");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("PO"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefEx"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DescExt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Price"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Curcy"));
                }
                else{
                    retur.Add("Spoid");
                    retur.Add("Spopo");
                    retur.Add("SprodRefInt");
                    retur.Add("SporeferEx");
                    retur.Add("SpodescEx");
                    retur.Add("Spocurcy");
                }    
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_Product(dynamic oTMaterial)
        {
            IEnumerable<TSProduct> fTPersonal = (List<TSProduct>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.ProdId,
                        Campo01 = f.ProdRefer.ToString(),
                        Campo02 = f.ProdDescr.ToString(),
                        Campo03 = f.ProdCrDate.ToString(),
                        Campo04 = f.ProdStatus.ToString(),
                        Campo05 = f.ProdStDate.ToString(),
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
    IEnumerable<Container> getData_SPlan(dynamic oTMaterial)
        {
            IEnumerable<TSPlanningV> fTPersonal = (List<TSPlanningV>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.PlanId,
                        Campo01 = f.ProdRefer.ToString(),
                        Campo02 = f.ProdDescr.ToString(),
                        Campo03 = f.PlanDateFrom.ToString(),
                        Campo04 = f.PlanDateTo.ToString(),
                        Campo05 = f.PlanQty.ToString(),
                        Campo06 = f.PlanFirmSt.ToString(), 
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

    IEnumerable<Container> getData_SPO(dynamic oTMaterial)
        {
            IEnumerable<VTSPorder> fTPersonal = (List<VTSPorder>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.Spoid,
                        Campo01 = f.Spopo.ToString(),
                        Campo02 = f.SprodRefInt.ToString(),
                        Campo03 = f.SporeferEx.ToString(),
                        Campo04 = f.SpodescEx.ToString(),
                        Campo05 = f.Spoprice.ToString(),
                        Campo06 = f.Spocurcy.ToString(), 
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

    string panelBold(int panel)
    {            
        int tpan = (int)ViewData["panel"];
        string cstyle ="";
        if (panel==tpan)
        {cstyle="font-weight:bold";}
        return cstyle;
    }

    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
        return retcol;
    }
    int thisPanel(){
         int opanel = (int)ViewData["panel"];
         return opanel;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TSuplier> Html { get; private set; }
    }
}
#pragma warning restore 1591
