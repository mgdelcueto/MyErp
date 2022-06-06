#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9696f0926ea7524e73e4df30b27a5d86f31add41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TLog_BLHEdit), @"mvc.1.0.view", @"/Views/TLog/BLHEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9696f0926ea7524e73e4df30b27a5d86f31add41", @"/Views/TLog/BLHEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TLog_BLHEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TInputBLH>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\" clearfix position-relative o_form_sheet center\">\r\n\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 132 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("IBLHeadEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 134 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"div-edit\">\r\n    ");
#nullable restore
#line 136 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-edit\">\r\n         <tr>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Cancel\" name=\"actionType\"/></td>\r\n            <td");
            BeginWriteAttribute("style", " style=\"", 4702, "\"", 4737, 1);
#nullable restore
#line 141 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
WriteAttributeValue("", 4710, hVisible(Model.InBLStatus), 4710, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><input type=\"submit\" class=\"dropbtn\"");
            BeginWriteAttribute("value", " value=\"", 4775, "\"", 4812, 1);
#nullable restore
#line 141 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
WriteAttributeValue("", 4783, PostAction(Model.InBLStatus), 4783, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  name=\"actionType\"/></td>\r\n        </tr>\r\n        ");
#nullable restore
#line 143 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
   Write(Html.Partial("_pshowBLH",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <div class=\"cont-titles\">\r\n            <h3>");
#nullable restore
#line 148 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("BLDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        ");
#nullable restore
#line 150 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
   Write(Html.dataGrid(43,9,@Columns("InputBLD"),@getData_InputBLD((List<VTBLDet>)ViewBag.ListBLDet),@Controller("InputBLD",Model.InBLStatus),@Fields("InputBLD"),Model.InBLId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 152 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TLog\BLHEdit.cshtml"
            
    string Visible(string Status)
    {
        string ret = "invisible";
        if (Status=="PR" || Status=="QA"|| Status=="IN"){ret="visible";}
        return ret;
    }
    string PostAction(string Status){
        string ret = "";
        switch(Status)
        {
            case "PR":
                ret ="PostBL";
                break;
            case "QA":
                ret ="Accept";
                break;
            case "IN":
                ret="Invoice";
                break;
            default:
                break;
        }
        return ret;
    }
    string hVisible(string Status)
    {
        string ret = "visibility:hidden;";
        if (Status=="PR" || Status=="QA"|| Status=="IN"){ret="visibility:visible;";}
        return ret;    }

    string [] Controller(string table, string Status){
        string [] retur = new string [4];
        switch (table)
        {
        case "InputBLD":
            if (Status=="PR"){
                retur[0]="TLog";
                retur[1]="BLDEdit";
                retur[2]="BLDCreate";
                retur[3]="BLDDelete";
            }
            else{
                retur[0]="TLog";
                retur[1]="";
                retur[2]="";
                retur[3]="";
            }
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
            case "InputBLD":
                retur.Add(addLine("InBLDId","false"));
                retur.Add(addLine("InBLDMRefer","false"));
                retur.Add(addLine("InBLDMDescr","true"));
                retur.Add(addLine("InBLDQty","false"));
                retur.Add(addLine("InBLDMatUnMed","false"));
                retur.Add(addLine("InBLDUMRef","false"));
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
            case "InputBLD":
                    retur.Add("InputBLD");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Refer"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Descr"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Qty"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UMed"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("UM"));
                break;
            default:
                break;
        }
        return retur;
    }

    IEnumerable<Container> getData_InputBLD(dynamic oTMaterial)
        {
            IEnumerable<VTBLDet> fTPersonal = (List<VTBLDet>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.InBLDId,
                        Campo01 = f.InBLDMRefer.ToString(),
                        Campo02 = f.InBLDMDescr.ToString(),
                        Campo03 = f.InBLDQty.ToString(),
                        Campo04 = f.InBLDMatUnMed.ToString(),
                        Campo05 = (f.InBLDUMRef ??"").ToString(),
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TInputBLH> Html { get; private set; }
    }
}
#pragma warning restore 1591
