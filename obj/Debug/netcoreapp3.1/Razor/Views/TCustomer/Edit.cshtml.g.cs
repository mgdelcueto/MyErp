#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ae5ba43b7d312ba7bc8affde2a022a0a52498b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_Edit), @"mvc.1.0.view", @"/Views/TCustomer/Edit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ae5ba43b7d312ba7bc8affde2a022a0a52498b", @"/Views/TCustomer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
  
    Layout = null;  
    Layout = "_LayCus.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
<script>
    function chkAllsubmit(modulo)
    {
        var e = document.getElementById(modulo);
        var value = e.checked;
        var urlstr =window.location.href;
        const pathn = window.location.pathname;
        const querystring = window.location.search;
        const params = new URLSearchParams(querystring);
        params.set(e.name.toString(),value.toString());
        var new_url=window.location.protocol+""//""+window.location.hostname+"":""+window.location.port+pathn.toString()+""?""+params.toString();
        window.location.href = new_url;
    }
    function selectPlant(modulo,panel)
    {
        //hace un httpget en este modulo para cargar el ViweData correspondiente
        var e = document.getElementById(modulo);
        var value = e.options[e.selectedIndex].WcoId;
        var url=window.location.href.split(""?"")[0];
        url=url+""?""+e.name+""=""+e.value.toString()+""&panel=""+panel.toString();
        window.location.href = url;

    }

    function selectPlantP");
            WriteLiteral(@"rod(planta,produ,panel)
    {
        //hace un httpget en este modulo para cargar el ViweData correspondiente
        var e = document.getElementById(planta);
        //var value = e.options[e.selectedIndex].WcoId;

        var f = document.getElementById(produ);
        //var falue = f.options[f.selectedIndex].WcoId;

        var url=window.location.href.split(""?"")[0];
        url=url+""?""+e.name+""=""+e.value.toString()+""&""+f.name+""=""+f.value.toString()+""&panel=""+panel.toString();
        window.location.href = url;

    }
</script>


");
#nullable restore
#line 344 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
 using (Html.BeginForm("Edit","TCustomer",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
#nullable restore
#line 346 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
Write(Html.HiddenFor(p => p.CustId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 347 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=", 13644, "", 13664, 1);
#nullable restore
#line 348 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 13651, isVisible(1), 13651, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"div-edit\">\r\n    <table class=\"table-edit\">\r\n        <div class=\"style-data\">\r\n        <h3>");
#nullable restore
#line 352 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("CustomerData"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>        
        </div>
        <tr>
            <td><input type=""submit"" class=""dropbtn"" value=""Update""name=""actionType""/></td>
            <td><input type=""submit"" class=""dropbtn"" value=""Cancel""  name=""actionType""/></td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 359 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustRasoc,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 360 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustRasoc, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:450px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 364 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustRasoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 367 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustNif,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 368 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustNif, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:150px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 372 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustNif));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 375 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustCrDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 376 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustCrDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 380 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 383 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustCode,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 384 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustCode, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:250px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 388 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 391 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustAdStrt,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 392 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustAdStrt, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:450px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 393 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustAdCity,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 394 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustAdCity, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 398 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustAdStrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 400 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustAdCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 403 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustAdCtry,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 405 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.DropDownListFor(p => p.CustAdCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-tb-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 408 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustCtPhone,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 409 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustCtPhone, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:200px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 413 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustAdCtry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 415 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCtPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 418 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustCtEmailLog,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 419 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustCtEmailLog, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:250px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 420 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.LabelFor(p => p.CustCtEdilog,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 421 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.EditorFor(p => p.CustCtEdilog, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:250px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 425 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCtEmailLog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 427 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.CustCtEdilog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=", 17749, "", 17769, 1);
#nullable restore
#line 432 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 17756, isVisible(2), 17756, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 436 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("ProductData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 439 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.dataGrid(35,9,@Columns("Product"),@getData_Product((List<TCCproduct>)ViewBag.ListProd),@Controller("Product"),@Fields("Product"),Model.CustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=", 18273, "", 18293, 1);
#nullable restore
#line 443 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 18280, isVisible(3), 18280, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 447 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("PlanttData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 450 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.dataGrid(36,9,@Columns("CPlant"),@getData_CPlant((List<TCCplant>)ViewBag.ListPlant),@Controller("CPlant"),@Fields("CPlant"),Model.CustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n    </div>  \r\n    <div");
            BeginWriteAttribute("class", " class=", 18793, "", 18813, 1);
#nullable restore
#line 454 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 18800, isVisible(4), 18800, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 457 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("PlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n");
#nullable restore
#line 459 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
             using (Html.BeginForm("Edit","TCustomer",FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td class=\"norm-lab-text\">");
#nullable restore
#line 462 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                         Write(SharedLocalizer.GetLocalizedHtmlString("Plant"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"hidden\" name=\"CustId\"");
            BeginWriteAttribute("value", " value=\"", 19268, "\"", 19291, 1);
#nullable restore
#line 462 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 19276, Model.CustId, 19276, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td class=\"norm-text\">\r\n                        ");
#nullable restore
#line 464 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                   Write(Html.DropDownList("plant", (SelectList)ViewBag.ddlPlantVB, new { @id="xplant", @class ="norm-tb-text" , onchange = "selectPlantProd('xplant','_prod',4)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n");
            WriteLiteral("                    <td class=\"norm-lab-text\">");
#nullable restore
#line 471 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                         Write(SharedLocalizer.GetLocalizedHtmlString("Reference"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</td>\r\n                    <td class=\"norm-text\">\r\n                        ");
#nullable restore
#line 473 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                   Write(Html.DropDownList("prod", (SelectList)ViewBag.ddlReferVO, new { @id="_prod" , @class ="norm-tb-text" , onchange = "selectPlantProd('xplant','_prod',4)"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>            \r\n                    <td class=\"norm-lab-text\">");
#nullable restore
#line 476 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                         Write(SharedLocalizer.GetLocalizedHtmlString("AllPlantProds"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 477 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                   Write(Html.CheckBox( "allpprods",@chkAllpp() , new { @id="_cbapp" , @class ="norm-tb-text" , onchange = "chkAllsubmit('_cbapp')"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"hidden\" name=\"panel\"");
            BeginWriteAttribute("value", " value=\"", 20444, "\"", 20464, 1);
#nullable restore
#line 479 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 20452, thisPanel(), 20452, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n");
            WriteLiteral("            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 486 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.dataGrid(37,9,@Columns("CPlann"),@getData_CPlann((List<VTCCplanning>)ViewBag.ListPlan),@Controller("CPlann"),@Fields("CPlann"),Model.CustId,@aparqsaction(),true,true,"EditPlann"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 488 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>    \r\n    <div");
            BeginWriteAttribute("class", " class=", 20905, "", 20925, 1);
#nullable restore
#line 491 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 20912, isVisible(5), 20912, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <table class=\"table-edit\" border=\"1\">\r\n            <div class=\"cont-titles\">\r\n                <h3 class=\"style-data\">");
#nullable restore
#line 494 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("PlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n");
            WriteLiteral("            <table>\r\n                    <td>\r\n                        <input type=\"hidden\" name=\"CustId\"");
            BeginWriteAttribute("value", " value=\"", 21327, "\"", 21350, 1);
#nullable restore
#line 499 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 21335, Model.CustId, 21335, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                        <input type=\"hidden\" name=\"panel\"");
            BeginWriteAttribute("value", " value=\"", 21412, "\"", 21432, 1);
#nullable restore
#line 500 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
WriteAttributeValue("", 21420, thisPanel(), 21420, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    </td>\r\n                    <td class=\"norm-lab-text\">");
#nullable restore
#line 502 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                                         Write(SharedLocalizer.GetLocalizedHtmlString("Plant"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"norm-text\">\r\n                     ");
#nullable restore
#line 504 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
                Write(Html.DropDownList("plant", (SelectList)ViewBag.ddlPlantVB, new { @id="_plant", @class ="norm-tb-text" , onchange = "selectPlant('_plant',5)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                  </td>\r\n            </table>\r\n");
            WriteLiteral("            <div  class=\"_container\" name=\"aqui-el-control-grid-3\">\r\n                ");
#nullable restore
#line 510 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
           Write(Html.dataGrid(38,9,@Columns("CPO"),@getData_CPO((List<VTCPorder>)ViewBag.listPO),@Controller("CPO"),@Fields("CPO"),Model.CustId,@aparqsaction()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </table>\r\n    </div>    \r\n");
#nullable restore
#line 514 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Edit.cshtml"
            


    string aparqsaction( )
    {
        int plant=0;
        int prod =0;
        try{
            plant =Convert.ToInt32(ViewData["Plant"].ToString());
        }
        catch{}
        try{
            prod =Convert.ToInt32(ViewData["Prod"].ToString());
        }
        catch{}
        string ret ="plant="+plant.ToString()+"&prod="+prod.ToString()+"&id=";
        return ret;
    }

    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "Product":
                retur[0]="TCustomer";
                retur[1]="ProEdit";
                retur[2]="ProCreate";
                retur[3]="ProDelete";
                break;
        case "CPlant":
                retur[0]="TCustomer";
                retur[1]="PlantEdit";
                retur[2]="PlantCreate";
                retur[3]="PlantDelete";
                break;
        case "CPlann":
                retur[0]="TCustomer";
                retur[1]="PlanEdit";
                retur[2]="PlanCreate";
                retur[3]="PlanDelete";
                break;
        case "CPO":
                retur[0]="TCustomer";
                retur[1]="PoEdit";
                retur[2]="PoCreate";
                retur[3]="PoDelete";
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
            case "Product":
                    retur.Add(addLine("CprodId","false"));
                    retur.Add(addLine("CampoKy","false"));
                    retur.Add(addLine("CprodRefInt","false"));
                    retur.Add(addLine("CprodDescInt","true"));
                    retur.Add(addLine("CprodCrDate","false"));
                    retur.Add(addLine("CprodStatus","false"));
                break;
            case "CPlant":
                    retur.Add(addLine("CplantId","false"));
                    retur.Add(addLine("CampoKy","false"));
                    retur.Add(addLine("CplantCode","false"));
                    retur.Add(addLine("CplantDeno","true"));
                    retur.Add(addLine("CplantAdStrt","true"));
                    retur.Add(addLine("CplantAdCity","true"));
                    retur.Add(addLine("CplantAdCtry","false"));
                break;
            case "CPlann":
                    retur.Add(addLine("CplanId","false"));
                    retur.Add(addLine("CampoKy","false"));
                    retur.Add(addLine("CprodRefInt","false"));
                    retur.Add(addLine("CprodDescInt","true"));
                    retur.Add(addLine("CplanDateFrom","false"));
                    retur.Add(addLine("CplanDateTo","false"));
                    retur.Add(addLine("CplanQty","true"));
                    retur.Add(addLine("CplanFirmSt","false"));
                break;
            case "CPO":
                    retur.Add(addLine("Cpoid","false"));
                    retur.Add(addLine("CampoKy","false"));
                    retur.Add(addLine("Cpopo","false"));
                    retur.Add(addLine("CporeferEx","false"));
                    retur.Add(addLine("CprodRefInt","false"));
                    retur.Add(addLine("CpodescEx","true"));
                    retur.Add(addLine("Cpoprice","true"));
                    retur.Add(addLine("Cpocurcy","false"));
                    retur.Add(addLine("Cpostatus","false"));
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
            case "Product":
                    retur.Add("Product");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Refer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("CrDate"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Status"));
                break;
            case "CPlant":
                    retur.Add("CPlant");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Code"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Deno"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Address"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("City"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Country"));
                break;
            case "CPlann":
                    retur.Add("CPlann");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DescInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DateFRom"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DateTo"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FirmStat"));
                break;
            case "CPO":
                    retur.Add("CPO");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("PO"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefEx"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RefInt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("DescExt"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Price"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Curcy"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Status"));
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_Product(dynamic oTMaterial)
        {
            IEnumerable<TCCproduct> fTPersonal = (List<TCCproduct>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.CprodId,
                        CampoKy = f.CprodId,
                        Campo01 = f.CprodRefInt.ToString(),
                        Campo02 = f.CprodDescInt.ToString(),
                        Campo03 = string.Format("{0:dd-MM-yyyy}", f.CprodCrDate),
                        Campo04 = f.CprodStatus.ToString(),
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
    IEnumerable<Container> getData_CPlant(dynamic oTMaterial)
        {
            IEnumerable<TCCplant> fTPersonal = (List<TCCplant>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.CplantId,
                        CampoKy = f.CplantId,
                        Campo01 = f.CplantCode.ToString(),
                        Campo02 = f.CplantDeno.ToString(),
                        Campo03 = f.CplantAdStrt.ToString(),
                        Campo04 = f.CplantAdCity.ToString(),
                        Campo05 = f.CplantAdCtry.ToString(),
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

    IEnumerable<Container> getData_CPlann(dynamic oTMaterial)
        {
            IEnumerable<VTCCplanning> fTPersonal = (List<VTCCplanning>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.CplanId,
                        CampoKy = f.CplanId,
                        Campo01 = f.CprodRefInt.ToString(),
                        Campo02 = f.CprodDescInt.ToString(),
                        Campo03 = string.Format("{0:dd-MM-yyyy}", f.CplanDateFrom),
                        Campo04 = string.Format("{0:dd-MM-yyyy}", f.CplanDateTo),
                        Campo05 = f.CplanQty.ToString(),
                        Campo06 = f.CplanFirmSt.ToString(),
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

    IEnumerable<Container> getData_CPO(dynamic oTMaterial)
        {
            IEnumerable<VTCPorder> fTPersonal = (List<VTCPorder>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.Cpoid,
                        CampoKy = f.Cpoid,
                        Campo01 = f.Cpopo.ToString(),
                        Campo02 = f.CporeferEx.ToString(),
                        Campo03 = f.CprodRefInt.ToString(),
                        Campo04 = f.CpodescEx.ToString(),
                        Campo05 = f.Cpoprice.ToString(),
                        Campo06 = f.Cpocurcy.ToString(), 
                        Campo07 = f.Cpostatus.ToString(),
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
    bool chkAllpp()
    {
        bool ret = false;
        try{
            ret = Convert.ToBoolean(ViewData["Allpp"].ToString());
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591
