using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Entities.ContactUs;

namespace ModernLearns.Web.Pages.Admin.ContactUs.HelpForm
{
    [PermissionChecker(22)]
    public class ShowModel : PageModel
    {
        private IContactUsService _service;

        public ShowModel(IContactUsService service)
        {
            _service = service;
        }

        public ContactUsForm ContactUs { get; set; }
        public void OnGet(int id)
        {
            ContactUs = _service.GetContactUsFormById(id);
            if (ContactUs == null)
            {
                Response.Redirect("/Admin/ContactUs/HelpForm");
            }
        }

        public IActionResult OnPost(int id, string answer)
        {
            ContactUs = _service.GetContactUsFormById(id);
            if (ContactUs == null)
            {
                Response.Redirect("/Admin/ContactUs/HelpForm");
            }
            if (string.IsNullOrEmpty(answer))
            {
                ModelState.AddModelError("answer", "پاسخ را وارد کنید");
                return Page();
            }

            _service.SendAnswerForContactUs(ContactUs, answer);
            return RedirectToPage("Index");
        }
    }
}
