#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94fef5ebf3cee6132d11877ee6f9a692b02f193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TMRP_ScView), @"mvc.1.0.view", @"/Views/TMRP/ScView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94fef5ebf3cee6132d11877ee6f9a692b02f193", @"/Views/TMRP/ScView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TMRP_ScView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Show planing records -->

<div class=""visible"">
    <table class=""table-norm"" border=""1"">
    <div class=""cont-titles"">
    <h2>>Planning Data</h2>
    </div>
    <tr>
        <th class=""head-text"">ShopWctr</th> 
        <th class=""head-text"">ShopFG</th>       
        <th class=""head-text"">ShopCProdId</th>       
        <th class=""head-text"">ShopDest</th>       
        <th class=""head-text"">ShopDate</th>       
        <th class=""head-text"">ShopQty</th>       
        <th class=""head-text"">ShopTUnit</th>       
        <th class=""head-text"">ShopaTUnit</th>       
        <th class=""head-text"">ShopMinLot</th>       
        <th class=""head-text"">ShopUEmb</th>       
    </tr>
");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
     foreach ( ViScShop  c in (List<ViScShop>) ViewBag.ListScShop) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class =\"col-text\" style=\"width: 17%;\">");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                 Write(c.ShopWDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"big-text\" style=\"width: 5%;\">");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                Write(c.ShopFg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\" style=\"width: 17%;\">");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                  Write(c.ShopMDescr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\" style=\"width: 17%;\">");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                  Write(Destin(@c.ShopFg,@c.ShopTrDeno,@c.ShopDDescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\" style=\"width: 17%;\">");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                  Write(c.ShopDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-num\" style=\"width: 5%;\">");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                Write(c.ShopQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-num\" style=\"width: 5%;\">");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                Write(c.ShopTunit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class =\"norm-num\" style=\"width: 5%;\">");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                Write(c.ShopaTunit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-num\" style=\"width: 5%;\">");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                Write(c.ShopMinLot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-num\" style=\"width: 5%;\">");
#nullable restore
#line 48 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
                                                Write(c.ShopUemb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TMRP\ScView.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel1"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
        return retcol;
    }
    string @Destin(string ShopFg,string ShopTrDeno,string ShopDDescr)
    {
        string retorno="";
        if (ShopFg=="TP"){retorno=ShopTrDeno;}else{retorno=ShopDDescr;}
        return retorno;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
