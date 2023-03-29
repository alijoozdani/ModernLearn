using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.ContactUs
{
    [PermissionChecker(22)]
    public class EditModel : PageModel
    {
        private IContactUsService _contactUs;
        public EditModel(IContactUsService contactUs)
        {
            _contactUs = contactUs;
        }
        [BindProperty]
        public ModernLearns.DataLayer.Entities.ContactUs.ContactUs ContactUs { get; set; }
        public void OnGet()
        {
            ContactUs = _contactUs.GetLast();
            if (ContactUs == null)
            {
                Response.Redirect("/Admin/ContactUs");
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var contactUs = _contactUs.GetLast();
            if (contactUs == null) return RedirectToPage("Index");

            contactUs.PhoneNumber = ContactUs.PhoneNumber;
            contactUs.Email = ContactUs.Email;
            contactUs.Address = ContactUs.Address;
            contactUs.Title = ContactUs.Title;
            contactUs.ResponseTime = ContactUs.ResponseTime;
            contactUs.IsDelete = false;

            _contactUs.UpdateContactUs(contactUs);
            return RedirectToPage("Index");
        }
    }
}
