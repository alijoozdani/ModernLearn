using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.DTOs;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.Users
{
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {
        private IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserForAdminViewModel UserForAdminViewModel { get; set; }
        public void OnGet(int pageId=1,string filterEmail="",string filterUserName="")
        {
            UserForAdminViewModel = _userService.GetUsers(pageId,filterEmail,filterUserName);
        }
        public IActionResult OnGetDeleteUser(int userId)
        {
            var res = _userService.DeleteUser(userId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
