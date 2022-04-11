using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Entities.ContactUs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ModernLearns.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private ICourseService _courseService;
        private IAboutUsService _aboutUs;
        private IContactUsService _contactUs;
        public HomeController(IUserService userService, ICourseService courseService,IAboutUsService aboutUs,IContactUsService contactUs)
        {
            _userService = userService;
            _courseService = courseService;
            _aboutUs = aboutUs;
            _contactUs = contactUs;
        }
        public IActionResult Index()
        {
            //ViewBag.Popular = _courseService.GetPopularCourse();
            ViewBag.Comments = _courseService.GetCommentsForHome(3);
            return View(_courseService.GegCourse());
        }

        [Route("OnlinePayment/{id}")]
        public IActionResult OnlinePayment(int id)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallet = _userService.GetWalletByWalletId(id);

                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }
            }
            return View();
        }

        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text="انتخاب کنید",Value=""
                }
            };
            list.AddRange(_courseService.GetSubGroupForManageCourse(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/img/CKImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/img/CKImages/"}{fileName}";


            return Json(new { uploaded = true, url });
        }

        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View(_aboutUs.GetLast());
        }

        [Route("Contact-Us")]
        public IActionResult ContactUs()
        {
            return View(_contactUs.GetLast());
        }
        [HttpPost]
        [Route("Contact-Us")]
        public IActionResult ContactUs(ContactUsForm contactUsForm)
        {
            if (!ModelState.IsValid)
                return View(_contactUs.GetLast());

            contactUsForm.CreateDate = DateTime.Now;
            _contactUs.InsertQuestion(contactUsForm);
            TempData["Success"] = true;
            return Redirect("/Contact-Us");
        }

        [Route("/Home/HandleError/{code}")]
        public IActionResult HandlerError(int code)
        {


            if (code >= 500)
            {
                return View("ServerError");
            }

            return View("NotFound");

        }
    }
}
