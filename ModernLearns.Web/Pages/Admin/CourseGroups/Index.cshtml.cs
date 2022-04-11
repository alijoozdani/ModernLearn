using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Entities.Course;

namespace ModernLearns.Web.Pages.Admin.CourseGroups
{
    [PermissionChecker(18)]
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;
        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public List<CourseGroup> CourseGroups { get; set; }
        public void OnGet()
        {
            CourseGroups = _courseService.GetAllGroup();
        }
        public IActionResult OnGetDeleteGroup(int groupId)
        {
            var res = _courseService.DeleteGroup(groupId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
