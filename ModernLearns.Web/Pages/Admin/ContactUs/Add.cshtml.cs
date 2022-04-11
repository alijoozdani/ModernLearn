using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.ContactUs
{
    public class AddModel : PageModel
    {
        private IContactUsService _contactUs;
        public AddModel(IContactUsService contactUs)
        {
            _contactUs = contactUs;
        }
        [BindProperty]
        public ModernLearns.DataLayer.Entities.ContactUs.ContactUs ContactUs { get; set; }
        public void OnGet()
        {
            var contactUs = _contactUs.GetLast();
            if (contactUs != null)
            {
                Response.Redirect("/Admin");
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var contactUs = new DataLayer.Entities.ContactUs.ContactUs()
            {
                Address = ContactUs.Address,
                Title = ContactUs.Title,
                PhoneNumber = ContactUs.PhoneNumber,
                Email = ContactUs.Email,
                ResponseTime = ContactUs.ResponseTime,
                IsDelete = false
            };

            _contactUs.AddContactUs(contactUs);
            return RedirectToPage("Index");
        }
    }
}
