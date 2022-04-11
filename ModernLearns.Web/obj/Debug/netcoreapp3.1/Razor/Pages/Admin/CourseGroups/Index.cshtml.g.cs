#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2afd712ef1bcc2a0b821edf292dc9c5e2830a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_CourseGroups_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/CourseGroups/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2afd712ef1bcc2a0b821edf292dc9c5e2830a4", @"/Pages/Admin/CourseGroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_CourseGroups_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">درباره ما</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                درباره ما
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2afd712ef1bcc2a0b821edf292dc9c5e2830a44299", async() => {
                WriteLiteral("افزودن");
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
                                    <th>عنوان گروه</th>
                                    <th>زیر گروه ها</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 37 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                 foreach (var group in Model.CourseGroups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 40 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                       Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 42 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                             if (group.CourseGroups.Any())
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <ul>\r\n");
#nullable restore
#line 45 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                     foreach (var sub in group.CourseGroups)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li>\r\n                                                        ");
#nullable restore
#line 48 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                   Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -    \r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 2210, "\"", 2259, 2);
            WriteAttributeValue("", 2217, "/Admin/CourseGroups/EditGroup/", 2217, 30, true);
#nullable restore
#line 49 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2247, sub.GroupId, 2247, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline btn-warning btn-xs\">\r\n                                                            ویرایش\r\n                                                        </a> -\r\n                                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2496, "\"", 2531, 3);
            WriteAttributeValue("", 2506, "deleteGroup(", 2506, 12, true);
#nullable restore
#line 52 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2518, sub.GroupId, 2518, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2530, ")", 2530, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline btn-danger btn-xs\">\r\n                                                           حذف\r\n                                                        </a>\r\n                                                    </li>\r\n");
#nullable restore
#line 56 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3058, "\"", 3111, 2);
            WriteAttributeValue("", 3065, "/Admin/CourseGroups/CreateGroup/", 3065, 32, true);
#nullable restore
#line 61 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 3097, group.GroupId, 3097, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">\r\n                                                زیر گروه\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3297, "\"", 3348, 2);
            WriteAttributeValue("", 3304, "/Admin/CourseGroups/EditGroup/", 3304, 30, true);
#nullable restore
#line 64 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 3334, group.GroupId, 3334, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                                ویرایش\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3535, "\"", 3572, 3);
            WriteAttributeValue("", 3545, "deleteGroup(", 3545, 12, true);
#nullable restore
#line 67 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 3557, group.GroupId, 3557, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3571, ")", 3571, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                                                حذف\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 72 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
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
    <script src=""/js/script.js""></script>
    <script type=""text/javascript"">

    function deleteGroup(id) {
        swal({
            title: ""اخطار !"",
            text: ""آیا از حذف  مطمئن هستید ؟"",
            icon: ""warning"",
            buttons: [""لغو"", ""بله""]
        }).then((isOk) => {
            if (isOk) {
                $.ajax({
                    url: ""/Admin/CourseGroups/DeleteGroup?groupId="" + id,
                    type: ""get"",
                    beforeSend: function () {
                        $("".loading"").show();
                    },
                    complete: function () {
                        $("".loading"").hide();
                    }
                }).done(function (data) {
                    if (data === ""Deleted"") {
                        swal({
                            title: ""اعملیات با موفقیت انجام شد"",
                            icon: ""success"",
                            button: ""باشه""
                        }).then((isOk) => {
 ");
                WriteLiteral(@"                           location.reload();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModernLearns.Web.Pages.Admin.CourseGroups.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ModernLearns.Web.Pages.Admin.CourseGroups.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ModernLearns.Web.Pages.Admin.CourseGroups.IndexModel>)PageContext?.ViewData;
        public ModernLearns.Web.Pages.Admin.CourseGroups.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
