#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d722516e66401bf189b6abe1471f611818436c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TMRP__pListaCustPlan), @"mvc.1.0.view", @"/Views/TMRP/_pListaCustPlan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d722516e66401bf189b6abe1471f611818436c", @"/Views/TMRP/_pListaCustPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TMRP__pListaCustPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VCCplanning>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Show planing records -->\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateFrom,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateFrom, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.LabelFor(p => p.CplanDateTo,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.EditorFor(p => p.CplanDateTo, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><input type=\"submit\" value=\"Go\"  name=\"actionType\"/></td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <input type=\"hidden\" value=\"2\"  name=\"panel1\"/>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
           Write(Html.ValidationMessageFor(p => p.CplanDateTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=", 1290, "", 1310, 1);
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 1297, isVisible(1), 1297, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <table class=""table-norm"" border=""1"">
    <div class=""cont-titles"">
    <h2>>Planning Data</h2>
    </div>
    <tr>
        <th class=""head-text"">Cust.Code</th> 
        <th class=""head-text"">Plant.Code</th>                
        <th class=""head-text"">Reference</th>        
        <th class=""head-text"">Description</th>        
        <th class=""head-text"">From</th>        
        <th class=""head-text"">To</th>        
        <th class=""head-text"">Qty</th>        
    </tr>
");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
     foreach ( VCCplanning  c in (List<VCCplanning>)ViewBag.ListCustPlan) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 51 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                             Write(c.CplanCustCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                             Write(c.CplanCplantCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.CplanCprodRefInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 54 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.CplanCprodDescInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 55 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.CplanDateFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 56 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.CplanDateTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.CplanQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
            WriteLiteral("</div>\r\n\r\n<!--Show Capacity results-->\r\n\r\n<div");
            BeginWriteAttribute("class", " class=", 2847, "", 2867, 1);
#nullable restore
#line 74 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
WriteAttributeValue("", 2854, isVisible(2), 2854, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <table class=""table-norm"" border=""1"">
    <div class=""cont-titles"">
    <h2>>Requirements of Materials</h2>
    </div>
    <tr>
        <th class=""head-text"">Material</th> 
        <th class=""head-text"">Description</th>                
        <th class=""head-text"">Quantity</th>        
        <th class=""head-text"">U.M.</th>        
    </tr>
   
");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
     foreach ( TExpMater  c in (List<TExpMater>)ViewBag.ListMatExp) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                             Write(c.MatRefer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 89 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                             Write(c.MatDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 90 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.TcomQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 91 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.MatUnMed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       \r\n        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <tr>\r\n        <th class=\"head-text\">WorkCenter</th> \r\n        <th class=\"head-text\">Description</th>                \r\n        <th class=\"head-text\">Occupation</th>        \r\n    </tr>\r\n   \r\n");
#nullable restore
#line 102 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
     foreach ( TExpOper  c in (List<TExpOper>)ViewBag.ListOpeExp) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\">");
#nullable restore
#line 104 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                             Write(c.Wccode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\">");
#nullable restore
#line 105 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                             Write(c.Wcdescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 106 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
                              Write(c.OperTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 108 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    ");
#nullable restore
#line 110 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
Write(Html.ActionLink("Return to Capacity Analysis", "Index",new{panel =1,panel1=1}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\_pListaCustPlan.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel1"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
        return retcol;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VCCplanning> Html { get; private set; }
    }
}
#pragma warning restore 1591
