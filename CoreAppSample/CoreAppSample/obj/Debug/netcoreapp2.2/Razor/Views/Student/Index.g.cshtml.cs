#pragma checksum "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9255644bf6b4acbe9ec9ecafea4f9ecafeb7b1d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9255644bf6b4acbe9ec9ecafea4f9ecafeb7b1d8", @"/Views/Student/Index.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAppSample.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 54, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n    <h4>Students</h4>\r\n    ");
            EndContext();
            BeginContext(141, 47, false);
#line 11 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
Write(Html.ActionLink("Create New", "Add", "Student"));

#line default
#line hidden
            EndContext();
            BeginContext(188, 27, true);
            WriteLiteral("\r\n    <hr />\r\n    <table>\r\n");
            EndContext();
#line 14 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
         foreach (CoreAppSample.Models.Student student in Model)
        {

#line default
#line hidden
            BeginContext(292, 41, true);
            WriteLiteral("            <tr>\r\n                <td><b>");
            EndContext();
            BeginContext(334, 38, false);
#line 17 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
                  Write(Html.DisplayNameFor(x => student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(372, 31, true);
            WriteLiteral("</b></td>\r\n                <td>");
            EndContext();
            BeginContext(404, 38, false);
#line 18 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
               Write(Html.DisplayTextFor(x => student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(442, 67, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>");
            EndContext();
            BeginContext(510, 45, false);
#line 21 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
                  Write(Html.DisplayNameFor(x => student.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(555, 31, true);
            WriteLiteral("</b></td>\r\n                <td>");
            EndContext();
            BeginContext(587, 45, false);
#line 22 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
               Write(Html.DisplayTextFor(x => student.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(632, 67, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>");
            EndContext();
            BeginContext(700, 37, false);
#line 25 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
                  Write(Html.DisplayNameFor(x => student.Age));

#line default
#line hidden
            EndContext();
            BeginContext(737, 31, true);
            WriteLiteral("</b></td>\r\n                <td>");
            EndContext();
            BeginContext(769, 37, false);
#line 26 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
               Write(Html.DisplayTextFor(x => student.Age));

#line default
#line hidden
            EndContext();
            BeginContext(806, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(871, 56, false);
#line 29 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = student.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(927, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(955, 60, false);
#line 30 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = student.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 129, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>&nbsp;</td>\r\n                <td>&nbsp;</td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\H288088\Documents\CoreAppSample\CoreAppSample\CoreAppSample\Views\Student\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1155, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAppSample.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
