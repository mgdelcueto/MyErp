#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2ef12b8f779ba0d1d4426301051eaa72a5a77e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_Index), @"mvc.1.0.view", @"/Views/TOrganiza/Index.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2ef12b8f779ba0d1d4426301051eaa72a5a77e", @"/Views/TOrganiza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <!--Organization-->\r\n\r\n    <!--Chart-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 5135, "", 5155, 1);
#nullable restore
#line 147 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
WriteAttributeValue("", 5142, isVisible(2), 5142, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"cont-titles\">\r\n            <h4>");
#nullable restore
#line 149 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("CharList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n        ");
#nullable restore
#line 151 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
   Write(Html.dataGrid(20,16,@Columns("Chart"),@getData_Chart((List<VTChart>)ViewBag.ListChar),@Controller("Chart"),@Fields("Chart")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n");
            WriteLiteral("    <!--Users-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 5792, "", 5812, 1);
#nullable restore
#line 167 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
WriteAttributeValue("", 5799, isVisible(5), 5799, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"cont-titles\">\r\n            <h4>");
#nullable restore
#line 169 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("CharList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n        ");
#nullable restore
#line 171 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
   Write(Html.dataGrid(21,16,@Columns("Users"),@getData_Users((List<TUser>)ViewBag.ListUS),@Controller("Users"),@Fields("Users")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <!--Languages-->\r\n    <div");
            BeginWriteAttribute("class", " class=", 6193, "", 6213, 1);
#nullable restore
#line 176 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
WriteAttributeValue("", 6200, isVisible(3), 6200, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            ");
#nullable restore
#line 178 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Useddltoselect"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Index.cshtml"
            

    string [] Controller(string table){
        string [] retur = new string [4];
        switch (table)
        {
        case "Chart":
                retur[0]="TOrganiza";
                retur[1]="CharEdit";            //Edit not enabled
                retur[2]="CharCreate";            //Create not enabled
                retur[3]="CharDelete";     //delete is remove
                break;
        case "Users":
                retur[0]="TOrganiza";
                retur[1]="UserEdit";
                retur[2]="UserCreate";
                retur[3]="UserDelete";
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
            case "Chart":
                retur.Add(addLine("CharId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("Charode","false"));
                retur.Add(addLine("CharName","false"));
                retur.Add(addLine("CharHName","false"));
                break;
            case "Users":
                retur.Add(addLine("UserId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("UserFirsName","false"));
                retur.Add(addLine("UserLastName","false"));
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
            case "Chart":
                    retur.Add("Chart");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ChCode"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ChName"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("ChHeadName"));
                break;
            case "Users":
                    retur.Add("Users");
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("FirsName"));
                    retur.Add(@SharedLocalizer.GetLocalizedHtmlString("LastName"));
                break;
            default:
                break;
        }
        return retur;
    }
    IEnumerable<Container> getData_Chart(dynamic oTMaterial)
        {
            IEnumerable<VTChart> fTPersonal = (List<VTChart>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.CharId,
                        CampoKy = f.CharId,
                        Campo01 = f.CharCode.ToString(),
                        Campo02 = f.CharName.ToString(),
                        Campo03 = f.CharHName.ToString(),
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

    IEnumerable<Container> getData_Users(dynamic oTMaterial)
        {
            IEnumerable<TUser> fTPersonal = (List<TUser>)oTMaterial;
            IEnumerable<Container> TPersonal = fTPersonal.Select(
                f => new Container() 
                {
                        CampoId = f.UserId,
                        CampoKy = f.UserId,
                        Campo01 = f.UserFirstName.ToString(),
                        Campo02 = f.UserLastName.ToString(),
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
