using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernLearns.Core.Services.Interfaces;

namespace ModernLearns.Web.Pages.Admin.AboutUs
{
    public class EditModel : PageModel
    {
        private IAboutUsService _aboutUs;
        public EditModel(IAboutUsService aboutUs)
        {
            _aboutUs = aboutUs;
        }
        [BindProperty]
        public ModernLearns.DataLayer.Entities.AboutUs.AboutUs AboutUs { get; set; }
        public void OnGet()
        {
            AboutUs = _aboutUs.GetLast();
            if (AboutUs == null)
            {
                Response.Redirect("/Admin/AboutUs");
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var aboutUs = _aboutUs.GetLast();
            if (aboutUs == null) return Redirect("/Admin/AboutUs");


            aboutUs.Text = AboutUs.Text;
            _aboutUs.Update(aboutUs);
            return RedirectToPage("Index");
        }
    }
}
