#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9813759d75b3c8a421f2302f43d7de030c7bc6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_TraEdit), @"mvc.1.0.view", @"/Views/TPerson/TraEdit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9813759d75b3c8a421f2302f43d7de030c7bc6d", @"/Views/TPerson/TraEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_TraEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPTrain>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
  
    Layout = "_LayPer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"style-data\">\r\n<h3>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("TrainingEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
Write(Html.HiddenFor(p => p.TrainId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
Write(Html.HiddenFor(p => p.TrainPerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table class=""table-edit"" border=""0"">
        <hr style=""width:100%;text-align:left;margin-left:0"">
       <tr>
            <td>
            <input type=""submit"" value=""Update""  class=""dropbtn"" name=""actionType""/>
            <input type=""submit"" value=""Cancel"" class=""dropbtn"" name=""actionType""/>
            </td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.LabelFor(p => p.TrainDate,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.EditorFor(p => p.TrainDate, new { htmlAttributes = new { @class = "norm-tb-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.TrainDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.LabelFor(p => p.TrainArea,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.EditorFor(p => p.TrainArea, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:125px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.TrainArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.LabelFor(p => p.TrainCourse,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.EditorFor(p => p.TrainCourse, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:125px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.TrainCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.LabelFor(p => p.TrainCalif,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.EditorFor(p => p.TrainCalif, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.TrainCalif));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.LabelFor(p => p.TrainObser,new { @class = "norm-lab-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.EditorFor(p => p.TrainObser, new { htmlAttributes = new { @class = "norm-tb-text", @style = "width:450px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.TrainObser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\mgdel\VSProjects\MyErp\Views\TPerson\TraEdit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPTrain> Html { get; private set; }
    }
}
#pragma warning restore 1591
