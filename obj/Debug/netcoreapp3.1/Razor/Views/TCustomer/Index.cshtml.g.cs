#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd3aa33df2cc15df07f45668dc79fa5fe8b4d20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TCustomer_Index), @"mvc.1.0.view", @"/Views/TCustomer/Index.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\_ViewImports.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd3aa33df2cc15df07f45668dc79fa5fe8b4d20", @"/Views/TCustomer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TCustomer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyErp.Models.TCustomer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-filter", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pNam", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pNam1", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
  
    ViewData["Title"] = "Customer Area Index Page";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class = \"cont-titles\">\r\n <h2>Customers Table</h2>   \r\n</div>\r\n<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd3aa33df2cc15df07f45668dc79fa5fe8b4d205812", async() => {
                WriteLiteral("Filter");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filter", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filter"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pNam"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pNam1"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n<div");
            BeginWriteAttribute("class", " class=\"", 1410, "\"", 1430, 1);
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
WriteAttributeValue("", 1418, isVisible(), 1418, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
     using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <input type=\"hidden\" name=\"Filter\" value=\"2\"/>\r\n            <td>Filtrar por Razon Social:</td>\r\n            <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value =\"", 1630, "\"", 1649, 1);
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
WriteAttributeValue("", 1639, fValue(1), 1639, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"norm-text\" id=\"pNam\" name=\"pNam\" type=\"text\"></input></td>\r\n            <td> NIF:</td>\r\n            <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value=\"", 1787, "\"", 1805, 1);
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
WriteAttributeValue("", 1795, fValue(2), 1795, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class =\"norm-text\" id=\"pNam1\" name=\"pNam1\" type=\"text\"></input></td>\r\n            <td><input type=\"submit\" value=\"Filter\" /></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""visible"">
<table class=""table-norm"" border=""1"">
    <tr>
        <th class=""head-text"">NIF</th> 
        <th class=""head-text"">Code</th>                
        <th class=""head-text"">Razon Social</th>        
        <th class=""head-text"">City</th>
        <th class=""head-text"">Country</th>
        <th class=""head-text"">Delete</th>        
        <th class=""head-text"">Edit</th>        
    </tr>
");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
     foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 87 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                             Write(p.CustNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"norm-text\">");
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                              Write(p.CustCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                              Write(p.CustRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 90 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                              Write(p.CustAdCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 91 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                              Write(p.CustAdCtry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 92 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                            Write(Html.ActionLink("Delete", "Delete", new { id = p.CustId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 93 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
                            Write(Html.ActionLink("Edit", "Edit", new { id = p.CustId ,panel=1,skip =0}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 96 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
Write(Html.ActionLink("Add a New Item", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TCustomer\Index.cshtml"
            
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
