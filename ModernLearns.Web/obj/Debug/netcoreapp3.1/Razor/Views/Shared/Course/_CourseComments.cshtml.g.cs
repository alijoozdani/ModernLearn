#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8190000265e272438c30462ee0346784fc8ec556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Course__CourseComments), @"mvc.1.0.view", @"/Views/Shared/Course/_CourseComments.cshtml")]
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
#line 2 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
using ModernLearns.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
using System.Text.Unicode;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8190000265e272438c30462ee0346784fc8ec556", @"/Views/Shared/Course/_CourseComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Course__CourseComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModernLearns.Core.DTOs.Course.CourseCommentViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comments-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("send-Comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"top\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8190000265e272438c30462ee0346784fc8ec5564727", async() => {
                WriteLiteral(@"
            <input name=""replay"" id=""reply-comment-id"" type=""hidden"" value=""null"">
            <div class=""form-group"">
                <div class=""input-group mb-3 col-md-12 pull-left"">
                    <textarea type=""text"" class=""form-control"" placeholder=""نظر خود را وارد کنید""
                              onfocus=""this.placeholder = ''""
                              onblur=""this.placeholder = 'نظر ارزشمند خود را وارد کنید'""
                              id=""comment_text"" name=""comment_text"">
</textarea>
                </div>
            </div>
            <div class=""input-group-append"">
                <button class=""btn btn_2"" type=""submit"">ارسال نظر ارزشمند شما</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div id=\"response\"></div>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning rtl-text\">\r\n        برای افزودن کامنت لطفاٌ ابتدا <a href=\"/Login\">وارد</a> سایت شوید!\r\n    </div>\r\n");
#nullable restore
#line 32 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"list-comment\">\r\n");
#nullable restore
#line 35 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
     foreach (var comment in Model.CourseComments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"commetn-box\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1360, "\"", 1406, 2);
            WriteAttributeValue("", 1366, "/img/userAvatar/", 1366, 16, true);
#nullable restore
#line 38 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 1382, comment.User.UserAvatar, 1382, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"userAvatar\">\r\n            <span>ارسال شده در: ");
#nullable restore
#line 39 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                           Write(comment.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h3>توسط: ");
#nullable restore
#line 40 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                 Write(comment.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 42 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
           Write(System.Text.Encodings.Web.HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.Arabic, UnicodeRanges.BasicLatin }).Encode(comment.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <div class=\"action-layer\">\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1802, "\"", 1845, 3);
            WriteAttributeValue("", 1812, "DeleteComment(", 1812, 14, true);
#nullable restore
#line 45 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 1826, comment.CommentId, 1826, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1844, ")", 1844, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"delete-cm\"><i class=\"zmdi zmdi-delete\"></i></a>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1921, "\"", 1963, 3);
            WriteAttributeValue("", 1931, "replyComment(", 1931, 13, true);
#nullable restore
#line 46 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 1944, comment.CommentId, 1944, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1962, ")", 1962, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"edit-cm\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                <!-- set comment id for element\'s id for reply -->\r\n                <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2129, "\"", 2171, 3);
            WriteAttributeValue("", 2139, "replyComment(", 2139, 13, true);
#nullable restore
#line 48 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 2152, comment.CommentId, 2152, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2170, ")", 2170, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"reply-cm\" id=\"cm-3\">\r\n                    <i class=\"zmdi zmdi-mail-reply\"></i>\r\n                </a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
         if (Model.AnswerComments.Any(a => a.Answer == comment.CommentId))
        {
            foreach (var answer in Model.AnswerComments.Where(a => a.Answer == comment.CommentId))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"answer-box\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2586, "\"", 2631, 2);
            WriteAttributeValue("", 2592, "/img/userAvatar/", 2592, 16, true);
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 2608, answer.User.UserAvatar, 2608, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"userAvatar\">\r\n                    <span>ارسال شده در: ");
#nullable restore
#line 59 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                                   Write(answer.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h3>توسط:");
#nullable restore
#line 60 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                        Write(answer.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>\r\n                        ");
#nullable restore
#line 62 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                   Write(System.Text.Encodings.Web.HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.Arabic, UnicodeRanges.BasicLatin }).Encode(answer.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <div class=\"action-layer\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3079, "\"", 3121, 3);
            WriteAttributeValue("", 3089, "DeleteComment(", 3089, 14, true);
#nullable restore
#line 65 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 3103, answer.CommentId, 3103, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3120, ")", 3120, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"delete-cm\"><i class=\"zmdi zmdi-delete\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3205, "\"", 3212, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"edit-cm\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                        <!-- set comment id for element\'s id for reply -->\r\n                        <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3394, "\"", 3436, 3);
            WriteAttributeValue("", 3404, "replyComment(", 3404, 13, true);
#nullable restore
#line 68 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 3417, comment.CommentId, 3417, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3435, ")", 3435, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"reply-cm\" id=\"cm-3\">\r\n                            <i class=\"zmdi zmdi-mail-reply\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 73 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--pagign-->\r\n");
#nullable restore
#line 78 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
     if (Model.PageCount > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row align-items-center padding_top\">\r\n            <ul class=\"pagination pg-amber\">\r\n                <!--Arrow left-->\r\n");
#nullable restore
#line 83 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                 if (Model.CurrentPage > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3980, "\"", 4024, 3);
            WriteAttributeValue("", 3990, "ChangePage(", 3990, 11, true);
#nullable restore
#line 86 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 4001, Model.CurrentPage-1, 4001, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4023, ")", 4023, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link waves-effect\" aria-label=\"Previous\">\r\n                            <span aria-hidden=\"true\">«</span>\r\n                            <span class=\"sr-only\">Previous</span>\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 91 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <!--Numbers-->\r\n");
#nullable restore
#line 95 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                 for (var i = Model.StartPage; i <= Model.EndPage; i++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 4440, "\"", 4507, 1);
#nullable restore
#line 98 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 4448, (i==Model.CurrentPage)? "page-item active" : "page-item", 4448, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("onclick", " onclick=\"", 4511, "\"", 4535, 3);
            WriteAttributeValue("", 4521, "ChangePage(", 4521, 11, true);
#nullable restore
#line 98 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 4532, i, 4532, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4534, ")", 4534, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link waves-effect\">");
#nullable restore
#line 98 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 99 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--Arrow right-->\r\n");
#nullable restore
#line 102 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                 if (Model.CurrentPage >= 1 && Model.PageCount > Model.CurrentPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4812, "\"", 4856, 3);
            WriteAttributeValue("", 4822, "ChangePage(", 4822, 11, true);
#nullable restore
#line 105 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
WriteAttributeValue("", 4833, Model.CurrentPage+1, 4833, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4855, ")", 4855, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link waves-effect\" aria-label=\"Next\">\r\n                            <span aria-hidden=\"true\">»</span>\r\n                            <span class=\"sr-only\">Next</span>\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 110 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n");
#nullable restore
#line 114 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Course\_CourseComments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModernLearns.Core.DTOs.Course.CourseCommentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
