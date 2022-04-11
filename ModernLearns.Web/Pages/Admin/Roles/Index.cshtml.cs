using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Entities.User;

namespace ModernLearns.Web.Pages.Admin.Roles
{
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> RolesList { get; set; }
        public void OnGet()
        {
            RolesList = _permissionService.GetRoles();
        }

        public IActionResult OnGetDeleteRole(int roleId)
        {
            var res = _permissionService.DeleteRole(roleId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
