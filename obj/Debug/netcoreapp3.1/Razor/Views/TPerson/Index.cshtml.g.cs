#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f6608f459f0258681b0dcc4d4c1edd51672322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_Index), @"mvc.1.0.view", @"/Views/TPerson/Index.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/_ViewImports.cshtml"
using MyErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/_ViewImports.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f6608f459f0258681b0dcc4d4c1edd51672322", @"/Views/TPerson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyErp.Models.TPerson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
  
    ViewData["Title"] = "HR Area Index Page";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\n\n");
            }
            );
            WriteLiteral("\n<h1>");
#nullable restore
#line 57 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<div class = \"cont-titles\">\n <h2>Person Table</h2>   \n</div>\n<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f6608f459f0258681b0dcc4d4c1edd516723225712", async() => {
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
            WriteLiteral("</td>\n<div");
            BeginWriteAttribute("class", " class=\"", 1408, "\"", 1428, 1);
#nullable restore
#line 62 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
WriteAttributeValue("", 1416, isVisible(), 1416, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 63 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
     using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <input type=\"hidden\" name=\"Filter\" value=\"2\"/>\n            <td>Filtrar por Nombre:</td>\n            <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value =\"", 1617, "\"", 1636, 1);
#nullable restore
#line 67 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
WriteAttributeValue("", 1626, fValue(1), 1626, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"norm-text\" id=\"pNam\" name=\"pNam\" type=\"text\"></input></td>\n            <td> Apellidos:</td>\n            <td class =\"norm-text\"><input");
            BeginWriteAttribute("value", " value=\"", 1778, "\"", 1796, 1);
#nullable restore
#line 69 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
WriteAttributeValue("", 1786, fValue(2), 1786, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class =\"norm-text\" id=\"pNam1\" name=\"pNam1\" type=\"text\"></input></td>\n            <td><input type=\"submit\" value=\"Filter\" /></td>\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\n        </tr>\n");
#nullable restore
#line 73 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""visible"">
<table class=""table-norm"" border=""1"">
    <tr>
        <th class=""head-text"">Name</th> 
        <th class=""head-text"">SurName</th>                
        <th class=""head-text"">DNI</th>        
        <th class=""head-text"">Address</th>
        <th class=""head-text"">Country</th>
        <th class=""head-text"">Delete</th>        
        <th class=""head-text"">Edit</th>        
    </tr>
");
#nullable restore
#line 86 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
     foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td class =\"col-text\">");
#nullable restore
#line 88 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                             Write(p.PerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \n            <td class =\"norm-text\">");
#nullable restore
#line 89 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                              Write(p.PerName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class =\"norm-text\">");
#nullable restore
#line 90 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                              Write(p.PerDni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class =\"norm-text\">");
#nullable restore
#line 91 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                              Write(p.PerAddr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class =\"norm-text\">");
#nullable restore
#line 92 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                              Write(p.PerAddCtry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"col-text\">");
#nullable restore
#line 93 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                            Write(Html.ActionLink("Delete", "Delete", new { id = p.PerId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"col-text\">");
#nullable restore
#line 94 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
                            Write(Html.ActionLink("Edit", "Edit", new { id = p.PerId ,panel=1,skip =0}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            \n        </tr>\n");
#nullable restore
#line 97 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 99 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
Write(Html.ActionLink("Add a New Item", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/Index.cshtml"
            
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyErp.Models.TPerson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
