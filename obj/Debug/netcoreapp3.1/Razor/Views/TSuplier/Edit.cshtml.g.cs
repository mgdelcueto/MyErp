#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10015d27a04207acc87541e587baac0a932b3d51"
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
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10015d27a04207acc87541e587baac0a932b3d51", @"/Views/TSuplier/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSuplier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
  
    Layout = null;  
    Layout = "_LaySup.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
Write(Html.HiddenFor(p => p.SupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=", 3838, "", 3858, 1);
#nullable restore
#line 83 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 3845, isVisible(1), 3845, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table>\r\n        <div class=\"cont-titles\">\r\n        <h4>");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("SuplierData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupRasoc,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 90 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupRasoc, new { htmlAttributes = new { @class = "norm-text", @style = "width:320" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 94 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupRasoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 97 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupNif,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupNif, new { htmlAttributes = new { @class = "norm-text", @style = "width:90" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 102 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupNif));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 105 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCrDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 106 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCrDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 110 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 113 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCode,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 114 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCode, new { htmlAttributes = new { @class = "norm-text", @style = "width:150" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 118 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 121 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupAdStrt,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 122 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupAdStrt, new { htmlAttributes = new { @class = "norm-text", @style = "width:350" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 123 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupAdCity,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 124 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupAdCity, new { htmlAttributes = new { @class = "norm-text", @style = "width:150" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 128 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupAdStrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 130 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupAdCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 133 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupAdCtry,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 135 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.DropDownListFor(p => p.SupAdCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 138 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCtPhone,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 139 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCtPhone, new { htmlAttributes = new { @class = "norm-text", @style = "width:150" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 143 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupAdCtry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 145 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCtPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 148 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCtEmailLog,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 149 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCtEmailLog, new { htmlAttributes = new { @class = "norm-text", @style = "width:250" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 150 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.LabelFor(p => p.SupCtEdilog,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 151 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.EditorFor(p => p.SupCtEdilog, new { htmlAttributes = new { @class = "norm-text", @style = "width:250" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 155 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCtEmailLog));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 157 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.SupCtEdilog));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>        
        <tr>
            <td></td>
            <td><input type=""submit"" value=""Update"" name=""actionType""/></td>
            <td><input type=""submit"" value=""Cancel""  name=""actionType""/></td>
        </tr>
    </table>
    </div>
    <div");
            BeginWriteAttribute("class", " class=", 7815, "", 7835, 1);
#nullable restore
#line 166 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 7822, isVisible(2), 7822, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h3>");
#nullable restore
#line 169 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("ProductData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 172 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("ProRefer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 173 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("ProDescr"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 174 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("ProDateCrea"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                \r\n        <th class=\"head-text\">");
#nullable restore
#line 175 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 176 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("StatusDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 179 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
     foreach (var c in ViewBag.ListProd) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 181 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.ProdRefer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"col-text\">");
#nullable restore
#line 182 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.ProdDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n");
#nullable restore
#line 183 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
               string DateCr = string.Format("{0:dd-MM-yyyy}", c.ProdCrDate); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class =\"col-text\">");
#nullable restore
#line 184 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(DateCr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-text\">");
#nullable restore
#line 185 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.ProdStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 186 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
               string DateSt = string.Format("{0:dd-MM-yyyy}", c.ProdStDate); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class =\"col-text\">");
#nullable restore
#line 187 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(DateSt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 188 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Delete", "ProDelete", new { id = c.ProdId,Pid = c.ProdSupId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 189 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Edit", "ProEdit", new { id = c.ProdId ,panel=2,skip =0,suid = c.ProdSupId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 190 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Plan", "Edit", new { id = c.ProdSupId ,panel=3,skip =0,prod=c.ProdId,suid = c.ProdSupId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 193 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 195 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
Write(Html.ActionLink("Add a New Item", "ProCreate",new {Pid=@Model.SupId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=", 9589, "", 9609, 1);
#nullable restore
#line 199 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 9596, isVisible(3), 9596, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"cont-titles\">\r\n    <h3>");
#nullable restore
#line 201 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("SupPlanningData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 203 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
     using (Html.BeginForm("Edit","TSuplier",FormMethod.Post,new{panel=3})) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n            <td class=\"medium-text\">");
#nullable restore
#line 205 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                               Write(SharedLocalizer.GetLocalizedHtmlString("ProRefer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                <!--");
#nullable restore
#line 207 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
               Write(ViewData["Prod"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n                ");
#nullable restore
#line 208 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
           Write(Html.DropDownList("ProdId", (SelectList)ViewBag.ddlReferVB, new { @class ="medium-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n    </table>\r\n");
#nullable restore
#line 211 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table-norm\" border =\"1\" >\r\n    <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 215 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("ProRefer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 216 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("ProDescr"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 217 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("DateFrom"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 218 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("DateTo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 219 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SendQty"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 220 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("PlanFirm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 223 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
     foreach ( TSPlanningV  c in (List<TSPlanningV>)ViewBag.ListPlan) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 225 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.ProdRefer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"col-text\">");
#nullable restore
#line 226 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.ProdDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n");
#nullable restore
#line 227 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
               string DateFrom = string.Format("{0:dd-MM-yyyy}", c.PlanDateFrom); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class =\"col-text\">");
#nullable restore
#line 228 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(DateFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 229 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
               string DateTo = string.Format("{0:dd-MM-yyyy}", c.PlanDateTo); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class =\"col-text\">");
#nullable restore
#line 230 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(DateTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-num\">");
#nullable restore
#line 231 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(c.PlanQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-text\">");
#nullable restore
#line 232 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.PlanFirmSt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 233 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Delete", "PlanDelete", new { id = c.PlanId,Pid = c.PlanSupId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 234 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Edit", "PlanEdit", new { id = c.PlanId ,panel=3,skip =0,suid = c.PlanSupId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 237 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 239 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
Write(Html.ActionLink("Add a New Item", "PlanCreate",new {Pid=@Model.SupId,prod=@ViewData["cProd"]}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>    \r\n");
            WriteLiteral("<!--PO Data -->\r\n    <div");
            BeginWriteAttribute("class", " class=", 11950, "", 11970, 1);
#nullable restore
#line 243 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 11957, isVisible(4), 11957, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 244 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
     using (Html.BeginForm("Edit","TSuplier",FormMethod.Post)) {        

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n            <td>\r\n                <input type=\"hidden\" name=\"SupId\"");
            BeginWriteAttribute("value", " value=\"", 12127, "\"", 12149, 1);
#nullable restore
#line 247 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 12135, Model.SupId, 12135, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <input type=\"hidden\" name=\"panel\"");
            BeginWriteAttribute("value", " value=\"", 12203, "\"", 12223, 1);
#nullable restore
#line 248 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
WriteAttributeValue("", 12211, thisPanel(), 12211, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </td>\r\n\r\n    </table>\r\n");
#nullable restore
#line 252 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table-norm\" border=\"1\">\r\n    <div class=\"cont-titles\">\r\n    <h3>");
#nullable restore
#line 255 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("SupPoData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 258 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupPO"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 259 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupExtRefer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 260 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupIntRefer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 261 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupExtDescr"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 262 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupPrice"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 263 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupCurrency"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 266 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
     foreach (VTSPorder c in (List<VTSPorder>) ViewBag.listSpo) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 268 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.Spopo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"col-text\">");
#nullable restore
#line 269 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.SporeferEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-text\">");
#nullable restore
#line 270 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.SprodRefInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-text\">");
#nullable restore
#line 271 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.SpodescEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-num\">");
#nullable restore
#line 272 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(c.Spoprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"col-text\">");
#nullable restore
#line 273 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                             Write(c.Spocurcy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 274 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Delete", "PoDelete", new { id = c.Spoid,Pid = c.SposupId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 275 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
                            Write(Html.ActionLink("Edit", "PoEdit", new { id = c.Spoid ,panel=4,skip =0,suid = c.SposupId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 277 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 279 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
Write(Html.ActionLink("Add a New Item", "PoCreate",new {Pid=@Model.SupId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>    \r\n<!--end PO-->\r\n");
#nullable restore
#line 282 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Edit.cshtml"
            
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
