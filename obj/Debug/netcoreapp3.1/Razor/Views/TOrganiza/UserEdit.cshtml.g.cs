#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be9a9ea3b3336adc3c1092e94e3c592da8f9f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_UserEdit), @"mvc.1.0.view", @"/Views/TOrganiza/UserEdit.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be9a9ea3b3336adc3c1092e94e3c592da8f9f60", @"/Views/TOrganiza/UserEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_UserEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("<div class=\" clearfix position-relative o_form_sheet center\">\r\n\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 106 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("EdUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 108 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 110 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
Write(Html.HiddenFor(p => p.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 111 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n");
            WriteLiteral("        <tr>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" class=\"dropbtn\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n        ");
#nullable restore
#line 118 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
   Write(await Html.PartialAsync("_pshowUser",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td><label for=\"resetpw\">");
#nullable restore
#line 120 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
                                Write(SharedLocalizer.GetLocalizedHtmlString("Reset_Pw"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n            <td><input type=\"checkbox\" id=\"iresetpw\" name=\"nresetpw\" ></td>\r\n        </tr>\r\n        <tr>\r\n            ");
#nullable restore
#line 124 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
       Write(Coment());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
            WriteLiteral("<div class=\"visible\">\r\n\r\n    <table class=\"table-norm\" border=\"1\">\r\n        <div class=\"style-data\">\r\n            <h3>");
#nullable restore
#line 135 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("RolUsers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"visible\">");
            WriteLiteral("   \r\n            <table>\r\n                <tr>\r\n                    <td class=\"norm-lab-text\">");
#nullable restore
#line 140 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
                                         Write(SharedLocalizer.GetLocalizedHtmlString("SelRoletoUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"norm-text\">\r\n                        ");
#nullable restore
#line 143 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
                   Write(Html.DropDownList("Code", (SelectList)ViewBag.ddlRole, new { @class ="norm-tb-text" , onchange = "this.form.submit();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n\r\n");
            WriteLiteral("        ");
#nullable restore
#line 151 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
   Write(Html.dataGrid(23,9,@Columns("RolUsers"),@getData_RolUsers((List<TUsRol>)ViewBag.ListUserRol),@Controller("RolUsers"),@Fields("RolUsers"),0,@parqsaction()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 155 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\UserEdit.cshtml"
            

    string parqsaction()
    {
        //deja el ultimo parametroa rellenar con el Id de la tabla en el javascript del control grid
        string ret="";
        try{
        ret ="/"+Model.UserId.ToString()+"?wrem=";}
        catch{}
        return ret;
    }
    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "RolUsers":
                retur[0]="TOrganiza";
                retur[1]="";            //Edit not enabled
                retur[2]="";            //Create not enabled
                retur[3]="UserEdit";     //delete is remove
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
            case "RolUsers":
                retur.Add(addLine("UsRolId","false"));
                retur.Add(addLine("UsRolName","false"));
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
            case "RolUsers":
                    retur.Add("RolUsers");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Name"));
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_RolUsers(dynamic oTMaterial)
        {
            IEnumerable<TUsRol> fTPersonal = (List<TUsRol>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.UsRolId,
                        Campo01 = f.UsRolName.ToString(),
                        Campo02 = "",
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


    string Coment(){
        string coment="";
        try{
        coment =@SharedLocalizer.GetLocalizedHtmlString((string)ViewData["Coment"]);
        coment = coment +" "+(string)ViewData["NewPw"];
        }catch{}
        return coment;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
