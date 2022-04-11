using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModernLearns.Core.DTOs;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private IUserService _userService;
        private ICourseService _courseService;

        public HomeController(IUserService userService,ICourseService courseService)
        {
            _userService = userService;
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userService.GetDataForEditProfileUser(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel profile)
        {
            if (!ModelState.IsValid)
                return View(profile);

            _userService.EditProfile(User.Identity.Name,profile);

            //Log Out User
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login?EditProfile=true");
        }

        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [Route("UserPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            string currentUser = User.Identity.Name;

            if (!ModelState.IsValid)
                return View(change);

            if (!_userService.CompareOldPassword(change.OldPassword, currentUser))
            {
                ModelState.AddModelError("OldPassword", "کلمه عبور فعلی صحیح نمی باشد");
                return View(change);
            }

            _userService.ChangeUserPassword(currentUser, change.Password);
            ViewBag.IsSuccess = true;

            return View();
        }

        [Route("UserPanel/MyCourses")]
        public IActionResult MyCourses()
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var userCourse = _courseService.GetUserCourses(userId);
            return View(userCourse);
        }
    }
}