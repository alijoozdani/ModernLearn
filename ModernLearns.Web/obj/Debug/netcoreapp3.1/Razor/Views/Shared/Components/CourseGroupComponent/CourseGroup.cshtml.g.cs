#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a03e2de1b7bfb3df2ea5ff87dd4a51a0950c6703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CourseGroupComponent_CourseGroup), @"mvc.1.0.view", @"/Views/Shared/Components/CourseGroupComponent/CourseGroup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03e2de1b7bfb3df2ea5ff87dd4a51a0950c6703", @"/Views/Shared/Components/CourseGroupComponent/CourseGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CourseGroupComponent_CourseGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModernLearns.DataLayer.Entities.Course.CourseGroup>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a class=\"nav-link dropdown-toggle classes\"");
            BeginWriteAttribute("href", " href=\"", 117, "\"", 124, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"menuDropdown\"\r\n   role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n    آموزش ها\r\n</a>\r\n<div class=\" rtl-text\" aria-labelledby=\"navbarDropdown\" id=\"toggle-navbar\">\r\n");
#nullable restore
#line 8 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
     foreach (var group in Model.Where(g => g.ParentId == null))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul id=\"subNavbar\">\r\n            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 465, "\"", 509, 2);
            WriteAttributeValue("", 472, "/Course?selectedGroups=", 472, 23, true);
#nullable restore
#line 12 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
WriteAttributeValue("", 495, group.GroupId, 495, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 13 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
               Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"dropdown-toggle\"></i>\r\n                </a>\r\n");
#nullable restore
#line 15 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
                 if (Model.Any(g => g.ParentId == group.GroupId))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul>\r\n");
#nullable restore
#line 18 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
                         foreach (var sub in Model.Where(g => g.ParentId == group.GroupId))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 948, 2);
            WriteAttributeValue("", 913, "/Course?selectedGroups=", 913, 23, true);
#nullable restore
#line 21 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
WriteAttributeValue("", 936, sub.GroupId, 936, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
                                                                         Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 23 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 25 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n        </ul>\r\n");
#nullable restore
#line 28 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Shared\Components\CourseGroupComponent\CourseGroup.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModernLearns.DataLayer.Entities.Course.CourseGroup>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
