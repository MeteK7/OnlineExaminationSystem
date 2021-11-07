#pragma checksum "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee3c9d1aefb8e26725c72463cc93e5c11a2e793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_ViewResult), @"mvc.1.0.view", @"/Views/Students/ViewResult.cshtml")]
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
#line 1 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\_ViewImports.cshtml"
using OnlineExaminationWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\_ViewImports.cshtml"
using OnlineExaminationWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\_ViewImports.cshtml"
using OnlineExaminationViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3c9d1aefb8e26725c72463cc93e5c11a2e793", @"/Views/Students/ViewResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f817da41174ab5763c8b1e74c14948286c360041", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_ViewResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineExaminationViewModels.ResultViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
  
    ViewData["Title"] = "ViewResult";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Exam Results</h1>

<div>
    <br />
    <div>
        <table id=""grid-result"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Exam Name</th>
                    <th>Total Questions</th>
                    <th>Correct</th>
                    <th>Wrong</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
                   Write(item.ExamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
                   Write(item.TotalQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
                   Write(item.CorrectAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
                   Write(item.WrongAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "F:\Projects\OnlineExaminationSystem\OnlineExaminationWeb\Views\Students\ViewResult.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee3c9d1aefb8e26725c72463cc93e5c11a2e7936130", async() => {
                WriteLiteral("Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineExaminationViewModels.ResultViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
