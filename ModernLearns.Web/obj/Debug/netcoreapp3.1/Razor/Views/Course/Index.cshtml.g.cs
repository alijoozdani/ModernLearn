#pragma checksum "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561c4118b01773d717902ba40164663b2a612e24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 2 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
using ModernLearns.Core.DTOs.Course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
using ModernLearns.DataLayer.Entities.Course;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"561c4118b01773d717902ba40164663b2a612e24", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<ShowCourseListItemViewModel>, int>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
  
    ViewData["Title"] = ViewBag.groupTitle;

#line default
#line hidden
#nullable disable
            DefineSection("StyleLink", async() => {
                WriteLiteral(" \r\n    <link rel=\"stylesheet\" href=\"/noUiSlider/nouislider.min.css\">\r\n");
            }
            );
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
#line 18 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                    </ol>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- BreadCrumb End -->\r\n");
            }
            );
            WriteLiteral("<!-- Filtering & Product start -->\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "561c4118b01773d717902ba40164663b2a612e246990", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"pageid\" name=\"pageId\"");
                BeginWriteAttribute("value", " value=\"", 1051, "\"", 1085, 1);
#nullable restore
#line 29 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 1059, ViewBag.pageId.ToString(), 1059, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <section class=\"term-categories\">\r\n            <div class=\"top-bar\">\r\n\r\n                <header>\r\n                    <h1> ???????? ?????? <span> ");
#nullable restore
#line 34 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                    Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span> </h1> <span><a class=\"btn_1\"> ");
#nullable restore
#line 34 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                             Write(Model.Item1.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ????????</a> </span>
                </header>

                <div class=""row"">

                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"" id=""filter"">
                            <div class=""input"">
                                <input type=""text"" name=""filter"" placeholder=""?????????? ???????? ?????? ..."">
                                <button><i class=""zmdi zmdi-search""></i></button>
                            </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available""  onclick=""subForm()"">
                            <input id=""available-filter-1"" name=""getType"" value=""all"" ");
#nullable restore
#line 47 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                  Write((ViewBag.getType=="all")?"checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"radio\">\r\n                            <label for=\"available-filter-1\"> ?????? </label>\r\n                            <input id=\"available-filter-2\" name=\"getType\" value=\"buy\" ");
#nullable restore
#line 49 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                  Write((ViewBag.getType=="buy")?"checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"radio\">\r\n                            <label for=\"available-filter-2\"> ???????????? </label>\r\n                            <input id=\"available-filter-3\" name=\"getType\" value=\"free\" ");
#nullable restore
#line 51 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                   Write((ViewBag.getType=="free")?"checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@" type=""radio"">
                            <label for=""available-filter-3""> ???????????? </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""orderByType"" onchange=""subForm()"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "561c4118b01773d717902ba40164663b2a612e2411086", async() => {
                    WriteLiteral(" ???????? ???????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "561c4118b01773d717902ba40164663b2a612e2412138", async() => {
                    WriteLiteral(" ?????????? ???????? ?????????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "561c4118b01773d717902ba40164663b2a612e2413406", async() => {
                    WriteLiteral(" ?????????? ???????????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">

                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">

                    <section class=""aside-section filter-by-price"">
                        <header>
                            <h3> ?????????? ???? ???????? ???????? </h3>
                        </header>
                        <div class=""price-range"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3639, "\"", 3647, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"min-value\" name=\"startPrice\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3732, "\"", 3740, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""max-value"" name=""endPrice"">
                            <div class=""price-bar"">
                                <div id=""priceFilter""></div>
                            </div>
                            <div class=""max-price"">???? <span id=""max-text"">500000</span> ??????????</div>
                            <div class=""min-price"">???? <span id=""min-text"">20000</span> ??????????</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>

                    <section class=""aside-section filter-by-category"">
                        <header>
                            <h3> ???????? ???????? ?????????????? </h3>
                            <i id=""dropdown-cat"" class=""zmdi zmdi-chevron-down""></i>
                        </header>
                        <div class=""inner"">
");
#nullable restore
#line 93 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                              
                                List<CourseGroup> groups = ViewBag.Groups as List<CourseGroup>;
                                List<int> selected = ViewBag.selectedGroups as List<int>;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <ul>\r\n");
#nullable restore
#line 98 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                 foreach (var group in groups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <input onchange=\"changeGroup()\" type=\"checkbox\" ");
#nullable restore
#line 101 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == group.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"selectedGroups\" value=\"");
#nullable restore
#line 101 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                                                                                                            Write(group.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                        <label for=\"cat-1\"> ");
#nullable restore
#line 102 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                       Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 103 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                         if (groups.Any(g => g.ParentId == group.GroupId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <ul>\r\n");
#nullable restore
#line 106 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                 foreach (var sub in groups.Where(g => g.ParentId == group.GroupId))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <li>\r\n                                                        <input onchange=\"changeGroup()\" ");
#nullable restore
#line 109 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == sub.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
#nullable restore
#line 109 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                                                                                                                          Write(sub.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                                        <label for=\"cat-1\"> ");
#nullable restore
#line 110 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                       Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                                                    </li>\r\n");
#nullable restore
#line 112 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </ul>\r\n");
#nullable restore
#line 114 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 117 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                    </section>

                </aside>

                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                    <section class=""special_cource bottom-padding"">
                        <div class=""container"">
                            <div class=""row rtl-text"">
");
#nullable restore
#line 128 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                 foreach (var item in Model.Item1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "561c4118b01773d717902ba40164663b2a612e2422477", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 130 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

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
                WriteLiteral("\r\n");
#nullable restore
#line 131 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"row align-items-center padding_top\">\r\n                                <ul class=\"pagination pg-amber\">\r\n");
#nullable restore
#line 135 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                     if (Model.Item2 > 1)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <!--Arrow left-->\r\n");
                WriteLiteral("                                        <!--Numbers-->\r\n");
#nullable restore
#line 146 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                        for (int i = 1; i <= (int)Model.Item2; i++)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li");
                BeginWriteAttribute("class", " class=\"", 7946, "\"", 8007, 1);
#nullable restore
#line 148 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 7954, (ViewBag.PageId==i)?"page-item active":"page-item", 7954, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a class=\"page-link waves-effect\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8042, "\"", 8066, 3);
                WriteAttributeValue("", 8052, "changePage(", 8052, 11, true);
#nullable restore
#line 148 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 8063, i, 8063, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8065, ")", 8065, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 148 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 149 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                        }


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <!--Arrow right-->\r\n");
#nullable restore
#line 157 "D:\Workspace\C#\Asp.NetCore\ModernLearn\ModernLearns\ModernLearns.Web\Views\Course\Index.cshtml"
                                               
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<!-- Filtering & Product end -->\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/noUiSlider/nouislider.min.js""></script>
    <script src=""/js/script.js""></script>
    <script type=""text/javascript"">

        function changePage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formFilter"").submit();
        }

        $(function () {

            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider, {
                start: [20000, 5000000],
                step: 5000,
                connect: true,
                direction: 'rtl',
                range: {
                    'min': 20000,
                    'max': 5000000
                }
            });

            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    marginMax.innerHTML = xvalue");
                WriteLiteral(@";
                } else {
                    marginMin.innerHTML = xvalue;
                }
                //console.log(values[handle]);
            });

            slider.noUiSlider.on('change', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    // setGetParameter('max_price', xvalue);
                    $('#max-value').val(xvalue);
                } else {
                    // setGetParameter('min_price', xvalue);
                    $('#min-value').val(xvalue);
                }
            });


            slider.noUiSlider.on('slide', function (values, handle) {

                console.log(values[0]);
                console.log(values[1]);

                var xvalue = Math.round(values[handle]);
                //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
            });



            function updateSliderRange(min, max) {
                slider.noUiSlid");
                WriteLiteral(@"er.updateOptions({
                    range: {
                        'min': min,
                        'max': max
                    }
                });
                subForm();
            }
        });

        function changeGroup() {
            $(""#formFilter"").submit();
        }
        function subForm() {
            $(""#formFilter"").submit();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<ShowCourseListItemViewModel>, int>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
