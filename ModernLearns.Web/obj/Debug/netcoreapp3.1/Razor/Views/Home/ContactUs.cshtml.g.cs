#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aac69b0f3ff19fb6f80d4b8f98fc54ef9e52734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aac69b0f3ff19fb6f80d4b8f98fc54ef9e52734", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModernLearns.DataLayer.Entities.ContactUs.ContactUs>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ContactUsForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
  
    ViewData["Title"] = "???????? ????????";
    var isSuccess = TempData["Success"] != null;

#line default
#line hidden
#nullable disable
            DefineSection("Topic_Layer", async() => {
                WriteLiteral(@"
    <!-- BreadCrumb start -->
    <div class=""container breadcrumb"">
        <div class=""row align-items-center"">
            <div class=""col-md-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb_iner"">
                        <li class=""breadcrumb_iner_item""><a href=""/Home"">????????</a></li> /
                        <li class=""breadcrumb_iner_item""><a href=""#"">");
#nullable restore
#line 14 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                                                                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                    </ol>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- BreadCrumb End -->\r\n");
            }
            );
            WriteLiteral(@"<!-- ContactUs Start -->
<div class=""container section_padding"">
    <div class=""col-md-12"">
        <div class=""row"">
            <div class=""contact-info"">
                <div class=""media-body"">
                    <h3>???????? ????????</h3>
                    <p>
                        ");
#nullable restore
#line 30 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12 contact-info-col"">
                        <section class=""shadow-style"">
                            <h2><i class=""zmdi zmdi-pin""></i> ?????????? ???? </h2>
                            <p> ");
#nullable restore
#line 37 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </section>
                    </div>
                    <div class=""col-md-4 col-sm-12 col-xs-12 contact-info-col"">
                        <section class=""shadow-style"">
                            <h2><i class=""zmdi zmdi-phone-in-talk""></i> ?????????? ???????? ?? ?????????? </h2>
                            <ul>
                                <li>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1817, "\"", 1846, 2);
            WriteAttributeValue("", 1824, "tel:", 1824, 4, true);
#nullable restore
#line 45 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
WriteAttributeValue("", 1828, Model.PhoneNumber, 1828, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 45 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                                                                 Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> -\r\n                                </li>\r\n                                <li> ");
#nullable restore
#line 47 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </li>
                            </ul>
                        </section>
                    </div>
                    <div class=""col-md-4 col-sm-12 col-xs-12 contact-info-col"">
                        <section class=""shadow-style"">
                            <h2><i class=""zmdi zmdi-time""></i> ?????????? ???????????????? </h2>
                            <ul>
");
#nullable restore
#line 55 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                                 foreach (var item in Model.ResponseTime.Split('-'))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 57 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </section>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3aac69b0f3ff19fb6f80d4b8f98fc54ef9e527348515", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 65 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- ContactUs End -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n\r\n    <script src=\"/js/jquery.validate.min.js\"></script>\r\n    <script src=\"/js/jquery.unobtrusive-ajax.min.js\"></script>\r\n\r\n");
#nullable restore
#line 78 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"
     if (isSuccess)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <script>
            swal({
                title: ""???????? ?????? ???? ???????????? ?????????? ????"",
                text: ""???????? ???? ???????? ?????????? ???????? ?????? ?????????? ?????????? ????"",
                icon: ""success"",
                button: ""????????""
            });
        </script>
");
#nullable restore
#line 88 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Home\ContactUs.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModernLearns.DataLayer.Entities.ContactUs.ContactUs> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
