#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecca766380ca0895817f03cb5d6a395bc35c1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_Index), @"mvc.1.0.view", @"/Views/TCustomer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
using MyErp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecca766380ca0895817f03cb5d6a395bc35c1d3", @"/Views/TCustomer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyErp.Models.TCustomer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("SalesArea");

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 134 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class = \"cont-titles\">\r\n <h3>");
#nullable restore
#line 136 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("CustomerList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n</div>\r\n");
#nullable restore
#line 138 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
Write(Html.dataGrid(3,16,@Columns("Customer"),@getData((List<TCustomer>)Model),@Controller(),@Fields("Customer")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
            
    string [] Controller(){
        string [] retur = new string [4];
                retur[0]="TCustomer";
                retur[1]="Edit";
                retur[2]="Create";
                retur[3]="Delete";
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
        switch(table){
            case "Customer":
                retur.Add(addLine("CustId","false"));
                retur.Add(addLine("CampoKy","false"));
                retur.Add(addLine("CustNif","true"));
                retur.Add(addLine("CustCode","true"));
                retur.Add(addLine("CustRasoc","true"));
                retur.Add(addLine("CustAdCity","true"));
                retur.Add(addLine("CustAdCtry","true"));    
                break;
            default:
                break;
        }
        return retur;
    }
    List<string> Columns(string table){
        List<string> retur = new List<string>();
        switch(table){
            case "Customer":
                retur.Add("Customer");
                retur.Add(@SharedLocalizer.GetLocalizedHtmlString("NIF"));
                retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Code"));
                retur.Add(@SharedLocalizer.GetLocalizedHtmlString("RaSoc"));
                retur.Add(@SharedLocalizer.GetLocalizedHtmlString("City"));
                retur.Add(@SharedLocalizer.GetLocalizedHtmlString("Country"));
                break;
            default:
                break;
        }
        return retur;
    }
    public IEnumerable<Container> getData(dynamic oTMaterial)
        {
                    IEnumerable<TCustomer> fTPersonal = (List<TCustomer>)oTMaterial;
                    IEnumerable<Container> TPersonal = fTPersonal.Select(
                        f => new Container() 
                    {
                        CampoId = f.CustId,
                        CampoKy = f.CustId,
                        Campo01 = f.CustNif.ToString(),
                        Campo02 = f.CustCode.ToString(),
                        Campo03 = f.CustRasoc.ToString(),
                        Campo04 = f.CustAdCity.ToString(),
                        Campo05 = f.CustAdCtry.ToString(),
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

string myformat(double? value){
    string ret =string.Format("{0:C2}", value);
    return ret;
}
string mycolor(double? value){
    string retcol="red-number";
    if (value >=0 ){
        retcol="blue-number";}
    return retcol;
    }
string colcolor(int item){
    string retcol="col-text";
    if (item==0)
    {
        retcol="botcol-text";
    }
    return retcol;
    }
string isVisible(){
        int filter =0;
        try{
        filter = (int) ViewData["Filter"];}
        catch{}
        string retcol="";
        if (filter==0){retcol="invisible";}
        else{retcol="visible";}
        return retcol;
    }
string fValue (int valor){
        string ret1="";
        if (valor ==1){
        try{
            ret1 = (string)ViewData["Fil1"];
        }
        catch{}
        }
        else{
        try{
            ret1 = (string)ViewData["Fil2"];
        }
        catch{}
        }
        return ret1;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyErp.Models.TCustomer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
