#pragma checksum "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9b176b5903599025369e140cb1af4e566172c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestionAnswer_Index), @"mvc.1.0.view", @"/Views/QuestionAnswer/Index.cshtml")]
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
#line 1 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\_ViewImports.cshtml"
using OnlineExaminationWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\_ViewImports.cshtml"
using OnlineExaminationWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\_ViewImports.cshtml"
using OnlineExaminationViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9b176b5903599025369e140cb1af4e566172c6", @"/Views/QuestionAnswer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f817da41174ab5763c8b1e74c14948286c360041", @"/Views/_ViewImports.cshtml")]
    public class Views_QuestionAnswer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<OnlineExaminationViewModels.QuestionAnswerViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuestionAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pagenumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-item disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Exam Papers</h1>\r\n\r\n<div>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9b176b5903599025369e140cb1af4e566172c67171", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div>
        <table id=""tbl-questionanswer"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Questions</th>
                    <th>Option 1</th>
                    <th>Option 2</th>
                    <th>Option 3</th>
                    <th>Option 4</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                 foreach (var item in Model.Data)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                       Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                       Write(item.Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                       Write(item.Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                       Write(item.Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                       Write(item.Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9b176b5903599025369e140cb1af4e566172c611298", async() => {
                WriteLiteral("\r\n        ");
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#nullable restore
#line 36 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = (int)Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = (int)Model.PageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\Lessons\ASP.NET\Educational Examples\OnlineExaminationSystem\OnlineExaminationWeb\Views\QuestionAnswer\Index.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = (int)Model.TotalItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("cs-pager-li-non-active", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("script", async() => {
                WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'tbl-questionanswer\').DataTable({\r\n            \"paging\": false,\r\n            \"filter\": true\r\n        });\r\n    });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<OnlineExaminationViewModels.QuestionAnswerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591