#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a174f21dab27c478275bba437bff2eaf831a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_Index), @"mvc.1.0.view", @"/Views/TSuplier/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a174f21dab27c478275bba437bff2eaf831a1c", @"/Views/TSuplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyErp.Models.TSuplier>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TSuplier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
  
    ViewData["Title"] = "Purchasing Area";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class = \"cont-titles\">\r\n <h3>");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("SupList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>   \r\n</div>\r\n<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13a174f21dab27c478275bba437bff2eaf831a1c6209", async() => {
#nullable restore
#line 64 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                                                                                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Filter"));

#line default
#line hidden
#nullable disable
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
            BeginWriteAttribute("class", " class=\"", 1611, "\"", 1631, 1);
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
WriteAttributeValue("", 1619, isVisible(), 1619, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
     using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <input type=\"hidden\" name=\"Filter\" value=\"2\"/>\r\n            <td>");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("FilterByRaSoc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value =\"", 1863, "\"", 1882, 1);
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
WriteAttributeValue("", 1872, fValue(1), 1872, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"norm-text\" id=\"pNam\" name=\"pNam\" type=\"text\"></input></td>\r\n            <td>");
#nullable restore
#line 71 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("FilterByNIF"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value=\"", 2069, "\"", 2087, 1);
#nullable restore
#line 72 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
WriteAttributeValue("", 2077, fValue(2), 2077, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class =\"norm-text\" id=\"pNam1\" name=\"pNam1\" type=\"text\"></input></td>\r\n            <td><input type=\"submit\" value=\"Filter\" /></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"visible\">\r\n<table class=\"table-norm\" border=\"1\">\r\n    <tr>\r\n        <th class=\"head-text\">");
#nullable restore
#line 81 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("NIF"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n        <th class=\"head-text\">");
#nullable restore
#line 82 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                \r\n        <th class=\"head-text\">");
#nullable restore
#line 83 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupRaSoc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 84 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupCity"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"head-text\">");
#nullable restore
#line 85 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("SupCountry"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"head-text\">");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th class=\"head-text\">");
#nullable restore
#line 87 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                         Write(SharedLocalizer.GetLocalizedHtmlString("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n    </tr>\r\n");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
     foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 91 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                             Write(p.SupNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"norm-text\">");
#nullable restore
#line 92 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                              Write(p.SupCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 93 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                              Write(p.SupRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 94 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                              Write(p.SupAdCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                              Write(p.SupAdCtry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 96 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                            Write(Html.ActionLink("Delete", "Delete", new { id = p.SupId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 97 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
                            Write(Html.ActionLink("Edit", "Edit", new { id = p.SupId ,panel=1,skip =0}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 102 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
Write(Html.ActionLink("Add a New Item", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\Index.cshtml"
            
    string myformat(double? value){
    string ret =string.Format("{0:C2}", value);
    //string rets = value.ToString("N", CultureInfo.InvariantCulture);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyErp.Models.TSuplier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
