using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.AboutUs
{
    [PermissionChecker(23)]
    public class AddModel : PageModel
    {
        private IAboutUsService _aboutUs;
        public AddModel(IAboutUsService aboutUs)
        {
            _aboutUs = aboutUs;
        }
        [BindProperty]
        public ModernLearns.DataLayer.Entities.AboutUs.AboutUs AboutUs { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var aboutUs = new DataLayer.Entities.AboutUs.AboutUs()
            {
                Text = AboutUs.Text,
                IsDelete = false
            };
            _aboutUs.Insert(aboutUs);
            return RedirectToPage("Index");
        }
    }
}
