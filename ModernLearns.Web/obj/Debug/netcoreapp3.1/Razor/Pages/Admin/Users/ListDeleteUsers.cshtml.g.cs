#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1df459afeca9c040743ffb935f931b1a746a4b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Users_ListDeleteUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/ListDeleteUsers.cshtml")]
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
#line 2 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
using ModernLearns.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df459afeca9c040743ffb935f931b1a746a4b73", @"/Pages/Admin/Users/ListDeleteUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Users_ListDeleteUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست کاربران حذف شده</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>


<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست کاربران حذف شده
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""row"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df459afeca9c040743ffb935f931b1a746a4b734811", async() => {
                WriteLiteral(@"
                                <div class=""col-sm-5 col-md-5"">
                                    <input type=""text"" name=""filterUserName"" class=""form-control"" placeholder=""نام کاربری"" />
                                </div>
                                <div class=""col-sm-5 col-md-5"">
                                    <input type=""text"" name=""filterEmail"" class=""form-control"" placeholder=""ایمیل"" />
                                </div>
                                <div class=""col-sm-2 col-md-2"">
                                    <button type=""submit"" class=""btn btn-info"">بگرد</button>
                                    <a class=""btn btn-default btn-sm"" href=""/Admin/Users"">خالی</a>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-12\" style=\"margin: 10px 0;\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df459afeca9c040743ffb935f931b1a746a4b736999", async() => {
                WriteLiteral("افزودن کاربر جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>نام کاربری</th>
                                    <th>ایمیل</th>
                                    <th>وضعیت</th>
                                    <th>تاریخ ثبت نام</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 54 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                 foreach (var user in Model.UserForAdminViewModel.Users)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 57 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 60 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                             if (user.IsActive)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-success\">فعال</p>\r\n");
#nullable restore
#line 63 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-danger\">غیر فعال</p>\r\n");
#nullable restore
#line 67 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 69 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                       Write(user.RegisterDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3503, "\"", 3538, 3);
            WriteAttributeValue("", 3513, "restoreUser(", 3513, 12, true);
#nullable restore
#line 72 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
WriteAttributeValue("", 3525, user.UserId, 3525, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3537, ")", 3537, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">\r\n                                                بازگردانی\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 77 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table><div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate"">
                                    <ul class=""pagination"">

");
#nullable restore
#line 84 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                         for (int i = 1; i <= Model.UserForAdminViewModel.PageCount; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li");
            BeginWriteAttribute("class", " class=\"", 4330, "\"", 4413, 2);
            WriteAttributeValue("", 4338, "paginate_button", 4338, 15, true);
#nullable restore
#line 86 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
WriteAttributeValue(" ", 4353, (i==Model.UserForAdminViewModel.CurrentPage)?"active":"", 4354, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4515, "\"", 4544, 2);
            WriteAttributeValue("", 4522, "/Admin/Users?PageId=", 4522, 20, true);
#nullable restore
#line 87 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
WriteAttributeValue("", 4542, i, 4542, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 89 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        function ChangePage(pageId) {
            $(""#pageId"").val(pageId);
            $(""#filtering"").submit();
        }
        $("".submit-button"").click(function () {
            $(""#pageId"").val(1);
        });

        function restoreUser(id) {
            swal({
                title: ""اخطار !"",
                text: ""آیا از بازگردانی  مطمئن هستید ؟"",
                icon: ""warning"",
                buttons: [""لغو"", ""بله""]
            }).then((isOk) => {
                if (isOk) {
                    $.ajax({
                        url: ""/Admin/Users/ListDeleteUsers/RestoreUser?userId="" + id,
                        type: ""get"",
                        beforeSend: function () {
                            $("".loading"").show();
                        },
                        complete: function () {
                            $("".loading"").hide();
                        }
                    }).done(function (data) {
            ");
                WriteLiteral(@"            if (data === ""Restored"") {
                            swal({
                                title: ""اعملیات با موفقیت انجام شد"",
                                icon: ""success"",
                                button: ""باشه""
                            }).then((isOk) => {
                                location.reload();
                            });
                        } else {
                            swal({
                                title: ""اعملیات به مشکل برخورد کرد"",
                                icon: ""error"",
                                button: ""باشه""
                            });
                        }
                    });
                }
            });

        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModernLearns.Web.Pages.Admin.Users.ListDeleteUsersModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ModernLearns.Web.Pages.Admin.Users.ListDeleteUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ModernLearns.Web.Pages.Admin.Users.ListDeleteUsersModel>)PageContext?.ViewData;
        public ModernLearns.Web.Pages.Admin.Users.ListDeleteUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
