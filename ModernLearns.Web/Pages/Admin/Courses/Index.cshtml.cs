using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.DTOs.Course;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.Courses
{
    [PermissionChecker(9)]
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;
        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public Tuple<List<ShowCourseForAdminViewModel>,int> ListCourse { get; set; }

        public void OnGet(int pageId = 1, string filter = "")
        {
            ViewData["pageId"] = pageId;
            ListCourse = _courseService.GetCourseForAdmin(pageId,filter);
        }
        public IActionResult OnGetDeleteCourse(int courseId)
        {
            var res = _courseService.DeleteCourse(courseId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
