#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Account\ActiveAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb80fe0d50f0239916aec1c2fb3a5cfca66ffbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ActiveAccount), @"mvc.1.0.view", @"/Views/Account/ActiveAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb80fe0d50f0239916aec1c2fb3a5cfca66ffbe", @"/Views/Account/ActiveAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ActiveAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Account\ActiveAccount.cshtml"
  
    ViewData["Title"] = "فعال سازی حساب کاربری";

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
                        <li class=""breadcrumb_iner_item""><a href=""/Home"">خانه</a></li> /
                        <li class=""breadcrumb_iner_item""><a href=""#"">");
#nullable restore
#line 13 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Account\ActiveAccount.cshtml"
                                                                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                    </ol>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- BreadCrumb End -->\r\n");
            }
            );
            WriteLiteral("<div class=\"container rtl-text\">\r\n");
#nullable restore
#line 22 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Account\ActiveAccount.cshtml"
     if (ViewBag.IsActive)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <p>حساب کاربری شما با موفقیت فعال شد</p>\r\n            <p>\r\n                <a href=\"/Login\">ورود به سایت</a>\r\n            </p>\r\n        </div>\r\n");
#nullable restore
#line 30 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Account\ActiveAccount.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>حساب کاربری با مشخصات ارسال شده یافت نشد</p>\r\n        </div>\r\n");
#nullable restore
#line 36 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Account\ActiveAccount.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
